using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace GitUploader
{
    public partial class TIL : Form
    {
        string rootPath = "D:\\Project\\TIL";

        public TIL()
        {
            InitializeComponent();
            rootPath = Application.StartupPath;
            string filePath = Path.Combine(rootPath, "rootPath.txt");

            // 텍스트 파일이 존재하는지 확인합니다.
            Console.WriteLine(filePath);
            if (File.Exists(filePath))
            {
                // 파일을 읽어서 내용을 가져옵니다.
                string fileContent = File.ReadAllText(filePath);
                rootPath = fileContent;
            }
            else
            {
                MessageBox.Show("폴더 안에 rootPath.txt파일이 없습니다");
            }
        }

        /// <summary>
        /// 내일 사용할 일일기록 문서를 생성합니다!
        /// > 내일 날짜(년/월)폴더를 생성하고 (이미 폴더가 있으면 생략)
        /// > Daily 경로에 있는 'Default.md'를 복사해서 내일 날짜(yy.MM.dd)에 맞는 이름으로 변경해서 생성합니다
        /// > 만약 '내일'이 토/일 이면 월요일 날짜로 생성합니다
        /// </summary>
        public void CheckTomorrow()
        {
            string root = rootPath + "\\Daily";
            string defaultMDPath = Path.Combine(root, "Default.md");
            string errorLog = "";

            DateTime today = DateTime.Today;
            //today = DateTime.Today.AddDays(6);
            DateTime tomorrow = today.AddDays(1);
            if (tomorrow.DayOfWeek == DayOfWeek.Saturday)
            {
                tomorrow = tomorrow.AddDays(2);
            }
            else if (tomorrow.DayOfWeek == DayOfWeek.Sunday)
            {
                tomorrow = tomorrow.AddDays(1);
            }

            string year = tomorrow.ToString("yyyy");
            string month = tomorrow.ToString("MM");
            string day = tomorrow.ToString("dd");

            root = Path.Combine(root, year);
            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);

            root = Path.Combine(root, month); 
            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);

            string dailyFilePath = string.Concat(root, "\\", tomorrow.ToString("yy.MM."), day, ".md");
            if (File.Exists(dailyFilePath))
            {
                errorLog = "파일이 이미 생성되었습니다..." + year + "/" + month + "/" + day + "\n";
            }
            else
            { 
                File.Copy(defaultMDPath, dailyFilePath, true);
                errorLog = year + "년 " + month + "월 " + day + "일자 파일이 생성되었습니다!\n";
            }

            LogText.Text = errorLog;
        }

        private void GitCommit()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToString("yyyy/MM/dd dddd - HH:mm:ss UPLOAD"));

            LogText.Text += ".";
            RunGitCommand("pull", "", rootPath);
            LogText.Text += ".";
            RunGitCommand("add", "*", rootPath);
            LogText.Text += ".";
            RunGitCommand("commit", "-m \"커밋자동화테스트\"", rootPath);
            LogText.Text += ".";
            RunGitCommand("push", "", rootPath);
            LogText.Text += "Git 업로드 완료";
        }

        private void RunGitCommand(string command, string arguments, string workingDirectory)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = $"{command} {arguments}",
                WorkingDirectory = workingDirectory,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
            }
        }

        private void SaveDailyFile_Click(object sender, EventArgs e)
        {
            LogText.Text = "";
            CheckTomorrow();
            GitCommit();
        }

        private void CheckDailyFile_Click(object sender, EventArgs e)
        {
            LogText.Text = "";
            CheckTomorrow();
        }

        private void GitPush_Click(object sender, EventArgs e)
        {
            LogText.Text = "";
            GitCommit();
        }
    }
}

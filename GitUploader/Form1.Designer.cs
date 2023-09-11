namespace GitUploader
{
    partial class TIL
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TIL));
            this.SaveDailyFile = new System.Windows.Forms.Button();
            this.CheckDailyFile = new System.Windows.Forms.Button();
            this.LogText = new System.Windows.Forms.TextBox();
            this.license = new System.Windows.Forms.TextBox();
            this.GitPush = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveDailyFile
            // 
            this.SaveDailyFile.Location = new System.Drawing.Point(12, 12);
            this.SaveDailyFile.Name = "SaveDailyFile";
            this.SaveDailyFile.Size = new System.Drawing.Size(217, 64);
            this.SaveDailyFile.TabIndex = 0;
            this.SaveDailyFile.Text = "일일기록저장";
            this.SaveDailyFile.UseVisualStyleBackColor = true;
            this.SaveDailyFile.Click += new System.EventHandler(this.SaveDailyFile_Click);
            // 
            // CheckDailyFile
            // 
            this.CheckDailyFile.Location = new System.Drawing.Point(12, 82);
            this.CheckDailyFile.Name = "CheckDailyFile";
            this.CheckDailyFile.Size = new System.Drawing.Size(106, 31);
            this.CheckDailyFile.TabIndex = 1;
            this.CheckDailyFile.Text = "파일갱신";
            this.CheckDailyFile.UseVisualStyleBackColor = true;
            this.CheckDailyFile.Click += new System.EventHandler(this.CheckDailyFile_Click);
            // 
            // LogText
            // 
            this.LogText.BackColor = System.Drawing.SystemColors.Control;
            this.LogText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogText.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LogText.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LogText.Location = new System.Drawing.Point(12, 119);
            this.LogText.Multiline = true;
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(215, 39);
            this.LogText.TabIndex = 2;
            // 
            // license
            // 
            this.license.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.license.BackColor = System.Drawing.SystemColors.Control;
            this.license.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.license.Font = new System.Drawing.Font("굴림", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.license.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.license.Location = new System.Drawing.Point(14, 165);
            this.license.Multiline = true;
            this.license.Name = "license";
            this.license.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.license.Size = new System.Drawing.Size(215, 14);
            this.license.TabIndex = 3;
            this.license.Text = "Made by Raven";
            // 
            // GitPush
            // 
            this.GitPush.Location = new System.Drawing.Point(123, 82);
            this.GitPush.Name = "GitPush";
            this.GitPush.Size = new System.Drawing.Size(106, 31);
            this.GitPush.TabIndex = 4;
            this.GitPush.Text = "Git Push";
            this.GitPush.UseVisualStyleBackColor = true;
            this.GitPush.Click += new System.EventHandler(this.GitPush_Click);
            // 
            // TIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 186);
            this.Controls.Add(this.GitPush);
            this.Controls.Add(this.license);
            this.Controls.Add(this.LogText);
            this.Controls.Add(this.CheckDailyFile);
            this.Controls.Add(this.SaveDailyFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TIL";
            this.Text = "TIL Uploader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveDailyFile;
        private System.Windows.Forms.Button CheckDailyFile;
        private System.Windows.Forms.TextBox LogText;
        private System.Windows.Forms.TextBox license;
        private System.Windows.Forms.Button GitPush;
    }
}


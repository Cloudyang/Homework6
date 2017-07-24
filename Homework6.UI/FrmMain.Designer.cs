namespace Homework6.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJDCrawler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJDCrawler
            // 
            this.btnJDCrawler.Location = new System.Drawing.Point(23, 12);
            this.btnJDCrawler.Name = "btnJDCrawler";
            this.btnJDCrawler.Size = new System.Drawing.Size(93, 23);
            this.btnJDCrawler.TabIndex = 0;
            this.btnJDCrawler.Text = "京东测试采集";
            this.btnJDCrawler.UseVisualStyleBackColor = true;
            this.btnJDCrawler.Click += new System.EventHandler(this.btnJDCrawler_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnJDCrawler);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJDCrawler;
    }
}


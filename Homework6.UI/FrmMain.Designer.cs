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
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCleanData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCrawler = new System.Windows.Forms.GroupBox();
            this.gbLucene = new System.Windows.Forms.GroupBox();
            this.dgvCrawler = new System.Windows.Forms.DataGridView();
            this.dgvLucene = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbCrawler.SuspendLayout();
            this.gbLucene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrawler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLucene)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJDCrawler
            // 
            this.btnJDCrawler.Location = new System.Drawing.Point(4, 4);
            this.btnJDCrawler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJDCrawler.Name = "btnJDCrawler";
            this.btnJDCrawler.Size = new System.Drawing.Size(124, 29);
            this.btnJDCrawler.TabIndex = 0;
            this.btnJDCrawler.Text = "京东测试采集";
            this.btnJDCrawler.UseVisualStyleBackColor = true;
            this.btnJDCrawler.Click += new System.EventHandler(this.btnJDCrawler_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(153, 4);
            this.btnResume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(100, 29);
            this.btnResume.TabIndex = 1;
            this.btnResume.Text = "继续";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(282, 4);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 29);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(415, 4);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 29);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCleanData
            // 
            this.btnCleanData.Location = new System.Drawing.Point(533, 4);
            this.btnCleanData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCleanData.Name = "btnCleanData";
            this.btnCleanData.Size = new System.Drawing.Size(100, 29);
            this.btnCleanData.TabIndex = 4;
            this.btnCleanData.Text = "清除数据";
            this.btnCleanData.UseVisualStyleBackColor = true;
            this.btnCleanData.Click += new System.EventHandler(this.btnCleanData_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnJDCrawler);
            this.panel1.Controls.Add(this.btnCleanData);
            this.panel1.Controls.Add(this.btnResume);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 42);
            this.panel1.TabIndex = 5;
            // 
            // gbCrawler
            // 
            this.gbCrawler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCrawler.Controls.Add(this.dgvCrawler);
            this.gbCrawler.Location = new System.Drawing.Point(22, 61);
            this.gbCrawler.Name = "gbCrawler";
            this.gbCrawler.Size = new System.Drawing.Size(889, 292);
            this.gbCrawler.TabIndex = 6;
            this.gbCrawler.TabStop = false;
            this.gbCrawler.Text = "数据采集块";
            // 
            // gbLucene
            // 
            this.gbLucene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLucene.Controls.Add(this.dgvLucene);
            this.gbLucene.Location = new System.Drawing.Point(22, 360);
            this.gbLucene.Name = "gbLucene";
            this.gbLucene.Size = new System.Drawing.Size(889, 309);
            this.gbLucene.TabIndex = 7;
            this.gbLucene.TabStop = false;
            this.gbLucene.Text = "全文检索块";
            // 
            // dgvCrawler
            // 
            this.dgvCrawler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrawler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCrawler.Location = new System.Drawing.Point(3, 21);
            this.dgvCrawler.Name = "dgvCrawler";
            this.dgvCrawler.RowTemplate.Height = 27;
            this.dgvCrawler.Size = new System.Drawing.Size(883, 268);
            this.dgvCrawler.TabIndex = 0;
            // 
            // dgvLucene
            // 
            this.dgvLucene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLucene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLucene.Location = new System.Drawing.Point(3, 21);
            this.dgvLucene.Name = "dgvLucene";
            this.dgvLucene.RowTemplate.Height = 27;
            this.dgvLucene.Size = new System.Drawing.Size(883, 285);
            this.dgvLucene.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 681);
            this.Controls.Add(this.gbLucene);
            this.Controls.Add(this.gbCrawler);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "练习数据采集全文检索功能框";
            this.panel1.ResumeLayout(false);
            this.gbCrawler.ResumeLayout(false);
            this.gbLucene.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrawler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLucene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJDCrawler;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCleanData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCrawler;
        private System.Windows.Forms.GroupBox gbLucene;
        private System.Windows.Forms.DataGridView dgvCrawler;
        private System.Windows.Forms.DataGridView dgvLucene;
    }
}


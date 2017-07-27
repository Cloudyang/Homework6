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
            this.dgvCrawler = new System.Windows.Forms.DataGridView();
            this.gbLucene = new System.Windows.Forms.GroupBox();
            this.dgvLucene = new System.Windows.Forms.DataGridView();
            this.btnLuceneIndex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbCrawler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrawler)).BeginInit();
            this.gbLucene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLucene)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJDCrawler
            // 
            this.btnJDCrawler.Location = new System.Drawing.Point(3, 3);
            this.btnJDCrawler.Name = "btnJDCrawler";
            this.btnJDCrawler.Size = new System.Drawing.Size(93, 23);
            this.btnJDCrawler.TabIndex = 0;
            this.btnJDCrawler.Text = "京东测试采集";
            this.btnJDCrawler.UseVisualStyleBackColor = true;
            this.btnJDCrawler.Click += new System.EventHandler(this.btnJDCrawler_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(115, 3);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 1;
            this.btnResume.Text = "继续";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(212, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(311, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCleanData
            // 
            this.btnCleanData.Location = new System.Drawing.Point(400, 3);
            this.btnCleanData.Name = "btnCleanData";
            this.btnCleanData.Size = new System.Drawing.Size(75, 23);
            this.btnCleanData.TabIndex = 4;
            this.btnCleanData.Text = "清除数据";
            this.btnCleanData.UseVisualStyleBackColor = true;
            this.btnCleanData.Click += new System.EventHandler(this.btnCleanData_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnLuceneIndex);
            this.panel1.Controls.Add(this.btnJDCrawler);
            this.panel1.Controls.Add(this.btnCleanData);
            this.panel1.Controls.Add(this.btnResume);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Location = new System.Drawing.Point(16, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 34);
            this.panel1.TabIndex = 5;
            // 
            // gbCrawler
            // 
            this.gbCrawler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCrawler.Controls.Add(this.dgvCrawler);
            this.gbCrawler.Location = new System.Drawing.Point(16, 49);
            this.gbCrawler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCrawler.Name = "gbCrawler";
            this.gbCrawler.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCrawler.Size = new System.Drawing.Size(667, 234);
            this.gbCrawler.TabIndex = 6;
            this.gbCrawler.TabStop = false;
            this.gbCrawler.Text = "数据采集块";
            // 
            // dgvCrawler
            // 
            this.dgvCrawler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrawler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCrawler.Location = new System.Drawing.Point(2, 16);
            this.dgvCrawler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCrawler.Name = "dgvCrawler";
            this.dgvCrawler.RowTemplate.Height = 27;
            this.dgvCrawler.Size = new System.Drawing.Size(663, 216);
            this.dgvCrawler.TabIndex = 0;
            // 
            // gbLucene
            // 
            this.gbLucene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLucene.Controls.Add(this.dgvLucene);
            this.gbLucene.Location = new System.Drawing.Point(16, 322);
            this.gbLucene.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLucene.Name = "gbLucene";
            this.gbLucene.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLucene.Size = new System.Drawing.Size(667, 213);
            this.gbLucene.TabIndex = 7;
            this.gbLucene.TabStop = false;
            this.gbLucene.Text = "全文检索块";
            // 
            // dgvLucene
            // 
            this.dgvLucene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLucene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLucene.Location = new System.Drawing.Point(2, 16);
            this.dgvLucene.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLucene.Name = "dgvLucene";
            this.dgvLucene.RowTemplate.Height = 27;
            this.dgvLucene.Size = new System.Drawing.Size(663, 195);
            this.dgvLucene.TabIndex = 0;
            // 
            // btnLuceneIndex
            // 
            this.btnLuceneIndex.Location = new System.Drawing.Point(519, 2);
            this.btnLuceneIndex.Name = "btnLuceneIndex";
            this.btnLuceneIndex.Size = new System.Drawing.Size(101, 23);
            this.btnLuceneIndex.TabIndex = 5;
            this.btnLuceneIndex.Text = "创建Lucene索引";
            this.btnLuceneIndex.UseVisualStyleBackColor = true;
            this.btnLuceneIndex.Click += new System.EventHandler(this.btnLuceneIndex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "检索关键字：";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(114, 294);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(275, 21);
            this.txtKeyword.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(416, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 545);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLucene);
            this.Controls.Add(this.gbCrawler);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "练习数据采集全文检索功能框";
            this.panel1.ResumeLayout(false);
            this.gbCrawler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrawler)).EndInit();
            this.gbLucene.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLucene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnLuceneIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
    }
}


namespace PDFReaderOCX
{
    partial class MainForm
    {
        /// <summary>
        /// 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// free all memories.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows auto generated codes.

        /// <summary>
        /// do not edit.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_search = new System.Windows.Forms.ToolStripTextBox();
            this.btn_whole = new System.Windows.Forms.ToolStripButton();
            this.btn_case = new System.Windows.Forms.ToolStripButton();
            this.btn_prev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_continous = new System.Windows.Forms.ToolStripButton();
            this.btn_dual_continous = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.m_outline = new AxRDPDFLib.AxRDPDFOutline();
            this.m_view = new AxRDPDFLib.AxRDPDFViewer();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_outline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_view)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1564, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dragToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.toolStripSeparator4,
            this.copyToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.toolToolStripMenuItem.Text = "Edit";
            // 
            // dragToolStripMenuItem
            // 
            this.dragToolStripMenuItem.Name = "dragToolStripMenuItem";
            this.dragToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dragToolStripMenuItem.Text = "Drag";
            this.dragToolStripMenuItem.Click += new System.EventHandler(this.dragToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF Files|*.pdf";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.txt_search,
            this.btn_whole,
            this.btn_case,
            this.btn_prev,
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.toolStripButton4,
            this.toolStripSeparator6,
            this.btn_continous,
            this.btn_dual_continous});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1564, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Page:";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = "Zoom:";
            this.toolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "+";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "-";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 25);
            // 
            // btn_whole
            // 
            this.btn_whole.Checked = true;
            this.btn_whole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_whole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_whole.Image = ((System.Drawing.Image)(resources.GetObject("btn_whole.Image")));
            this.btn_whole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_whole.Name = "btn_whole";
            this.btn_whole.Size = new System.Drawing.Size(86, 22);
            this.btn_whole.Text = "Whole Word";
            this.btn_whole.Click += new System.EventHandler(this.btn_whole_Click);
            // 
            // btn_case
            // 
            this.btn_case.Checked = true;
            this.btn_case.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_case.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_case.Image = ((System.Drawing.Image)(resources.GetObject("btn_case.Image")));
            this.btn_case.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_case.Name = "btn_case";
            this.btn_case.Size = new System.Drawing.Size(40, 22);
            this.btn_case.Text = "Case";
            this.btn_case.Click += new System.EventHandler(this.btn_case_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev.Image")));
            this.btn_prev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(23, 22);
            this.btn_prev.Text = "<";
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = ">";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(121, 22);
            this.toolStripButton4.Text = "Save Page As BMP";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_continous
            // 
            this.btn_continous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_continous.Image = ((System.Drawing.Image)(resources.GetObject("btn_continous.Image")));
            this.btn_continous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_continous.Name = "btn_continous";
            this.btn_continous.Size = new System.Drawing.Size(70, 22);
            this.btn_continous.Text = "Continous";
            this.btn_continous.Click += new System.EventHandler(this.btn_continous_Click);
            // 
            // btn_dual_continous
            // 
            this.btn_dual_continous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_dual_continous.Image = ((System.Drawing.Image)(resources.GetObject("btn_dual_continous.Image")));
            this.btn_dual_continous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_dual_continous.Name = "btn_dual_continous";
            this.btn_dual_continous.Size = new System.Drawing.Size(96, 22);
            this.btn_dual_continous.Text = "DualContinous";
            this.btn_dual_continous.Click += new System.EventHandler(this.btn_dual_continous_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.m_outline);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_view);
            this.splitContainer1.Size = new System.Drawing.Size(1564, 870);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 4;
            // 
            // m_outline
            // 
            this.m_outline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_outline.Enabled = true;
            this.m_outline.Location = new System.Drawing.Point(0, 0);
            this.m_outline.Name = "m_outline";
            this.m_outline.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("m_outline.OcxState")));
            this.m_outline.Size = new System.Drawing.Size(294, 870);
            this.m_outline.TabIndex = 0;
            this.m_outline.OnPageJump += new AxRDPDFLib._IRDPDFOutlineEvents_OnPageJumpEventHandler(this.m_outline_OnPageJump);
            this.m_outline.OnUrlOpen += new AxRDPDFLib._IRDPDFOutlineEvents_OnUrlOpenEventHandler(this.m_outline_OnUrlOpen);
            this.m_outline.OnFileOpen += new AxRDPDFLib._IRDPDFOutlineEvents_OnFileOpenEventHandler(this.m_outline_OnFileOpen);
            // 
            // m_view
            // 
            this.m_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_view.Enabled = true;
            this.m_view.Location = new System.Drawing.Point(0, 0);
            this.m_view.Name = "m_view";
            this.m_view.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("m_view.OcxState")));
            this.m_view.Size = new System.Drawing.Size(1266, 870);
            this.m_view.TabIndex = 0;
            this.m_view.OnPDFFound += new AxRDPDFLib._IRDPDFViewerEvents_OnPDFFoundEventHandler(this.m_view_OnPDFFound);
            this.m_view.OnPDFPageChanged += new AxRDPDFLib._IRDPDFViewerEvents_OnPDFPageChangedEventHandler(this.m_view_OnPDFPageChanged);
            this.m_view.OnPDFZoomChanged += new AxRDPDFLib._IRDPDFViewerEvents_OnPDFZoomChangedEventHandler(this.m_view_OnPDFZoomChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "BMP File|*.bmp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 920);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_outline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dragToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_search;
        private System.Windows.Forms.ToolStripButton btn_prev;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_whole;
        private System.Windows.Forms.ToolStripButton btn_case;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxRDPDFLib.AxRDPDFOutline m_outline;
        private AxRDPDFLib.AxRDPDFViewer m_view;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_continous;
        private System.Windows.Forms.ToolStripButton btn_dual_continous;
    }
}


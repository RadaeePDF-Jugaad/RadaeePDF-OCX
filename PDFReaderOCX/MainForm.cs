using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDPDFLib;

namespace PDFReaderOCX
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private RDPDFDoc m_doc;
        private int m_pageno;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            m_doc = new RDPDFDoc();
            RDPDF_ERROR err = m_doc.OpenPath(openFileDialog1.FileName, "");
            if ( err != RDPDF_ERROR.RDERR_OK)
            {
                if (err == RDPDF_ERROR.RDERR_ENCRYPT)
                {
                    //todo: display password dialog when PDF file is encrypted.
                    MessageBox.Show("Password dialog is not implemented.", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show(err.ToString(), "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_doc = null;
                return;
            }
            if(!m_view.PDFOpen(m_doc, RDPDF_VIEWMODE.RDVM_CONTINOUS, 4))
            {
                MessageBox.Show("PDFViewer not loaded.", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_doc.Close();
                m_doc = null;
            }
            if (m_view.PDFViewMode == RDPDF_VIEWMODE.RDVM_CONTINOUS)
            {
                btn_continous.Checked = true;
                btn_dual_continous.Checked = false;
            }
            else
            {
                btn_continous.Checked = false;
                btn_dual_continous.Checked = true;
            }

            m_view.PDFTool = RDPDF_TOOL.TOOL_DRAG;
            dragToolStripMenuItem.Checked = true;
            selectToolStripMenuItem.Checked = false;
            if(!m_outline.PDFOpen(m_doc))
            {
                MessageBox.Show("Outlines not loaded.", "Outline Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("1.Please use Ctrl + Wheel to zoom pages, and mouse wheel to scroll.\n" +
                "2.Left View is outline of PDF file, and Right View is pages layout", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_doc == null) return;
            m_view.PDFClose();
            m_outline.PDFClose();
            m_doc.Close();
            m_doc = null;
        }

        private void m_view_OnPDFPageChanged(object sender, AxRDPDFLib._IRDPDFViewerEvents_OnPDFPageChangedEvent e)
        {
            m_pageno = e.pageno;
            toolStripLabel1.Text = "Page:" + (m_pageno + 1);
        }

        private void m_view_OnPDFZoomChanged(object sender, AxRDPDFLib._IRDPDFViewerEvents_OnPDFZoomChangedEvent e)
        {
            toolStripLabel2.Text = "Zoom:" + (int)(e.ratio * 100) + "%";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            m_view.PDFScale = m_view.PDFScale * 1.25f;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            m_view.PDFScale = m_view.PDFScale * 0.8f;
        }

        private void dragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_view.PDFTool = RDPDF_TOOL.TOOL_DRAG;
            dragToolStripMenuItem.Checked = true;
            selectToolStripMenuItem.Checked = false;
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_view.PDFTool = RDPDF_TOOL.TOOL_SELECT;
            dragToolStripMenuItem.Checked = false;
            selectToolStripMenuItem.Checked = true;
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            m_view.PDFSearch(txt_search.Text, btn_whole.Checked, btn_case.Checked, RDPDF_SEARCHDIR.SEARCH_UP);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            m_view.PDFSearch(txt_search.Text, btn_whole.Checked, btn_case.Checked, RDPDF_SEARCHDIR.SEARCH_DOWN);
        }

        private void btn_whole_Click(object sender, EventArgs e)
        {
            btn_whole.Checked = !btn_whole.Checked;
        }

        private void btn_case_Click(object sender, EventArgs e)
        {
            btn_case.Checked = !btn_case.Checked;
        }

        private void m_view_OnPDFFound(object sender, AxRDPDFLib._IRDPDFViewerEvents_OnPDFFoundEvent e)
        {
            if (!e.found)
                MessageBox.Show("No More Found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void m_outline_OnFileOpen(object sender, AxRDPDFLib._IRDPDFOutlineEvents_OnFileOpenEvent e)
        {
            MessageBox.Show("To open:" + e.fileName, "Open File", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void m_outline_OnPageJump(object sender, AxRDPDFLib._IRDPDFOutlineEvents_OnPageJumpEvent e)
        {
            m_view.PDFJump(e.pageno, e.y);
        }

        private void m_outline_OnUrlOpen(object sender, AxRDPDFLib._IRDPDFOutlineEvents_OnUrlOpenEvent e)
        {
            MessageBox.Show("To open:" + e.url, "Open URL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_view.PDFCopyText();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (m_doc == null || m_view == null) return;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            if (m_doc.RenderPage(m_pageno, saveFileDialog1.FileName, 1))
                MessageBox.Show("Page " + (m_pageno + 1) + " saved with scale 100% in DPI 72", "Save Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static private int random_func()
        {
            return 4;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //byte[] data = new byte[2048];
            //rand_data(data, 5, random_func);
            //data[5] = 10;
        }

        private void btn_continous_Click(object sender, EventArgs e)
        {
            m_view.PDFViewMode = RDPDF_VIEWMODE.RDVM_CONTINOUS;
            btn_continous.Checked = true;
            btn_dual_continous.Checked = false;
        }

        private void btn_dual_continous_Click(object sender, EventArgs e)
        {
            m_view.PDFViewMode = RDPDF_VIEWMODE.RDVM_DUAL_CONTINOUS;
            btn_continous.Checked = false;
            btn_dual_continous.Checked = true;
        }
        /*
        public delegate int RandomDelegate();
        [DllImport("NETTest.dll", EntryPoint="rand_data", CallingConvention = CallingConvention.Cdecl)]
        private static extern void rand_data([MarshalAs(UnmanagedType.LPArray, SizeConst=2048)]byte[] buffer, int cnt, RandomDelegate callback);
        */
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLy_BVMB
{
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void chuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmChuyenBay();
            frm.ShowDialog();
        }

        private void giáVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmGiaVe();
            frm.ShowDialog();
        }

        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmSanBay();
            frm.ShowDialog();
        }

        private void máyBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmMayBay();
            frm.ShowDialog();
        }

        private void ghếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmGhe();
            frm.ShowDialog();
        }

        private void hànhLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmHanhLy();
            frm.ShowDialog();
        }

        private void hànhKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmHanhKhach();
            frm.ShowDialog();
        }

        private void bánVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmBanVe();
            frm.ShowDialog();
        }

        private void huỷVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmHuyVe();
            frm.ShowDialog();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmThanhToan();
            frm.ShowDialog();
        }

        private void véChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmVeChuyenBay();
            form.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmBCDoanhThuVe();
            form.ShowDialog();
        }

        private void ghếTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmBaoCaoGheTrong();
            form.ShowDialog();
        }

        private void kháchVIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmBaoCaoKhachVip();
            form.ShowDialog();
        }

        private void véBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmBCVeBanNgay();
            form.ShowDialog();
        }
    }
}

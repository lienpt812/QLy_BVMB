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
    public partial class FrmChuyenBay : Form
    {
        public FrmChuyenBay()
        {
            InitializeComponent();
        }

        private void lblMalop_Click(object sender, EventArgs e)
        {

        }

        private void lblNGAYSINH_Click(object sender, EventArgs e)
        {

        }
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private void BANGCHUYENBAY()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM CHUYENBAY");
            Data_CHUYENBAY.DataSource = dta;
            cboTRANGTHAI.Items.Clear();
            cboTRANGTHAI.Items.Add("Đang mở bán");
            cboTRANGTHAI.Items.Add("Đã cất cánh");
            cboTRANGTHAI.Items.Add("Đã hạ cánh");
            cboTRANGTHAI.Items.Add("Hết vé");
            cboTRANGTHAI.Items.Add("Hủy");
            cboTRANGTHAI.SelectedIndex = -1;

        }
        private void BANGMAYBAY()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM MAYBAY");
            cboMAMAYBAY.DataSource = dta;
            cboMAMAYBAY.ValueMember = "MAMAYBAY";
        }
        private void BANGSANBAY()
        {
            DataTable dtaDi = knn.LayBang("SELECT * FROM SANBAY");
            DataTable dtaDen = knn.LayBang("SELECT * FROM SANBAY");

            cboSANBAYDI.DataSource = dtaDi;
            cboSANBAYDI.ValueMember = "MaSanBay";

            cboSANBAYDEN.DataSource = dtaDen;
            cboSANBAYDEN.ValueMember = "MaSanBay";

            cboSANBAYDI.SelectedIndex = -1;
            cboSANBAYDEN.SelectedIndex = -1;
        }
        private void HIENTHIDULIEU()
        {
            txtMACHUYENBAY.DataBindings.Clear();
            txtMACHUYENBAY.DataBindings.Add("Text", Data_CHUYENBAY.DataSource, "MACB");
            cboMAMAYBAY.DataBindings.Clear();
            cboMAMAYBAY.DataBindings.Add("Text", Data_CHUYENBAY.DataSource, "MAMAYBAY");
            cboSANBAYDI.DataBindings.Clear();
            cboSANBAYDI.DataBindings.Add("Text", Data_CHUYENBAY.DataSource, "SANBAYDI");
            cboSANBAYDEN.DataBindings.Clear();
            cboSANBAYDEN.DataBindings.Add("Text", Data_CHUYENBAY.DataSource, "SANBAYDEN");
            dtNGAYDI.DataBindings.Clear();
            dtNGAYDI.DataBindings.Add("Text", Data_CHUYENBAY.DataSource, "NGAYGIODI");
            dtNGAYDEN.DataBindings.Clear();
            dtNGAYDEN.DataBindings.Add("Text", Data_CHUYENBAY.DataSource, "NGAYGIODEN");
            cboTRANGTHAI.DataBindings.Clear();
            cboTRANGTHAI.DataBindings.Add("Text", Data_CHUYENBAY.DataSource, "TRANGTHAI");

        }
        private void FrmChuyenBay_Load(object sender, EventArgs e)
        {
            BANGMAYBAY();
            BANGSANBAY();
            BANGCHUYENBAY();
            HIENTHIDULIEU();
        }

        private void btnTAOMOI_Click(object sender, EventArgs e)
        {
            txtMACHUYENBAY.Text = "";
            cboMAMAYBAY.Text = "";
            cboSANBAYDI.Text = "";
            cboSANBAYDEN.Text = "";
            dtNGAYDI.Text = "";
            dtNGAYDEN.Text = "";
            cboTRANGTHAI.Text = "";
            txtMACHUYENBAY.Focus();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            String sql_luu = "INSERT INTO CHUYENBAY VALUES('" + txtMACHUYENBAY.Text + "','" + cboMAMAYBAY.Text + "',N'" + cboSANBAYDI.Text + "',N'" + cboSANBAYDEN.Text + "','" + dtNGAYDI.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dtNGAYDEN.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',N'" + cboTRANGTHAI.Text + "')";
            knn.ThucThi(sql_luu);
            BANGCHUYENBAY();
            HIENTHIDULIEU();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            String sql_sua = "UPDATE CHUYENBAY SET MAMAYBAY='" + cboMAMAYBAY.Text + "',SANBAYDI=N'" + cboSANBAYDI.Text + "',SANBAYDEN=N'" + cboSANBAYDEN.Text + "',NGAYGIODI='" + dtNGAYDI.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',NGAYGIODEN='" + dtNGAYDEN.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',TRANGTHAI=N'" + cboTRANGTHAI.Text + "' WHERE MACB='" + txtMACHUYENBAY.Text + "'";
            knn.ThucThi(sql_sua);
            BANGCHUYENBAY();
            HIENTHIDULIEU();

        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            String sql_xoa = "DELETE FROM CHUYENBAY WHERE MACB='" + txtMACHUYENBAY.Text + "'";
            knn.ThucThi(sql_xoa);
            BANGCHUYENBAY();
            HIENTHIDULIEU();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

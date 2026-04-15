using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuHang;

namespace QLy_BVMB
{
    public partial class FrmSanBay : Form
    {
        public FrmSanBay()
        {
            InitializeComponent();
        }
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private void BANGSANBAY()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM SANBAY");
            Data_SANBAY.DataSource = dta;
        }
        private void HIENTHIDULIEU()
        {
            txtMASANBAY.DataBindings.Clear();
            txtMASANBAY.DataBindings.Add("Text", Data_SANBAY.DataSource, "MASANBAY");
            txtTENSANBAY.DataBindings.Clear();
            txtTENSANBAY.DataBindings.Add("Text", Data_SANBAY.DataSource, "TENSANBAY");
            txtTHANHPHO.DataBindings.Clear();
            txtTHANHPHO.DataBindings.Add("Text", Data_SANBAY.DataSource, "THANHPHO");
            txtQUOCGIA.DataBindings.Clear();
            txtQUOCGIA.DataBindings.Add("Text", Data_SANBAY.DataSource, "QUOCGIA");

        }
        private void btnTAOMOI_Click(object sender, EventArgs e)
        {
            txtMASANBAY.Text = "";
            txtTENSANBAY.Text = "";
            txtTHANHPHO.Text = "";
            txtQUOCGIA.Text = "";
            txtMASANBAY.Focus();
        }

        private void FrmSanBay_Load(object sender, EventArgs e)
        {
            BANGSANBAY();
            HIENTHIDULIEU();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            String sql_luu = "INSERT INTO SANBAY VALUES('" + txtMASANBAY.Text + "',N'" + txtTENSANBAY.Text + "',N'" + txtTHANHPHO.Text + "',N'" + txtQUOCGIA.Text + "')";
            knn.ThucThi(sql_luu);
            BANGSANBAY();
            HIENTHIDULIEU();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            string sql_sua = "UPDATE SANBAY SET TENSANBAY=N'" + txtTENSANBAY.Text + "', THANHPHO=N'" + txtTHANHPHO.Text + "', QUOCGIA=N'" + txtQUOCGIA.Text + "' WHERE MASANBAY='" + txtMASANBAY.Text + "'";
            knn.ThucThi(sql_sua);
            BANGSANBAY();
            HIENTHIDULIEU();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            string sql_xoa = "DELETE FROM SANBAY WHERE MASANBAY='" + txtMASANBAY.Text + "'";
            knn.ThucThi(sql_xoa);
            BANGSANBAY();
            HIENTHIDULIEU();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

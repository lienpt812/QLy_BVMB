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
    public partial class FrmGiaVe : Form
    {
        public FrmGiaVe()
        {
            InitializeComponent();
        }

        private void Data_CHUYENBAY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private void BANGGIAVE()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM GIAVE");
            Data_GIAVE.DataSource = dta;
        }
        private void BANGCHUYENBAY()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM CHUYENBAY");
            cboMACHUYENBAY.DataSource = dta;
            cboMACHUYENBAY.ValueMember = "MACB";
        }
        private void BANGLOAIGHE()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM GHE");
            cboLOAIGHE.Items.Clear();
            cboLOAIGHE.Items.Add("Phổ thông");
            cboLOAIGHE.Items.Add("Thương gia");

        }
        private void HIENTHIDULIEU()
        {
            cboMACHUYENBAY.DataBindings.Clear();
            cboMACHUYENBAY.DataBindings.Add("Text", Data_GIAVE.DataSource, "MACB");
            cboLOAIGHE.DataBindings.Clear();
            cboLOAIGHE.DataBindings.Add("Text", Data_GIAVE.DataSource, "LOAIGHE");
            txtGIAVE.DataBindings.Clear();
            txtGIAVE.DataBindings.Add("Text", Data_GIAVE.DataSource, "GIA");
        }
        private void FrmGiaVe_Load(object sender, EventArgs e)
        {
            BANGCHUYENBAY();
            BANGLOAIGHE();
            BANGGIAVE();
            HIENTHIDULIEU();
        }

        private void btnTAOMOI_Click(object sender, EventArgs e)
        {
            cboMACHUYENBAY.Text = "";
            cboLOAIGHE.Text = "";
            txtGIAVE.Text = "";

        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            String sql_luu = "INSERT INTO GIAVE VALUES('" + cboMACHUYENBAY.Text + "',N'" + cboLOAIGHE.Text + "','" + txtGIAVE.Text + "')";
            knn.ThucThi(sql_luu);
            BANGGIAVE();
            HIENTHIDULIEU();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            string sql_sua = "UPDATE GIAVE SET Gia = " + txtGIAVE.Text +
                             " WHERE MaCB = '" + cboMACHUYENBAY.Text + "' AND LoaiGhe = N'" + cboLOAIGHE.Text + "'";
            knn.ThucThi(sql_sua);
            BANGGIAVE();
            HIENTHIDULIEU();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            string sql_xoa = "DELETE FROM GIAVE WHERE MaCB = '" + cboMACHUYENBAY.Text + "' AND LoaiGhe = N'" + cboLOAIGHE.Text + "'";
            knn.ThucThi(sql_xoa);
            BANGGIAVE();
            HIENTHIDULIEU();

        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

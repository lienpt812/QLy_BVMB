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
    public partial class FrmGhe : Form
    {
        public FrmGhe()
        {
            InitializeComponent();
        }
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private void BANGGHE()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM GHE");
            Data_GHE.DataSource = dta;
            cboLOAIGHE.Items.Clear();
            cboLOAIGHE.Items.Add("Phổ thông");
            cboLOAIGHE.Items.Add("Thương gia");

        }
        private void BANGMAYBAY()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM MAYBAY");
            cboMAMAYBAY.DataSource = dta;
            cboMAMAYBAY.ValueMember = "MAMAYBAY";
        }
        private void HIENTHIDULIEU()
        {
            txtMAGHE.DataBindings.Clear();
            txtMAGHE.DataBindings.Add("Text", Data_GHE.DataSource, "MAGHE");
            cboMAMAYBAY.DataBindings.Clear();
            cboMAMAYBAY.DataBindings.Add("Text", Data_GHE.DataSource, "MAMAYBAY");
            cboLOAIGHE.DataBindings.Clear();
            cboLOAIGHE.DataBindings.Add("Text", Data_GHE.DataSource, "LOAIGHE");
        }
        private void FrmGhe_Load(object sender, EventArgs e)
        {
            BANGGHE();
            BANGMAYBAY();
            HIENTHIDULIEU();
        }

        private void btnTAOMOI_Click(object sender, EventArgs e)
        {
            txtMAGHE.Text = "";
            cboMAMAYBAY.Text = "";
            cboLOAIGHE.Text = "";
            txtMAGHE.Focus();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            String sql_luu = "INSERT INTO GHE VALUES('" + txtMAGHE.Text + "','" + cboMAMAYBAY.Text + "',N'" + cboLOAIGHE.Text + "')";
            knn.ThucThi(sql_luu);
            BANGGHE();
            HIENTHIDULIEU();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            String sql_sua = "UPDATE GHE SET MAMAYBAY='" + cboMAMAYBAY.Text + "',LOAIGHE=N'" + cboLOAIGHE.Text + "' WHERE MAGHE='" + txtMAGHE.Text + "'";
            knn.ThucThi(sql_sua);
            BANGGHE();
            HIENTHIDULIEU();

        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            String sql_xoa = "DELETE FROM GHE WHERE MAGHE='" + txtMAGHE.Text + "'";
            knn.ThucThi(sql_xoa);
            BANGGHE();
            HIENTHIDULIEU();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}

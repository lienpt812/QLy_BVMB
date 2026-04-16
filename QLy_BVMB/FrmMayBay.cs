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
    public partial class FrmMayBay : Form
    {
        public FrmMayBay()
        {
            InitializeComponent();
        }

        private void lblTIEUDE_Click(object sender, EventArgs e)
        {

        }

        private void Data_SANBAY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private void BANGMAYBAY()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM MAYBAY");
            Data_MAYBAY.DataSource = dta;
        }
        private void HIENTHIDULIEU()
        {
            txtMAMAYBAY.DataBindings.Clear();
            txtMAMAYBAY.DataBindings.Add("Text", Data_MAYBAY.DataSource, "MAMAYBAY");
            txtHANGHANGKHONG.DataBindings.Clear();
            txtHANGHANGKHONG.DataBindings.Add("Text", Data_MAYBAY.DataSource, "HANGHANGKHONG");
            txtSOGHE.DataBindings.Clear();
            txtSOGHE.DataBindings.Add("Text", Data_MAYBAY.DataSource, "SOLUONGGHE");
        }
        private void FrmMayBay_Load(object sender, EventArgs e)
        {
            BANGMAYBAY();
            HIENTHIDULIEU();
        }

        private void btnTAOMOI_Click(object sender, EventArgs e)
        {
            txtMAMAYBAY.Text = "";
            txtHANGHANGKHONG.Text = "";
            txtSOGHE.Text = "";
            txtMAMAYBAY.Focus();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            string sql_luu = "INSERT INTO MAYBAY VALUES('" + txtMAMAYBAY.Text + "',N'" + txtHANGHANGKHONG.Text + "','" + txtSOGHE.Text + "')";
            knn.ThucThi(sql_luu);
            BANGMAYBAY();
            HIENTHIDULIEU();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            String sql_sua = "UPDATE MAYBAY SET HANGHANGKHONG=N'" + txtHANGHANGKHONG.Text + "',SOLUONGGHE='" + txtSOGHE.Text + "' WHERE MAMAYBAY='" + txtMAMAYBAY.Text + "'";
            knn.ThucThi(sql_sua);
            BANGMAYBAY();
            HIENTHIDULIEU();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            String sql_xoa = "DELETE FROM MAYBAY WHERE MAMAYBAY='" + txtMAMAYBAY.Text + "'";
            knn.ThucThi(sql_xoa);
            BANGMAYBAY();
            HIENTHIDULIEU();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

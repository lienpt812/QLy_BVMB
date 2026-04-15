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
    public partial class FrmHanhLy : Form
    {
        public FrmHanhLy()
        {
            InitializeComponent();
        }

        private void txtGIAVE_TextChanged(object sender, EventArgs e)
        {

        }
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private void BANGHANHLY()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM HANHLY");
            Data_HANHLY.DataSource = dta;
        }
        private void BANGVE()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM VECHUYENBAY");
            cboMAVE.DataSource = dta;
            cboMAVE.ValueMember = "MAVE";
        }
        private void HIENTHIDULIEU()
        {
            txtMAHANHLY.DataBindings.Clear();
            txtMAHANHLY.DataBindings.Add("Text", Data_HANHLY.DataSource, "MAHANHLY");

            cboMAVE.DataBindings.Clear();
            cboMAVE.DataBindings.Add("Text", Data_HANHLY.DataSource, "MAVE");

            txtKHOILUONG.DataBindings.Clear();
            txtKHOILUONG.DataBindings.Add("Text", Data_HANHLY.DataSource, "KHOILUONGKG");

            txtPHITHEM.DataBindings.Clear();
            txtPHITHEM.DataBindings.Add("Text", Data_HANHLY.DataSource, "PHITHEM");
        }
        private void FrmHanhLy_Load(object sender, EventArgs e)
        {
            BANGHANHLY();
            BANGVE();
            HIENTHIDULIEU();
        }

        private void btnTAOMOI_Click(object sender, EventArgs e)
        {
            txtMAHANHLY.Text = "";
            cboMAVE.Text = "";
            txtPHITHEM.Text = "";
            txtKHOILUONG.Text = "";
            txtMAHANHLY.Focus();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            String sql_luu = "INSERT INTO HANHLY VALUES("
                + txtMAHANHLY.Text + ","
                + "'" + cboMAVE.Text + "',"
                + txtKHOILUONG.Text + ",0)";

            knn.ThucThi(sql_luu);
            BANGHANHLY();
            HIENTHIDULIEU();
            
            
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            String sql_sua = "UPDATE HANHLY SET "
                + "MAVE='" + cboMAVE.Text + "',"
                + "KHOILUONGKG=" + txtKHOILUONG.Text + ","
                + "PHITHEM=0 "
                + "WHERE MAHANHLY=" + txtMAHANHLY.Text;

            knn.ThucThi(sql_sua);
            BANGHANHLY();
            HIENTHIDULIEU();
            
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            String sql_xoa = "DELETE FROM HANHLY WHERE MAHANHLY=" + txtMAHANHLY.Text;
            knn.ThucThi(sql_xoa);
            BANGHANHLY();
            HIENTHIDULIEU();
            
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

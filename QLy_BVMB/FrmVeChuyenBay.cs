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
    public partial class FrmVeChuyenBay : Form
    {
        public FrmVeChuyenBay()
        {
            InitializeComponent();
        }
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private void BANGVECHUYENBAY()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM VECHUYENBAY");
            Data_VECHUYENBAY.DataSource = dta;
        }
        private void BANGCHUYENBAY()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM CHUYENBAY");
            cboMACB.DataSource = dta;
            cboMACB.ValueMember = "MACB";
        }
        private void BANGHANHKHACH()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM HANHKHACH");
            cboMAHK.DataSource = dta;
            cboMAHK.ValueMember = "MAHK";
        }
        private void BANGGHE()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM GHE");
            cboMAGHE.DataSource = dta;
            cboMAGHE.ValueMember = "MAGHE";
        }
        private void HIENTHIDULIEU()
        {
            txtMAVE.DataBindings.Clear();
            txtMAVE.DataBindings.Add("Text", Data_VECHUYENBAY.DataSource, "MAVE");
            cboMACB.DataBindings.Clear();
            cboMACB.DataBindings.Add("Text", Data_VECHUYENBAY.DataSource, "MACB");
            cboMAHK.DataBindings.Clear();
            cboMAHK.DataBindings.Add("Text", Data_VECHUYENBAY.DataSource, "MAHK");
            cboMAGHE.DataBindings.Clear();
            cboMAGHE.DataBindings.Add("Text", Data_VECHUYENBAY.DataSource, "MAGHE");
            dtTHOIGIANDAT.DataBindings.Clear();
            dtTHOIGIANDAT.DataBindings.Add("Text", Data_VECHUYENBAY.DataSource, "THOIGIANDAT");
        }
        private void FrmVeChuyenBay_Load(object sender, EventArgs e)
        {
            BANGCHUYENBAY();
            BANGHANHKHACH();
            BANGGHE();
            BANGVECHUYENBAY();
            HIENTHIDULIEU();
        }

        private void btnTAOMOI_Click(object sender, EventArgs e)
        {
            txtMAVE.Text = "";
            cboMACB.Text = "";
            cboMAHK.Text = "";
            cboMAGHE.Text = "";
            dtTHOIGIANDAT.Value = DateTime.Now;
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            String sql_luu = "INSERT INTO VECHUYENBAY VALUES('"
                + txtMAVE.Text + "','"
                + cboMAHK.Text + "','"
                + cboMACB.Text + "','"
                + cboMAGHE.Text + "','"
                + dtTHOIGIANDAT.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')";

            knn.ThucThi(sql_luu);
            BANGVECHUYENBAY();
            HIENTHIDULIEU();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            String sql_sua = "UPDATE VECHUYENBAY SET MACB='" + cboMACB.Text + "',MAHK='" + cboMAHK.Text + "',MAGHE='" + cboMAGHE.Text + "',THOIGIANDAT='" + dtTHOIGIANDAT.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE MAVE='" + txtMAVE.Text + "'";
            knn.ThucThi(sql_sua);
            BANGVECHUYENBAY();
            HIENTHIDULIEU();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            String sql_xoa = "DELETE FROM VECHUYENBAY WHERE MAVE='" + txtMAVE.Text + "'";
            knn.ThucThi(sql_xoa);
            BANGVECHUYENBAY();
            HIENTHIDULIEU();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

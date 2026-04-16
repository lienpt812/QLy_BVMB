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
    public partial class FrmThanhToan : Form
    {
        KETNOI_CSDL kn = new KETNOI_CSDL();

        private void BangTT()
        {
            string sql = "SELECT * FROM THANHTOAN";
            DataTable dt = kn.LayBang(sql);
            Data_ThanhToan.DataSource = dt;
        }

        private void BangVe()
        {
            string sql = "SELECT * FROM VECHUYENBAY";
            DataTable dt = kn.LayBang(sql);
            cboMAVE.DataSource = dt;
            cboMAVE.DisplayMember = "MaVe";
        }
            
        
        public FrmThanhToan()
        {
            InitializeComponent();
        }

        private void HIENTHIDULIEU()
        {
            txtMATT.DataBindings.Clear();
            txtMATT.DataBindings.Add("Text", Data_ThanhToan.DataSource, "MATHANHTOAN");
            cboMAVE.DataBindings.Clear();
            cboMAVE.DataBindings.Add("Text", Data_ThanhToan.DataSource, "MAVE");
            txtPT.DataBindings.Clear();
            txtPT.DataBindings.Add("Text", Data_ThanhToan.DataSource, "PHUONGTHUC");
            txtTT.DataBindings.Clear();
            txtTT.DataBindings.Add("Text", Data_ThanhToan.DataSource, "TONGTIEN");
        }


        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            BangTT();
            BangVe();
            HIENTHIDULIEU();
        }

        private void btnTAOMOI_Click(object sender, EventArgs e)
        {
            txtMATT.Text = "";
            cboMAVE.Text = "";
            txtPT.Text = "";
            txtTT.Text = "";
            txtMATT.Focus();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO THANHTOAN VALUES('" + txtMATT.Text + "','" + cboMAVE.Text + "','" + txtPT.Text + "','" + txtTT.Text + "')";
            kn.ThucThi(sql);
            BangTT();
            BangVe();
            HIENTHIDULIEU();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE THANHTOAN SET MaVe = '" + cboMAVE.Text + "', PhuongThuc = '" + txtPT.Text + "', TongTien = '" + txtTT.Text + "' WHERE MaThanhToan = '" + txtMATT.Text + "'";
            kn.ThucThi(sql);
            BangTT();
            BangVe();
            HIENTHIDULIEU();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM THANHTOAN WHERE MaThanhToan = '" + txtMATT.Text + "'";
            kn.ThucThi(sql);
            BangTT();
            BangVe();
            HIENTHIDULIEU();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

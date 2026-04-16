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
        KETNOI_CSDL kn = new KETNOI_CSDL();
        private void FrmHanhLy_Load(object sender, EventArgs e)
        {
           LoadHanhLy();
        }
        void LoadHanhLy()
        {
            dgvHanhLy.DataSource = kn.LayBang("SELECT * FROM HANHLY");
            cboMaVe.DataSource = kn.LayBang("select MaVe from VECHUYENBAY");
            cboMaVe.DisplayMember = "MaVe";
            cboMaVe.ValueMember = "MaVe";

            txtPhiThem.ReadOnly = true;
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemHL_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "insert into HANHLY values(" +
                  txtMaHanhLy.Text + "," +
                  "'" + cboMaVe.Text + "'," +
                  numKhoiLuong.Value + "," +
                  "0)";

            kn.ThucThi(sql);
            dgvHanhLy.DataSource = kn.LayBang("select * from HANHLY");
            MessageBox.Show("Thêm hành lý thành công");
        }

        private void btnSuaHL_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "update HANHLY set " +
                  "MaVe = '" + cboMaVe.Text + "', " +
                  "KhoiLuongKg = " + numKhoiLuong.Value + " " +
                  "where MaHanhLy = " + txtMaHanhLy.Text;

            kn.ThucThi(sql);
            dgvHanhLy.DataSource = kn.LayBang("select * from HANHLY");
            MessageBox.Show("Sửa hành lý thành công");
        }

        private void btnXoaHL_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "delete from HANHLY where MaHanhLy = " + txtMaHanhLy.Text;

            kn.ThucThi(sql);
            dgvHanhLy.DataSource = kn.LayBang("select * from HANHLY");
            MessageBox.Show("Xoá hành lý thành công");
        }

        private void numKhoiLuong_ValueChanged(object sender, EventArgs e)
        {
            int kg = (int)numKhoiLuong.Value;

            if (kg >= 25 && kg <= 29)
                txtPhiThem.Text = "100000";
            else if (kg == 30)
                txtPhiThem.Text = "200000";
            else if (kg >= 31 && kg <= 34)
                txtPhiThem.Text = "300000";
            else if (kg == 35)
                txtPhiThem.Text = "400000";
            else
                txtPhiThem.Text = "0";
        }
    }
}

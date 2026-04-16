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
    public partial class FrmHanhKhach : Form
    {
        public FrmHanhKhach()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        KETNOI_CSDL kn = new KETNOI_CSDL();

        private void FrmHanhKhach_Load(object sender, EventArgs e)
        {
            LoadHanhKhach();

        }
        void LoadHanhKhach()
        {
            dgvHanhKhach.DataSource = kn.LayBang("SELECT * FROM HANHKHACH");
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemHK_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "insert into HANHKHACH values(" +
                  "'" + txtMaHK.Text + "'," +
                  "N'" + txtHoTen.Text + "'," +
                  "'" + txtEmail.Text + "'," +
                  "'" + txtSDT.Text + "'," +
                  "'" + txtCCCD.Text + "'," +
                  "'" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "')";

            kn.ThucThi(sql);
            dgvHanhKhach.DataSource = kn.LayBang("select * from HANHKHACH");
            MessageBox.Show("Thêm hành khách thành công");
        }

        private void btnSuaHK_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "exec SP_SUAHANHKHACH " +
                  "'" + txtMaHK.Text + "'," +
                  "N'" + txtHoTen.Text + "'," +
                  "'" + txtEmail.Text + "'," +
                  "'" + txtSDT.Text + "'," +
                  "'" + txtCCCD.Text + "'," +
                  "'" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "'";

            kn.ThucThi(sql);
            dgvHanhKhach.DataSource = kn.LayBang("select * from HANHKHACH");
            MessageBox.Show("Sửa hành khách thành công");
        }

        private void btnXoaHK_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "delete from HANHKHACH where MaHK = '" + txtMaHK.Text + "'";

            kn.ThucThi(sql);
            dgvHanhKhach.DataSource = kn.LayBang("select * from HANHKHACH");
            MessageBox.Show("Xoá hành khách thành công");
        }

      
    }
}

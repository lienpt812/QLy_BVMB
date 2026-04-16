using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLy_BVMB
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        KETNOI_CSDL kn = new KETNOI_CSDL();
        private void btnDANGNHAP_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string a = txtDANGNHAP.Text;
            string b = txtMATKHAU.Text;

            string Sql1 = "SELECT * FROM USERS WHERE TENDN ='" + a + "' AND MATKHAU = '" + b + "'";
            SqlCommand cmd = new SqlCommand(Sql1, kn.cnn);
            SqlDataReader DocDL = cmd.ExecuteReader();

            if (DocDL.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập hoặc mật khẩu sai.");
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

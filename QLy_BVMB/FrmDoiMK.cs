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
    public partial class FrmDoiMK : Form
    {
        public FrmDoiMK()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ");
                txtMatKhauCu.Focus();
                return;
            }

            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới");
                txtMatKhauMoi.Focus();
                return;
            }

            if (txtNhapLai.Text == "")
            {
                MessageBox.Show("Chưa nhập lại mật khẩu mới");
                txtNhapLai.Focus();
                return;
            }

            if (txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới không đúng");
                txtNhapLai.Focus();
                return;
            }

            MessageBox.Show("Đổi mật khẩu thành công");
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

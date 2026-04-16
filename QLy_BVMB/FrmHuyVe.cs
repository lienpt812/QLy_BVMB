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
    public partial class FrmHuyVe : Form
    {
        public FrmHuyVe()
        {
            InitializeComponent();
        }
        KETNOI_CSDL kn = new KETNOI_CSDL();
        void LoadVe()
        {
            dgvHuyVe.DataSource = kn.LayBang("SELECT * FROM VECHUYENBAY");
        }
        private void FrmHuyVe_Load(object sender, EventArgs e)
        {
            LoadVe();
        }

        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "exec SP_HUYVE '" + txtMaVe.Text + "'";

            kn.ThucThi(sql);
            dgvHuyVe.DataSource = kn.LayBang("select * from VECHUYENBAY");
            MessageBox.Show("Huỷ vé thành công");
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

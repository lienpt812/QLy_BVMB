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
    public partial class FrmTimKiem : Form
    {
        KETNOI_CSDL kn = new KETNOI_CSDL();

        private void BangVeCB()
        {
            string sql = "SELECT * FROM CHUYENBAY";
            DataTable dt = kn.LayBang(sql);
            cbbMaCB.DataSource = dt;
            cbbMaCB.DisplayMember = "MaCB";
        }
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            BangVeCB();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if(optChuyen.Checked)
            {
                string sql = "SELECT * FROM VECHUYENBAY WHERE MaCB = '" + cbbMaCB.Text + "'";
                DataTable dt = kn.LayBang(sql);
                dataGridView1.DataSource = dt;
            }
            else if(optNgay.Checked)
            {
                string sql = "SELECT * FROM CHUYENBAY WHERE NgayGioDi = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'";
                DataTable dt = kn.LayBang(sql);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cbbMaCB.SelectedIndex = 0;
                dateTimePicker1.Value = DateTime.Now;
                dataGridView1.DataSource = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

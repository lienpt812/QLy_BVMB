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
    public partial class FrmBaoCaoGheTrong : Form
    {
        QLy_BVMB.KETNOI_CSDL db = new QLy_BVMB.KETNOI_CSDL();
        public FrmBaoCaoGheTrong()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoGheTrong_Load(object sender, EventArgs e)
        {
            LoadComboMayBay();
            LoadBaoCao();
        }
        private void LoadComboMayBay()
        {
            DataTable dt = db.LayBang("SELECT MaMayBay, MaMayBay + ' - ' + HangHangKhong AS TenHienThi FROM MAYBAY ORDER BY MaMayBay");
            cboMayBay.DisplayMember = "TenHienThi";
            cboMayBay.ValueMember = "MaMayBay";
            cboMayBay.DataSource = dt;
            cboMayBay.SelectedIndex = -1;
        }
        private void LoadBaoCao(string maMayBay = null, string loaiGhe = null)
        {
            // Dùng view V_GHE_TRONG + join thêm MAYBAY để hiển thị đầy đủ
            string sql = @"SELECT G.MaMayBay AS [Máy Bay], MB.HangHangKhong AS [Hãng Hàng Không],
                                  G.MaGhe AS [Mã Ghế], G.LoaiGhe AS [Loại Ghế]
                           FROM V_GHE_TRONG G
                           INNER JOIN MAYBAY MB ON G.MaMayBay = MB.MaMayBay
                           WHERE 1=1";
            if (!string.IsNullOrEmpty(maMayBay))
                sql += $" AND G.MaMayBay = '{maMayBay}'";
            if (!string.IsNullOrEmpty(loaiGhe))
                sql += $" AND G.LoaiGhe = N'{loaiGhe}'";
            sql += " ORDER BY G.MaMayBay, G.MaGhe";

            DataTable dt = db.LayBang(sql);
            dgvBaoCao.DataSource = dt;
            lblTongSo.Text = $"Tổng số ghế trống: {dt.Rows.Count}";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string maMayBay = cboMayBay.SelectedValue?.ToString();
            string loaiGhe = cboLoaiGhe.SelectedItem?.ToString();
            if (loaiGhe == "-- Tất cả --") loaiGhe = null;
            LoadBaoCao(maMayBay, loaiGhe);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboMayBay.SelectedIndex = -1;
            cboLoaiGhe.SelectedIndex = 0;
            LoadBaoCao();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // Xuất đơn giản ra clipboard
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (DataGridViewColumn col in dgvBaoCao.Columns)
                sb.Append(col.HeaderText + "\t");
            sb.AppendLine();
            foreach (DataGridViewRow row in dgvBaoCao.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                    sb.Append(cell.Value + "\t");
                sb.AppendLine();
            }
            Clipboard.SetText(sb.ToString());
            MessageBox.Show("✅ Đã copy dữ liệu! Paste vào Excel để xem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

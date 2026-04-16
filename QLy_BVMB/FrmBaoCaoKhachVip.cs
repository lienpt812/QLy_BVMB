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
    public partial class FrmBaoCaoKhachVip : Form
    {
        QLy_BVMB.KETNOI_CSDL db = new QLy_BVMB.KETNOI_CSDL();

        public FrmBaoCaoKhachVip()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoKhachVip_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
        private void LoadBaoCao()
        {
            int nguong = (int)nudNguongVe.Value;

            // Kết hợp V_KHACH_DAT_NHIEU_VE và V_DOANH_THU_HANH_KHACH
            string sql = $@"SELECT 
                                KV.MaHK AS [Mã HK],
                                KV.HoTen AS [Họ Tên],
                                HK.Email AS [Email],
                                HK.SDT AS [Số ĐT],
                                KV.SoLuongVe AS [Số Vé Đã Đặt],
                                ISNULL(DT.TongDoanhThu, 0) AS [Tổng Chi Tiêu (đ)]
                            FROM V_KHACH_DAT_NHIEU_VE KV
                            INNER JOIN HANHKHACH HK ON KV.MaHK = HK.MaHK
                            LEFT JOIN V_DOANH_THU_HANH_KHACH DT ON KV.MaHK = DT.MaHK
                            WHERE KV.SoLuongVe >= {nguong}
                            ORDER BY KV.SoLuongVe DESC, ISNULL(DT.TongDoanhThu,0) DESC";

            DataTable dt = db.LayBang(sql);
            dgvBaoCao.DataSource = dt;

            // Định dạng cột tiền
            if (dgvBaoCao.Columns.Contains("Tổng Chi Tiêu (đ)"))
                dgvBaoCao.Columns["Tổng Chi Tiêu (đ)"].DefaultCellStyle.Format = "N0";

            lblTongKhach.Text = $"Số lượng khách VIP (≥ {nguong} vé): {dt.Rows.Count} người";

            // Tô màu hàng top 1
            foreach (DataGridViewRow row in dgvBaoCao.Rows)
            {
                if (row.Index == 0)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Gold;
                else if (row.Index == 1)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                else if (row.Index == 2)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
            }
        }

        private void btnXem_Click(object sender, EventArgs e) => LoadBaoCao();

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            nudNguongVe.Value = 2;
            LoadBaoCao();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
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

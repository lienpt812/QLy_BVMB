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
    public partial class FrmBCVeBanNgay : Form
    {
        QLy_BVMB.KETNOI_CSDL db = new QLy_BVMB.KETNOI_CSDL();
        public FrmBCVeBanNgay()
        {
            InitializeComponent();
        }

        private void FrmBCVeBanNgay_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
            LoadBaoCao();
        }
        private void LoadBaoCao(DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            // V_VE_BAN_THEO_NGAY: Ngay, SoVeDaBan
            string sql = @"SELECT 
                                VBN.Ngay AS [Ngày Bán],
                                VBN.SoVeDaBan AS [Số Vé Bán],
                                -- Chi tiết thêm: join để lấy info
                                (SELECT COUNT(DISTINCT MaHK) FROM VECHUYENBAY 
                                 WHERE CONVERT(DATE, ThoiGianDat) = VBN.Ngay) AS [Số HK],
                                (SELECT COUNT(DISTINCT MaCB) FROM VECHUYENBAY 
                                 WHERE CONVERT(DATE, ThoiGianDat) = VBN.Ngay) AS [Số CB]
                           FROM V_VE_BAN_THEO_NGAY VBN
                           WHERE 1=1";
            if (tuNgay.HasValue)
                sql += $" AND VBN.Ngay >= '{tuNgay.Value:yyyy-MM-dd}'";
            if (denNgay.HasValue)
                sql += $" AND VBN.Ngay <= '{denNgay.Value:yyyy-MM-dd}'";
            sql += " ORDER BY VBN.Ngay DESC";

            DataTable dt = db.LayBang(sql);
            dgvBaoCao.DataSource = dt;

            // Tổng kết
            int tongVe = 0;
            int soNgay = dt.Rows.Count;
            foreach (DataRow row in dt.Rows)
                tongVe += Convert.ToInt32(row["Số Vé Bán"]);

            double trungBinh = soNgay > 0 ? (double)tongVe / soNgay : 0;
            lblTongKet.Text = $"Tổng vé bán: {tongVe}   |   Số ngày: {soNgay}   |   TB/ngày: {trungBinh:F1}";

            // Tô màu hàng có vé nhiều nhất
            if (dt.Rows.Count == 0) return;
            int maxVe = 0;
            foreach (DataRow row in dt.Rows)
                if (Convert.ToInt32(row["Số Vé Bán"]) > maxVe)
                    maxVe = Convert.ToInt32(row["Số Vé Bán"]);

            foreach (DataGridViewRow row in dgvBaoCao.Rows)
            {
                if (row.Cells["Số Vé Bán"].Value != null &&
                    Convert.ToInt32(row.Cells["Số Vé Bán"].Value) == maxVe)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            { MessageBox.Show("Từ ngày không được lớn hơn đến ngày!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            LoadBaoCao(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today;
            dtpDenNgay.Value = DateTime.Today;
            LoadBaoCao(DateTime.Today, DateTime.Today);
        }

        private void btnThangNay_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
            LoadBaoCao(dtpTuNgay.Value, dtpDenNgay.Value);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
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
    }
}

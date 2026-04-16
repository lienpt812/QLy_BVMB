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
    public partial class FrmBCDoanhThuVe : Form
    {
        QLy_BVMB.KETNOI_CSDL db = new QLy_BVMB.KETNOI_CSDL();
        public FrmBCDoanhThuVe()
        {
            InitializeComponent();
        }

        private void grpKetQua_Enter(object sender, EventArgs e)
        {

        }

        private void FrmBCDoanhThuVe_Load(object sender, EventArgs e)
        {
            LoadComboChuyenBay();
            LoadBaoCao();
        }
        private void LoadComboChuyenBay()
        {
            DataTable dt = db.LayBang("SELECT MaCB FROM CHUYENBAY ORDER BY MaCB");
            cboCBLoc.Items.Add("-- Tất cả --");
            foreach (DataRow row in dt.Rows)
                cboCBLoc.Items.Add(row["MaCB"].ToString());
            cboCBLoc.SelectedIndex = 0;
        }

        private void LoadBaoCao(string maCB = null, string loaiGhe = null,
                                 DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            // V_DOANH_THU_VE: MaCB, LoaiGhe, Gia, NgayGioDi, SoLuong, TongTien
            string sql = @"SELECT 
                                DT.MaCB AS [Chuyến Bay],
                                DT.LoaiGhe AS [Loại Ghế],
                                DT.Gia AS [Đơn Giá (đ)],
                                DT.NgayGioDi AS [Ngày Bay],
                                DT.SoLuong AS [Số Vé Bán],
                                DT.TongTien AS [Doanh Thu (đ)]
                           FROM V_DOANH_THU_VE DT
                           WHERE 1=1";
            if (!string.IsNullOrEmpty(maCB) && maCB != "-- Tất cả --")
                sql += $" AND DT.MaCB = '{maCB}'";
            if (!string.IsNullOrEmpty(loaiGhe) && loaiGhe != "-- Tất cả --")
                sql += $" AND DT.LoaiGhe = N'{loaiGhe}'";
            if (tuNgay.HasValue)
                sql += $" AND DT.NgayGioDi >= '{tuNgay.Value:yyyy-MM-dd}'";
            if (denNgay.HasValue)
                sql += $" AND DT.NgayGioDi <= '{denNgay.Value:yyyy-MM-dd} 23:59:59'";
            sql += " ORDER BY DT.NgayGioDi, DT.MaCB";

            DataTable dt = db.LayBang(sql);
            dgvBaoCao.DataSource = dt;

            // Định dạng cột số tiền
            foreach (string colName in new[] { "Đơn Giá (đ)", "Doanh Thu (đ)" })
                if (dgvBaoCao.Columns.Contains(colName))
                    dgvBaoCao.Columns[colName].DefaultCellStyle.Format = "N0";

            // Tính tổng doanh thu
            decimal tongDoanhThu = 0;
            int tongVe = 0;
            foreach (DataRow row in dt.Rows)
            {
                tongDoanhThu += row["Doanh Thu (đ)"] != DBNull.Value ? Convert.ToDecimal(row["Doanh Thu (đ)"]) : 0;
                tongVe += row["Số Vé Bán"] != DBNull.Value ? Convert.ToInt32(row["Số Vé Bán"]) : 0;
            }
            lblTongDoanhThu.Text = $"Tổng doanh thu: {tongDoanhThu:N0} đ   |   Tổng số vé: {tongVe}";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string maCB = cboCBLoc.SelectedItem?.ToString();
            string loaiGhe = cboLoaiGhe.SelectedItem?.ToString();
            DateTime? tuNgay = chkLocNgay.Checked ? (DateTime?)dtpTuNgay.Value.Date : null;
            DateTime? denNgay = chkLocNgay.Checked ? (DateTime?)dtpDenNgay.Value.Date : null;
            LoadBaoCao(maCB, loaiGhe, tuNgay, denNgay);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboCBLoc.SelectedIndex = 0;
            cboLoaiGhe.SelectedIndex = 0;
            chkLocNgay.Checked = false;
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
            LoadBaoCao();
        }

        private void chkLocNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpTuNgay.Enabled = chkLocNgay.Checked;
            dtpDenNgay.Enabled = chkLocNgay.Checked;
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

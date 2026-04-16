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
    public partial class FrmBanVe : Form
    {
        QLy_BVMB.KETNOI_CSDL db = new QLy_BVMB.KETNOI_CSDL();
        public FrmBanVe()
        {
            InitializeComponent();
        }

        private void FrmBanVe_Load(object sender, EventArgs e)
        {
            LoadComboHanhKhach();
            LoadComboChuyenBay();
            LoadDanhSachVe();
            txtMaVe.Text = SinhMaVe();
        }
        private string SinhMaVe()
        {
            DataTable dt = db.LayBang("SELECT MAX(MaVe) AS MaxMa FROM VECHUYENBAY");
            if (dt.Rows.Count > 0 && dt.Rows[0]["MaxMa"] != DBNull.Value)
            {
                string maxMa = dt.Rows[0]["MaxMa"].ToString(); // VE015
                int so = int.Parse(maxMa.Substring(2)) + 1;
                return "VE" + so.ToString("D3");
            }
            return "VE001";
        }

        // ===================== LOAD COMBOBOX HÀNH KHÁCH =====================
        private void LoadComboHanhKhach()
        {
            DataTable dt = db.LayBang("SELECT MaHK, HoTen FROM HANHKHACH ORDER BY HoTen");
            cboHanhKhach.DisplayMember = "HoTen";
            cboHanhKhach.ValueMember = "MaHK";
            cboHanhKhach.DataSource = dt;
            cboHanhKhach.SelectedIndex = -1;
        }

        // ===================== LOAD COMBOBOX CHUYẾN BAY =====================
        private void LoadComboChuyenBay()
        {
            // Chỉ load chuyến bay đang mở bán
            string sql = @"SELECT MaCB, MaCB + ' | ' + SanBayDi + ' → ' + SanBayDen + ' | ' + CONVERT(VARCHAR,NgayGioDi,103) AS TenHienThi
                           FROM CHUYENBAY WHERE TrangThai = N'Đang mở bán' ORDER BY NgayGioDi";
            DataTable dt = db.LayBang(sql);
            cboChuyenBay.DisplayMember = "TenHienThi";
            cboChuyenBay.ValueMember = "MaCB";
            cboChuyenBay.DataSource = dt;
            cboChuyenBay.SelectedIndex = -1;
        }

        private void cboChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChuyenBay.SelectedValue == null) return;
            string maCB = cboChuyenBay.SelectedValue.ToString();

            // Load ghế chưa được đặt trên chuyến bay này
            string sql = $@"SELECT G.MaGhe, G.MaGhe + ' (' + G.LoaiGhe + ')' AS TenHienThi
                            FROM GHE G
                            INNER JOIN CHUYENBAY CB ON G.MaMayBay = CB.MaMayBay
                            WHERE CB.MaCB = '{maCB}'
                            AND G.MaGhe NOT IN (
                                SELECT MaGhe FROM VECHUYENBAY WHERE MaCB = '{maCB}'
                            )
                            ORDER BY G.MaGhe";
            DataTable dt = db.LayBang(sql);
            cboGhe.DisplayMember = "TenHienThi";
            cboGhe.ValueMember = "MaGhe";
            cboGhe.DataSource = dt;
            cboGhe.SelectedIndex = -1;

            // Hiển thị giá vé
            LoadGiaVe(maCB);
        }
        private void LoadGiaVe(string maCB)
        {
            string sql = $"SELECT LoaiGhe, Gia FROM GIAVE WHERE MaCB = '{maCB}'";
            DataTable dt = db.LayBang(sql);
            string giaInfo = "";
            foreach (DataRow row in dt.Rows)
                giaInfo += row["LoaiGhe"] + ": " + string.Format("{0:N0} đ", row["Gia"]) + "   ";
            lblGiaVe.Text = "Giá: " + giaInfo;
        }
        private void LoadDanhSachVe()
        {
            string sql = @"SELECT V.MaVe, H.HoTen AS [Hành Khách], V.MaCB AS [Chuyến Bay],
                                  V.MaGhe AS [Ghế], CONVERT(VARCHAR,V.ThoiGianDat,103) AS [Ngày Đặt]
                           FROM VECHUYENBAY V
                           INNER JOIN HANHKHACH H ON V.MaHK = H.MaHK
                           ORDER BY V.ThoiGianDat DESC";
            dgvDanhSachVe.DataSource = db.LayBang(sql);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Validate
            if (cboHanhKhach.SelectedValue == null)
            { MessageBox.Show("Vui lòng chọn hành khách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (cboChuyenBay.SelectedValue == null)
            { MessageBox.Show("Vui lòng chọn chuyến bay!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (cboGhe.SelectedValue == null)
            { MessageBox.Show("Vui lòng chọn ghế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string maVe = txtMaVe.Text.Trim();
            string maHK = cboHanhKhach.SelectedValue.ToString();
            string maCB = cboChuyenBay.SelectedValue.ToString();
            string maGhe = cboGhe.SelectedValue.ToString();
            string thoiGianDat = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Kiểm tra MaVe đã tồn tại chưa
            DataTable check = db.LayBang($"SELECT MaVe FROM VECHUYENBAY WHERE MaVe = '{maVe}'");
            if (check.Rows.Count > 0)
            { MessageBox.Show("Mã vé đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                // Thêm vé (trigger TRG_CHECK_GHE và TRG_CHECK_VECHUYENBAY sẽ kiểm tra tự động)
                string sqlVe = $@"INSERT INTO VECHUYENBAY (MaVe, MaHK, MaCB, MaGhe, ThoiGianDat)
                                  VALUES ('{maVe}', '{maHK}', '{maCB}', '{maGhe}', '{thoiGianDat}')";
                db.ThucThi(sqlVe);

                // Lấy phương thức thanh toán
                string phuongThuc = cboPhuongThuc.SelectedItem?.ToString() ?? "VietQR";

                // Lấy MaThanhToan mới
                DataTable dtMax = db.LayBang("SELECT ISNULL(MAX(MaThanhToan),0)+1 AS NewID FROM THANHTOAN");
                int maThanhToanMoi = int.Parse(dtMax.Rows[0]["NewID"].ToString());

                // Thêm thanh toán (trigger TRG_CHECK_TONGTIEN sẽ tự tính TongTien)
                string sqlTT = $@"INSERT INTO THANHTOAN (MaThanhToan, MaVe, PhuongThuc, TongTien)
                                  VALUES ({maThanhToanMoi}, '{maVe}', N'{phuongThuc}', 0)";
                db.ThucThi(sqlTT);

                MessageBox.Show($"✅ Bán vé thành công!\nMã vé: {maVe}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachVe();
                XoaForm();
                txtMaVe.Text = SinhMaVe();
                LoadComboChuyenBay(); // Refresh để cập nhật ghế
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachVe.SelectedRows.Count == 0)
            { MessageBox.Show("Vui lòng chọn vé cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string maVe = dgvDanhSachVe.SelectedRows[0].Cells["MaVe"].Value.ToString();
            if (MessageBox.Show($"Xác nhận hủy vé {maVe}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    db.ThucThi($"DELETE FROM THANHTOAN WHERE MaVe = '{maVe}'");
                    db.ThucThi($"DELETE FROM HANHLY WHERE MaVe = '{maVe}'");
                    db.ThucThi($"DELETE FROM VECHUYENBAY WHERE MaVe = '{maVe}'");
                    MessageBox.Show("✅ Hủy vé thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachVe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            { LoadDanhSachVe(); return; }

            string sql = $@"SELECT V.MaVe, H.HoTen AS [Hành Khách], V.MaCB AS [Chuyến Bay],
                                   V.MaGhe AS [Ghế], CONVERT(VARCHAR,V.ThoiGianDat,103) AS [Ngày Đặt]
                            FROM VECHUYENBAY V
                            INNER JOIN HANHKHACH H ON V.MaHK = H.MaHK
                            WHERE V.MaVe LIKE '%{tuKhoa}%' OR H.HoTen LIKE N'%{tuKhoa}%' OR V.MaCB LIKE '%{tuKhoa}%'
                            ORDER BY V.ThoiGianDat DESC";
            dgvDanhSachVe.DataSource = db.LayBang(sql);
        }

        // ===================== CLICK TRÊN DANH SÁCH =====================
        private void dgvDanhSachVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMaVe.Text = dgvDanhSachVe.Rows[e.RowIndex].Cells["MaVe"].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaForm();
            txtMaVe.Text = SinhMaVe();
            LoadDanhSachVe();
            txtTimKiem.Clear();
        }
        private void XoaForm()
        {
            cboHanhKhach.SelectedIndex = -1;
            cboChuyenBay.SelectedIndex = -1;
            cboGhe.DataSource = null;
            cboPhuongThuc.SelectedIndex = 0;
            lblGiaVe.Text = "Giá: ---";
        }

        private void grpDanhSach_Enter(object sender, EventArgs e)
        {

        }
    }
}

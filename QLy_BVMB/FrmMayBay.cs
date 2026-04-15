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
    public partial class FrmMayBay : Form
    {
        ThuHang.KETNOI_CSDL db = new ThuHang.KETNOI_CSDL();
        public FrmMayBay()
        {
            InitializeComponent();
        }


        private void gbChucNang_Enter(object sender, EventArgs e)
        {

        }

        private void dgvSanBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanBay.Rows[e.RowIndex];
                txtMaSanBay.Text = row.Cells["MaSanBay"].Value?.ToString();
                txtTenSanBay.Text = row.Cells["TenSanBay"].Value?.ToString();
                txtThanhPho.Text = row.Cells["ThanhPho"].Value?.ToString();
                txtQuocGia.Text = row.Cells["QuocGia"].Value?.ToString();

                // Khoá mã khi đang sửa (không cho đổi khóa chính)
                txtMaSanBay.ReadOnly = true;
            }
        }

        private void FrmMayBay_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
        private void LoadDanhSach()
        {
            string sql = "SELECT MaSanBay, TenSanBay, ThanhPho, QuocGia FROM SANBAY ORDER BY MaSanBay";
            dgvSanBay.DataSource = db.LayBang(sql);

            // Đặt tiêu đề cột cho đẹp
            dgvSanBay.Columns["MaSanBay"].HeaderText = "Mã Sân Bay";
            dgvSanBay.Columns["TenSanBay"].HeaderText = "Tên Sân Bay";
            dgvSanBay.Columns["ThanhPho"].HeaderText = "Thành Phố";
            dgvSanBay.Columns["QuocGia"].HeaderText = "Quốc Gia";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string maSB = txtMaSanBay.Text.Trim().ToUpper();
            string tenSB = txtTenSanBay.Text.Trim();
            string tp = txtThanhPho.Text.Trim();
            string qg = txtQuocGia.Text.Trim();

            // Kiểm tra trùng mã
            DataTable dt = db.LayBang($"SELECT * FROM SANBAY WHERE MaSanBay = '{maSB}'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã sân bay đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"INSERT INTO SANBAY VALUES('{maSB}', N'{tenSB}', N'{tp}', N'{qg}')";
            try
            {
                db.ThucThi(sql);
                MessageBox.Show("Thêm sân bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach();
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // SỬA thông tin sân bay
        // ============================================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSanBay.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn sân bay cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            string maSB = txtMaSanBay.Text.Trim().ToUpper();
            string tenSB = txtTenSanBay.Text.Trim();
            string tp = txtThanhPho.Text.Trim();
            string qg = txtQuocGia.Text.Trim();

            string sql = $"UPDATE SANBAY SET TenSanBay = N'{tenSB}', ThanhPho = N'{tp}', QuocGia = N'{qg}' WHERE MaSanBay = '{maSB}'";
            try
            {
                db.ThucThi(sql);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach();
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSanBay.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn sân bay cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSB = txtMaSanBay.Text.Trim().ToUpper();

            // Kiểm tra sân bay có đang dùng trong chuyến bay không
            DataTable dt = db.LayBang($"SELECT * FROM CHUYENBAY WHERE SanBayDi='{maSB}' OR SanBayDen='{maSB}'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Không thể xoá! Sân bay đang được sử dụng trong chuyến bay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xoá sân bay '{maSB}'?", "Xác nhận xoá",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    db.ThucThi($"DELETE FROM SANBAY WHERE MaSanBay = '{maSB}'");
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSach();
                    XoaTrang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            string sql;
            if (keyword == "")
                sql = "SELECT MaSanBay, TenSanBay, ThanhPho, QuocGia FROM SANBAY ORDER BY MaSanBay";
            else
                sql = $"SELECT MaSanBay, TenSanBay, ThanhPho, QuocGia FROM SANBAY " +
                      $"WHERE MaSanBay LIKE '%{keyword}%' OR TenSanBay LIKE N'%{keyword}%' OR ThanhPho LIKE N'%{keyword}%' " +
                      $"ORDER BY MaSanBay";

            dgvSanBay.DataSource = db.LayBang(sql);

            if (dgvSanBay.Rows.Count == 0)
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDanhSach();
            XoaTrang();
        }
        private bool ValidateInput()
        {
            if (txtMaSanBay.Text.Trim() == "")
            { MessageBox.Show("Vui lòng nhập Mã Sân Bay!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (txtTenSanBay.Text.Trim() == "")
            { MessageBox.Show("Vui lòng nhập Tên Sân Bay!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (txtThanhPho.Text.Trim() == "")
            { MessageBox.Show("Vui lòng nhập Thành Phố!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (txtQuocGia.Text.Trim() == "")
            { MessageBox.Show("Vui lòng nhập Quốc Gia!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        // ============================================================
        // Xoá trắng form nhập
        // ============================================================
        private void XoaTrang()
        {
            txtMaSanBay.Clear();
            txtTenSanBay.Clear();
            txtThanhPho.Clear();
            txtQuocGia.Clear();
            txtMaSanBay.ReadOnly = false;
        }
    }
}

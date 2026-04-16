namespace QLy_BVMB
{
    partial class FrmBanVe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.cboPhuongThuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGhe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboChuyenBay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboHanhKhach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachVe = new System.Windows.Forms.DataGridView();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpNhapLieu.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachVe)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNhapLieu
            // 
            this.grpNhapLieu.Controls.Add(this.lblGiaVe);
            this.grpNhapLieu.Controls.Add(this.cboPhuongThuc);
            this.grpNhapLieu.Controls.Add(this.label5);
            this.grpNhapLieu.Controls.Add(this.cboGhe);
            this.grpNhapLieu.Controls.Add(this.label4);
            this.grpNhapLieu.Controls.Add(this.cboChuyenBay);
            this.grpNhapLieu.Controls.Add(this.label3);
            this.grpNhapLieu.Controls.Add(this.cboHanhKhach);
            this.grpNhapLieu.Controls.Add(this.label2);
            this.grpNhapLieu.Controls.Add(this.txtMaVe);
            this.grpNhapLieu.Controls.Add(this.label1);
            this.grpNhapLieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpNhapLieu.Location = new System.Drawing.Point(12, 12);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new System.Drawing.Size(480, 230);
            this.grpNhapLieu.TabIndex = 0;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "📋 Thông tin vé";
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.AutoSize = true;
            this.lblGiaVe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblGiaVe.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblGiaVe.Location = new System.Drawing.Point(150, 123);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(56, 20);
            this.lblGiaVe.TabIndex = 0;
            this.lblGiaVe.Text = "Giá: ---";
            // 
            // cboPhuongThuc
            // 
            this.cboPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPhuongThuc.Items.AddRange(new object[] {
            "VietQR",
            "ATM/Mobile Banking",
            "Trả góp thẻ tín dụng",
            "Thẻ thanh toán",
            "Tại cửa hàng",
            "Ví điện tử"});
            this.cboPhuongThuc.Location = new System.Drawing.Point(150, 172);
            this.cboPhuongThuc.Name = "cboPhuongThuc";
            this.cboPhuongThuc.Size = new System.Drawing.Size(300, 28);
            this.cboPhuongThuc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(20, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thanh Toán:";
            // 
            // cboGhe
            // 
            this.cboGhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGhe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboGhe.Location = new System.Drawing.Point(150, 137);
            this.cboGhe.Name = "cboGhe";
            this.cboGhe.Size = new System.Drawing.Size(300, 28);
            this.cboGhe.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ghế:";
            // 
            // cboChuyenBay
            // 
            this.cboChuyenBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenBay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboChuyenBay.Location = new System.Drawing.Point(150, 97);
            this.cboChuyenBay.Name = "cboChuyenBay";
            this.cboChuyenBay.Size = new System.Drawing.Size(300, 28);
            this.cboChuyenBay.TabIndex = 5;
            this.cboChuyenBay.SelectedIndexChanged += new System.EventHandler(this.cboChuyenBay_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chuyến Bay:";
            // 
            // cboHanhKhach
            // 
            this.cboHanhKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHanhKhach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHanhKhach.Location = new System.Drawing.Point(150, 62);
            this.cboHanhKhach.Name = "cboHanhKhach";
            this.cboHanhKhach.Size = new System.Drawing.Size(300, 28);
            this.cboHanhKhach.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hành Khách:";
            // 
            // txtMaVe
            // 
            this.txtMaVe.BackColor = System.Drawing.Color.LightYellow;
            this.txtMaVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaVe.Location = new System.Drawing.Point(150, 27);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.ReadOnly = true;
            this.txtMaVe.Size = new System.Drawing.Size(300, 27);
            this.txtMaVe.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Vé:";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvDanhSachVe);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(12, 250);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(950, 300);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "📋 Danh sách vé đã bán";
            // 
            // dgvDanhSachVe
            // 
            this.dgvDanhSachVe.AllowUserToAddRows = false;
            this.dgvDanhSachVe.AllowUserToDeleteRows = false;
            this.dgvDanhSachVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachVe.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDanhSachVe.ColumnHeadersHeight = 29;
            this.dgvDanhSachVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDanhSachVe.Location = new System.Drawing.Point(10, 25);
            this.dgvDanhSachVe.MultiSelect = false;
            this.dgvDanhSachVe.Name = "dgvDanhSachVe";
            this.dgvDanhSachVe.ReadOnly = true;
            this.dgvDanhSachVe.RowHeadersWidth = 51;
            this.dgvDanhSachVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachVe.Size = new System.Drawing.Size(930, 265);
            this.dgvDanhSachVe.TabIndex = 0;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Controls.Add(this.btnTimKiem);
            this.grpChucNang.Controls.Add(this.txtTimKiem);
            this.grpChucNang.Controls.Add(this.label6);
            this.grpChucNang.Controls.Add(this.btnHuy);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpChucNang.Location = new System.Drawing.Point(510, 12);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(452, 230);
            this.grpChucNang.TabIndex = 2;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "⚙ Chức năng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(15, 145);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(420, 35);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "🔄 LÀM MỚI FORM";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(340, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 30);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "🔍 Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Location = new System.Drawing.Point(100, 32);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(230, 27);
            this.txtTimKiem.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(15, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tìm kiếm:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Crimson;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(235, 80);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(200, 45);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "❌ HỦY VÉ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(15, 80);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(200, 45);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "✈ BÁN VÉ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(980, 570);
            this.Controls.Add(this.grpNhapLieu);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpChucNang);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "✈ BÁN VÉ MÁY BAY";
            this.Load += new System.EventHandler(this.FrmBanVe_Load);
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachVe)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6;
        private System.Windows.Forms.TextBox txtMaVe, txtTimKiem;
        private System.Windows.Forms.ComboBox cboHanhKhach, cboChuyenBay, cboGhe, cboPhuongThuc;
        private System.Windows.Forms.Label lblGiaVe;
        private System.Windows.Forms.DataGridView dgvDanhSachVe;
        private System.Windows.Forms.Button btnThem, btnHuy, btnTimKiem, btnLamMoi;
    }
}
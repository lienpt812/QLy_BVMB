namespace QLy_BVMB
{
    partial class FrmBCDoanhThuVe
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.chkLocNgay = new System.Windows.Forms.CheckBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiGhe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCBLoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpLoc.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLoc
            // 
            this.grpLoc.Controls.Add(this.btnThoat);
            this.grpLoc.Controls.Add(this.chkLocNgay);
            this.grpLoc.Controls.Add(this.dtpDenNgay);
            this.grpLoc.Controls.Add(this.label3);
            this.grpLoc.Controls.Add(this.dtpTuNgay);
            this.grpLoc.Controls.Add(this.label4);
            this.grpLoc.Controls.Add(this.cboLoaiGhe);
            this.grpLoc.Controls.Add(this.label2);
            this.grpLoc.Controls.Add(this.cboCBLoc);
            this.grpLoc.Controls.Add(this.label1);
            this.grpLoc.Controls.Add(this.btnXem);
            this.grpLoc.Controls.Add(this.btnLamMoi);
            this.grpLoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpLoc.Location = new System.Drawing.Point(16, 16);
            this.grpLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLoc.Size = new System.Drawing.Size(1234, 146);
            this.grpLoc.TabIndex = 0;
            this.grpLoc.TabStop = false;
            this.grpLoc.Text = "🔍 Bộ lọc báo cáo";
            // 
            // chkLocNgay
            // 
            this.chkLocNgay.AutoSize = true;
            this.chkLocNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkLocNgay.Location = new System.Drawing.Point(19, 86);
            this.chkLocNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkLocNgay.Name = "chkLocNgay";
            this.chkLocNgay.Size = new System.Drawing.Size(188, 29);
            this.chkLocNgay.TabIndex = 0;
            this.chkLocNgay.Text = "Lọc theo ngày bay:";
            this.chkLocNgay.CheckedChanged += new System.EventHandler(this.chkLocNgay_CheckedChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Enabled = false;
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(438, 84);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(154, 31);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(405, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Enabled = false;
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(237, 84);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(154, 31);
            this.dtpTuNgay.TabIndex = 3;
            this.dtpTuNgay.Value = new System.DateTime(2026, 3, 16, 13, 11, 5, 155);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(206, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Từ:";
            // 
            // cboLoaiGhe
            // 
            this.cboLoaiGhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiGhe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiGhe.Items.AddRange(new object[] {
            "-- Tất cả --",
            "Phổ thông",
            "Thương gia"});
            this.cboLoaiGhe.Location = new System.Drawing.Point(438, 36);
            this.cboLoaiGhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoaiGhe.Name = "cboLoaiGhe";
            this.cboLoaiGhe.Size = new System.Drawing.Size(204, 33);
            this.cboLoaiGhe.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(334, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại Ghế:";
            // 
            // cboCBLoc
            // 
            this.cboCBLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCBLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCBLoc.Location = new System.Drawing.Point(135, 36);
            this.cboCBLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCBLoc.Name = "cboCBLoc";
            this.cboCBLoc.Size = new System.Drawing.Size(178, 33);
            this.cboCBLoc.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chuyến Bay:";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(744, 35);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(154, 80);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "📊 Xem báo cáo";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(917, 35);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(142, 80);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.lblTongDoanhThu);
            this.grpKetQua.Controls.Add(this.dgvBaoCao);
            this.grpKetQua.Controls.Add(this.btnXuatExcel);
            this.grpKetQua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpKetQua.Location = new System.Drawing.Point(16, 174);
            this.grpKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKetQua.Size = new System.Drawing.Size(1234, 560);
            this.grpKetQua.TabIndex = 1;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "💰 Doanh thu bán vé theo chuyến bay";
            this.grpKetQua.Enter += new System.EventHandler(this.grpKetQua_Enter);
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(12, 34);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(374, 28);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "Tổng doanh thu: 0 đ   |   Tổng số vé: 0";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCao.ColumnHeadersHeight = 29;
            this.dgvBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvBaoCao.Location = new System.Drawing.Point(12, 66);
            this.dgvBaoCao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(1208, 426);
            this.dgvBaoCao.TabIndex = 1;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(1054, 506);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(168, 42);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "📤 Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1086, 40);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 74);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmBCDoanhThuVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1266, 754);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.grpKetQua);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBCDoanhThuVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "💰 BÁO CÁO DOANH THU VÉ";
            this.Load += new System.EventHandler(this.FrmBCDoanhThuVe_Load);
            this.grpLoc.ResumeLayout(false);
            this.grpLoc.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpLoc, grpKetQua;
        private System.Windows.Forms.ComboBox cboCBLoc, cboLoaiGhe;
        private System.Windows.Forms.Label label1, label2, label3, label4, lblTongDoanhThu;
        private System.Windows.Forms.CheckBox chkLocNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay, dtpDenNgay;
        private System.Windows.Forms.Button btnXem, btnLamMoi, btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Button btnThoat;
    }
}
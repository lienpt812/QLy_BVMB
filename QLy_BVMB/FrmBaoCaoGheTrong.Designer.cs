namespace QLy_BVMB
{
    partial class FrmBaoCaoGheTrong
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.cboLoaiGhe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMayBay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.lblTongSo = new System.Windows.Forms.Label();
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
            this.grpLoc.Controls.Add(this.btnLamMoi);
            this.grpLoc.Controls.Add(this.btnXem);
            this.grpLoc.Controls.Add(this.cboLoaiGhe);
            this.grpLoc.Controls.Add(this.label2);
            this.grpLoc.Controls.Add(this.cboMayBay);
            this.grpLoc.Controls.Add(this.label1);
            this.grpLoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpLoc.Location = new System.Drawing.Point(16, 16);
            this.grpLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLoc.Size = new System.Drawing.Size(1234, 120);
            this.grpLoc.TabIndex = 0;
            this.grpLoc.TabStop = false;
            this.grpLoc.Text = "🔍 Bộ lọc";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(968, 37);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(128, 42);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(836, 38);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(126, 42);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "📊 Xem báo cáo";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cboLoaiGhe
            // 
            this.cboLoaiGhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiGhe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiGhe.Items.AddRange(new object[] {
            "-- Tất cả --",
            "Phổ thông",
            "Thương gia"});
            this.cboLoaiGhe.Location = new System.Drawing.Point(578, 42);
            this.cboLoaiGhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoaiGhe.Name = "cboLoaiGhe";
            this.cboLoaiGhe.Size = new System.Drawing.Size(230, 33);
            this.cboLoaiGhe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(476, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Ghế:";
            // 
            // cboMayBay
            // 
            this.cboMayBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMayBay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMayBay.Location = new System.Drawing.Point(128, 42);
            this.cboMayBay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMayBay.Name = "cboMayBay";
            this.cboMayBay.Size = new System.Drawing.Size(320, 33);
            this.cboMayBay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Máy Bay:";
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.lblTongSo);
            this.grpKetQua.Controls.Add(this.dgvBaoCao);
            this.grpKetQua.Controls.Add(this.btnXuatExcel);
            this.grpKetQua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpKetQua.Location = new System.Drawing.Point(16, 154);
            this.grpKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKetQua.Size = new System.Drawing.Size(1234, 560);
            this.grpKetQua.TabIndex = 1;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "📋 Danh sách ghế trống";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongSo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTongSo.Location = new System.Drawing.Point(12, 34);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(189, 25);
            this.lblTongSo.TabIndex = 0;
            this.lblTongSo.Text = "Tổng số ghế trống: 0";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.btnXuatExcel.Location = new System.Drawing.Point(1054, 500);
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
            this.btnThoat.Location = new System.Drawing.Point(1102, 37);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmBaoCaoGheTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1266, 734);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.grpKetQua);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBaoCaoGheTrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📊 BÁO CÁO GHẾ TRỐNG";
            this.Load += new System.EventHandler(this.FrmBaoCaoGheTrong_Load);
            this.grpLoc.ResumeLayout(false);
            this.grpLoc.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpLoc, grpKetQua;
        private System.Windows.Forms.ComboBox cboMayBay, cboLoaiGhe;
        private System.Windows.Forms.Label label1, label2, lblTongSo;
        private System.Windows.Forms.Button btnXem, btnLamMoi, btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Button btnThoat;
    }
}
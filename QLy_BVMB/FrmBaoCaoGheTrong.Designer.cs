namespace QLy_BVMB
{
    partial class FrmBaoCaoGheTrong
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.grpLoc.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLoc
            // 
            this.grpLoc.Controls.Add(this.btnLamMoi);
            this.grpLoc.Controls.Add(this.btnXem);
            this.grpLoc.Controls.Add(this.cboLoaiGhe);
            this.grpLoc.Controls.Add(this.label2);
            this.grpLoc.Controls.Add(this.cboMayBay);
            this.grpLoc.Controls.Add(this.label1);
            this.grpLoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpLoc.Location = new System.Drawing.Point(14, 13);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Size = new System.Drawing.Size(1097, 96);
            this.grpLoc.TabIndex = 0;
            this.grpLoc.TabStop = false;
            this.grpLoc.Text = "🔍 Bộ lọc";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(897, 30);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(114, 34);
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
            this.btnXem.Location = new System.Drawing.Point(743, 30);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(137, 34);
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
            this.cboLoaiGhe.Location = new System.Drawing.Point(514, 34);
            this.cboLoaiGhe.Name = "cboLoaiGhe";
            this.cboLoaiGhe.Size = new System.Drawing.Size(205, 28);
            this.cboLoaiGhe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(423, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Ghế:";
            // 
            // cboMayBay
            // 
            this.cboMayBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMayBay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMayBay.Location = new System.Drawing.Point(114, 34);
            this.cboMayBay.Name = "cboMayBay";
            this.cboMayBay.Size = new System.Drawing.Size(285, 28);
            this.cboMayBay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Máy Bay:";
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.lblTongSo);
            this.grpKetQua.Controls.Add(this.dgvBaoCao);
            this.grpKetQua.Controls.Add(this.btnXuatExcel);
            this.grpKetQua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpKetQua.Location = new System.Drawing.Point(14, 123);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(1097, 448);
            this.grpKetQua.TabIndex = 1;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "📋 Danh sách ghế trống";
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongSo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTongSo.Location = new System.Drawing.Point(11, 27);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(155, 20);
            this.lblTongSo.TabIndex = 0;
            this.lblTongSo.Text = "Tổng số ghế trống: 0";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBaoCao.ColumnHeadersHeight = 29;
            this.dgvBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvBaoCao.Location = new System.Drawing.Point(11, 53);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(1074, 341);
            this.dgvBaoCao.TabIndex = 1;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(937, 400);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(149, 34);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "📤 Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // FrmBaoCaoGheTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1125, 587);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.grpKetQua);
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
    }
}
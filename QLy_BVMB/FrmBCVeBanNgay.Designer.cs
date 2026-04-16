namespace QLy_BVMB
{
    partial class FrmBCVeBanNgay
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.btnThangNay = new System.Windows.Forms.Button();
            this.btnHomNay = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.lblTongKet = new System.Windows.Forms.Label();
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
            this.grpLoc.Controls.Add(this.btnThangNay);
            this.grpLoc.Controls.Add(this.btnHomNay);
            this.grpLoc.Controls.Add(this.btnLamMoi);
            this.grpLoc.Controls.Add(this.btnXem);
            this.grpLoc.Controls.Add(this.dtpDenNgay);
            this.grpLoc.Controls.Add(this.label2);
            this.grpLoc.Controls.Add(this.dtpTuNgay);
            this.grpLoc.Controls.Add(this.label1);
            this.grpLoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpLoc.Location = new System.Drawing.Point(16, 16);
            this.grpLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLoc.Size = new System.Drawing.Size(1234, 120);
            this.grpLoc.TabIndex = 0;
            this.grpLoc.TabStop = false;
            this.grpLoc.Text = "📅 Chọn khoảng thời gian";
            // 
            // btnThangNay
            // 
            this.btnThangNay.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThangNay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThangNay.ForeColor = System.Drawing.Color.White;
            this.btnThangNay.Location = new System.Drawing.Point(839, 40);
            this.btnThangNay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThangNay.Name = "btnThangNay";
            this.btnThangNay.Size = new System.Drawing.Size(142, 46);
            this.btnThangNay.TabIndex = 0;
            this.btnThangNay.Text = "📅 Tháng này";
            this.btnThangNay.UseVisualStyleBackColor = false;
            this.btnThangNay.Click += new System.EventHandler(this.btnThangNay_Click);
            // 
            // btnHomNay
            // 
            this.btnHomNay.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHomNay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHomNay.ForeColor = System.Drawing.Color.White;
            this.btnHomNay.Location = new System.Drawing.Point(704, 40);
            this.btnHomNay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(129, 46);
            this.btnHomNay.TabIndex = 1;
            this.btnHomNay.Text = "📅 Hôm nay";
            this.btnHomNay.UseVisualStyleBackColor = false;
            this.btnHomNay.Click += new System.EventHandler(this.btnHomNay_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(987, 40);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(128, 46);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(592, 40);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(106, 46);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "📊 Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(405, 46);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(166, 31);
            this.dtpDenNgay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(303, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(116, 46);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(166, 31);
            this.dtpTuNgay.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ ngày:";
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.lblTongKet);
            this.grpKetQua.Controls.Add(this.dgvBaoCao);
            this.grpKetQua.Controls.Add(this.btnXuatExcel);
            this.grpKetQua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpKetQua.Location = new System.Drawing.Point(16, 154);
            this.grpKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKetQua.Size = new System.Drawing.Size(1234, 574);
            this.grpKetQua.TabIndex = 1;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "📈 Thống kê vé bán theo ngày (🟢 = Ngày bán nhiều nhất)";
            // 
            // lblTongKet
            // 
            this.lblTongKet.AutoSize = true;
            this.lblTongKet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongKet.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTongKet.Location = new System.Drawing.Point(12, 34);
            this.lblTongKet.Name = "lblTongKet";
            this.lblTongKet.Size = new System.Drawing.Size(439, 28);
            this.lblTongKet.TabIndex = 0;
            this.lblTongKet.Text = "Tổng vé bán: 0   |   Số ngày: 0   |   TB/ngày: 0";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
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
            this.dgvBaoCao.Size = new System.Drawing.Size(1208, 440);
            this.dgvBaoCao.TabIndex = 1;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(1054, 514);
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
            this.btnThoat.Location = new System.Drawing.Point(1121, 44);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 42);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmBCVeBanNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1266, 746);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.grpKetQua);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBCVeBanNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📈 BÁO CÁO VÉ BÁN THEO NGÀY";
            this.Load += new System.EventHandler(this.FrmBCVeBanNgay_Load);
            this.grpLoc.ResumeLayout(false);
            this.grpLoc.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpLoc, grpKetQua;
        private System.Windows.Forms.DateTimePicker dtpTuNgay, dtpDenNgay;
        private System.Windows.Forms.Label label1, label2, lblTongKet;
        private System.Windows.Forms.Button btnXem, btnHomNay, btnThangNay, btnLamMoi, btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Button btnThoat;
    }
}
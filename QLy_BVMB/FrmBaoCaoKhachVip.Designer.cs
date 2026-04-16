namespace QLy_BVMB
{
    partial class FrmBaoCaoKhachVip
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.nudNguongVe = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.lblTongKhach = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNguongVe)).BeginInit();
            this.grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLoc
            // 
            this.grpLoc.Controls.Add(this.btnThoat);
            this.grpLoc.Controls.Add(this.nudNguongVe);
            this.grpLoc.Controls.Add(this.label1);
            this.grpLoc.Controls.Add(this.btnXem);
            this.grpLoc.Controls.Add(this.btnLamMoi);
            this.grpLoc.Controls.Add(this.lblHuongDan);
            this.grpLoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpLoc.Location = new System.Drawing.Point(16, 16);
            this.grpLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLoc.Size = new System.Drawing.Size(1234, 120);
            this.grpLoc.TabIndex = 0;
            this.grpLoc.TabStop = false;
            this.grpLoc.Text = "🌟 Tiêu chí khách VIP";
            // 
            // nudNguongVe
            // 
            this.nudNguongVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudNguongVe.Location = new System.Drawing.Point(206, 66);
            this.nudNguongVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNguongVe.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNguongVe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNguongVe.Name = "nudNguongVe";
            this.nudNguongVe.Size = new System.Drawing.Size(102, 31);
            this.nudNguongVe.TabIndex = 0;
            this.nudNguongVe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số vé tối thiểu (N):";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Goldenrod;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(334, 62);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(168, 42);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "🌟 Xem khách VIP";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(521, 62);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(128, 42);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHuongDan.ForeColor = System.Drawing.Color.DimGray;
            this.lblHuongDan.Location = new System.Drawing.Point(19, 29);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(398, 25);
            this.lblHuongDan.TabIndex = 4;
            this.lblHuongDan.Text = "Khách VIP: những hành khách đặt từ N vé trở lên";
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.lblTongKhach);
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
            this.grpKetQua.Text = "🏆 Danh sách khách VIP (🥇=Vàng, 🥈=Bạc, 🥉=Đồng)";
            // 
            // lblTongKhach
            // 
            this.lblTongKhach.AutoSize = true;
            this.lblTongKhach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTongKhach.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTongKhach.Location = new System.Drawing.Point(12, 34);
            this.lblTongKhach.Name = "lblTongKhach";
            this.lblTongKhach.Size = new System.Drawing.Size(208, 25);
            this.lblTongKhach.TabIndex = 0;
            this.lblTongKhach.Text = "Số lượng khách VIP: 0";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
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
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(670, 62);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 42);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmBaoCaoKhachVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1266, 746);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.grpKetQua);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBaoCaoKhachVip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🌟 BÁO CÁO KHÁCH VIP";
            this.Load += new System.EventHandler(this.FrmBaoCaoKhachVip_Load);
            this.grpLoc.ResumeLayout(false);
            this.grpLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNguongVe)).EndInit();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpLoc, grpKetQua;
        private System.Windows.Forms.NumericUpDown nudNguongVe;
        private System.Windows.Forms.Label label1, lblTongKhach, lblHuongDan;
        private System.Windows.Forms.Button btnXem, btnLamMoi, btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Button btnThoat;
    }
}
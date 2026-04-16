namespace QLy_BVMB
{
    partial class FrmHanhKhach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvHanhKhach = new System.Windows.Forms.DataGridView();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.btnThemHK = new System.Windows.Forms.Button();
            this.btnSuaHK = new System.Windows.Forms.Button();
            this.btnXoaHK = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(361, 280);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(444, 26);
            this.dtpNgaySinh.TabIndex = 50;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(359, 325);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(446, 35);
            this.txtCCCD.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 48;
            this.label6.Text = "SĐT :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "CCCD :";
            // 
            // dgvHanhKhach
            // 
            this.dgvHanhKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhKhach.Location = new System.Drawing.Point(197, 509);
            this.dgvHanhKhach.Name = "dgvHanhKhach";
            this.dgvHanhKhach.RowHeadersWidth = 62;
            this.dgvHanhKhach.RowTemplate.Height = 28;
            this.dgvHanhKhach.Size = new System.Drawing.Size(684, 290);
            this.dgvHanhKhach.TabIndex = 46;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(359, 225);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(446, 35);
            this.txtHoTen.TabIndex = 45;
            // 
            // txtMaHK
            // 
            this.txtMaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHK.Location = new System.Drawing.Point(359, 170);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(446, 35);
            this.txtMaHK.TabIndex = 44;
            // 
            // btnThemHK
            // 
            this.btnThemHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHK.Location = new System.Drawing.Point(1082, 176);
            this.btnThemHK.Name = "btnThemHK";
            this.btnThemHK.Size = new System.Drawing.Size(154, 49);
            this.btnThemHK.TabIndex = 43;
            this.btnThemHK.Text = "THÊM";
            this.btnThemHK.UseVisualStyleBackColor = true;
            this.btnThemHK.Click += new System.EventHandler(this.btnThemHK_Click);
            // 
            // btnSuaHK
            // 
            this.btnSuaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHK.Location = new System.Drawing.Point(1082, 248);
            this.btnSuaHK.Name = "btnSuaHK";
            this.btnSuaHK.Size = new System.Drawing.Size(154, 49);
            this.btnSuaHK.TabIndex = 42;
            this.btnSuaHK.Text = "SỬA";
            this.btnSuaHK.UseVisualStyleBackColor = true;
            this.btnSuaHK.Click += new System.EventHandler(this.btnSuaHK_Click);
            // 
            // btnXoaHK
            // 
            this.btnXoaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHK.Location = new System.Drawing.Point(1082, 325);
            this.btnXoaHK.Name = "btnXoaHK";
            this.btnXoaHK.Size = new System.Drawing.Size(154, 49);
            this.btnXoaHK.TabIndex = 41;
            this.btnXoaHK.Text = "XOÁ";
            this.btnXoaHK.UseVisualStyleBackColor = true;
            this.btnXoaHK.Click += new System.EventHandler(this.btnXoaHK_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(1082, 408);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(154, 49);
            this.btnTHOAT.TabIndex = 40;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "NGÀY SINH :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "MÃ HK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "HỌ TÊN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 55);
            this.label1.TabIndex = 35;
            this.label1.Text = "THÔNG TIN HÀNH KHÁCH";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(361, 382);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(446, 35);
            this.txtSDT.TabIndex = 51;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(359, 449);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(446, 35);
            this.txtEmail.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 53;
            this.label7.Text = "EMAIL:";
            // 
            // FrmHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 822);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvHanhKhach);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaHK);
            this.Controls.Add(this.btnThemHK);
            this.Controls.Add(this.btnSuaHK);
            this.Controls.Add(this.btnXoaHK);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHanhKhach";
            this.Text = "FrmHanhKhach";
            this.Load += new System.EventHandler(this.FrmHanhKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHanhKhach;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.Button btnThemHK;
        private System.Windows.Forms.Button btnSuaHK;
        private System.Windows.Forms.Button btnXoaHK;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
    }
}
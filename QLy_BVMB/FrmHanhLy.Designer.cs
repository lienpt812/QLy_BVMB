namespace QLy_BVMB
{
    partial class FrmHanhLy
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
            this.cboMaVe = new System.Windows.Forms.ComboBox();
            this.txtPhiThem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvHanhLy = new System.Windows.Forms.DataGridView();
            this.txtMaHanhLy = new System.Windows.Forms.TextBox();
            this.btnSuaHL = new System.Windows.Forms.Button();
            this.btnXoaHL = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnThemHL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numKhoiLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKhoiLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaVe
            // 
            this.cboMaVe.FormattingEnabled = true;
            this.cboMaVe.Location = new System.Drawing.Point(198, 185);
            this.cboMaVe.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaVe.Name = "cboMaVe";
            this.cboMaVe.Size = new System.Drawing.Size(446, 28);
            this.cboMaVe.TabIndex = 54;
            // 
            // txtPhiThem
            // 
            this.txtPhiThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhiThem.Location = new System.Drawing.Point(198, 281);
            this.txtPhiThem.Name = "txtPhiThem";
            this.txtPhiThem.ReadOnly = true;
            this.txtPhiThem.Size = new System.Drawing.Size(446, 35);
            this.txtPhiThem.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 48;
            this.label6.Text = "MÃ VÉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "PHÍ THÊM :";
            // 
            // dgvHanhLy
            // 
            this.dgvHanhLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhLy.Location = new System.Drawing.Point(93, 405);
            this.dgvHanhLy.Name = "dgvHanhLy";
            this.dgvHanhLy.RowHeadersWidth = 62;
            this.dgvHanhLy.RowTemplate.Height = 28;
            this.dgvHanhLy.Size = new System.Drawing.Size(684, 290);
            this.dgvHanhLy.TabIndex = 46;
            // 
            // txtMaHanhLy
            // 
            this.txtMaHanhLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHanhLy.Location = new System.Drawing.Point(198, 138);
            this.txtMaHanhLy.Name = "txtMaHanhLy";
            this.txtMaHanhLy.Size = new System.Drawing.Size(446, 35);
            this.txtMaHanhLy.TabIndex = 44;
            // 
            // btnSuaHL
            // 
            this.btnSuaHL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHL.Location = new System.Drawing.Point(820, 174);
            this.btnSuaHL.Name = "btnSuaHL";
            this.btnSuaHL.Size = new System.Drawing.Size(194, 49);
            this.btnSuaHL.TabIndex = 43;
            this.btnSuaHL.Text = "Sửa";
            this.btnSuaHL.UseVisualStyleBackColor = true;
            this.btnSuaHL.Click += new System.EventHandler(this.btnSuaHL_Click);
            // 
            // btnXoaHL
            // 
            this.btnXoaHL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHL.Location = new System.Drawing.Point(820, 251);
            this.btnXoaHL.Name = "btnXoaHL";
            this.btnXoaHL.Size = new System.Drawing.Size(194, 49);
            this.btnXoaHL.TabIndex = 42;
            this.btnXoaHL.Text = "Xoá";
            this.btnXoaHL.UseVisualStyleBackColor = true;
            this.btnXoaHL.Click += new System.EventHandler(this.btnXoaHL_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(820, 340);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(194, 49);
            this.btnTHOAT.TabIndex = 40;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnThemHL
            // 
            this.btnThemHL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHL.Location = new System.Drawing.Point(820, 94);
            this.btnThemHL.Name = "btnThemHL";
            this.btnThemHL.Size = new System.Drawing.Size(194, 49);
            this.btnThemHL.TabIndex = 39;
            this.btnThemHL.Text = "Thêm hành lý";
            this.btnThemHL.UseVisualStyleBackColor = true;
            this.btnThemHL.Click += new System.EventHandler(this.btnThemHL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "MÃ HÀNH LÝ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "KHỐI LƯỢNG:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 55);
            this.label1.TabIndex = 35;
            this.label1.Text = "THÔNG TIN HÀNH LÝ";
            // 
            // numKhoiLuong
            // 
            this.numKhoiLuong.Location = new System.Drawing.Point(209, 232);
            this.numKhoiLuong.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numKhoiLuong.Name = "numKhoiLuong";
            this.numKhoiLuong.Size = new System.Drawing.Size(413, 26);
            this.numKhoiLuong.TabIndex = 55;
            this.numKhoiLuong.ValueChanged += new System.EventHandler(this.numKhoiLuong_ValueChanged);
            // 
            // FrmHanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 727);
            this.Controls.Add(this.numKhoiLuong);
            this.Controls.Add(this.cboMaVe);
            this.Controls.Add(this.txtPhiThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvHanhLy);
            this.Controls.Add(this.txtMaHanhLy);
            this.Controls.Add(this.btnSuaHL);
            this.Controls.Add(this.btnXoaHL);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnThemHL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHanhLy";
            this.Text = "FrmHanhLy";
            this.Load += new System.EventHandler(this.FrmHanhLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKhoiLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaVe;
        private System.Windows.Forms.TextBox txtPhiThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHanhLy;
        private System.Windows.Forms.TextBox txtMaHanhLy;
        private System.Windows.Forms.Button btnSuaHL;
        private System.Windows.Forms.Button btnXoaHL;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnThemHL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numKhoiLuong;
    }
}
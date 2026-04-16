namespace QLy_BVMB
{
    partial class FrmTimKiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbMaCB = new System.Windows.Forms.ComboBox();
            this.optChuyen = new System.Windows.Forms.RadioButton();
            this.optNgay = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG TÌM KIẾM THÔNG TIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(770, 90);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(126, 43);
            this.btnTK.TabIndex = 6;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(770, 151);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 43);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá bộ lọc";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(813, 274);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(366, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 26);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // cbbMaCB
            // 
            this.cbbMaCB.FormattingEnabled = true;
            this.cbbMaCB.Location = new System.Drawing.Point(75, 158);
            this.cbbMaCB.Name = "cbbMaCB";
            this.cbbMaCB.Size = new System.Drawing.Size(229, 28);
            this.cbbMaCB.TabIndex = 21;
            // 
            // optChuyen
            // 
            this.optChuyen.AutoSize = true;
            this.optChuyen.Location = new System.Drawing.Point(75, 118);
            this.optChuyen.Name = "optChuyen";
            this.optChuyen.Size = new System.Drawing.Size(143, 24);
            this.optChuyen.TabIndex = 22;
            this.optChuyen.TabStop = true;
            this.optChuyen.Text = "Số hiệu chuyến";
            this.optChuyen.UseVisualStyleBackColor = true;
            // 
            // optNgay
            // 
            this.optNgay.AutoSize = true;
            this.optNgay.Location = new System.Drawing.Point(366, 118);
            this.optNgay.Name = "optNgay";
            this.optNgay.Size = new System.Drawing.Size(99, 24);
            this.optNgay.TabIndex = 23;
            this.optNgay.TabStop = true;
            this.optNgay.Text = "Ngày bay";
            this.optNgay.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(770, 214);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 43);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 681);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.optNgay);
            this.Controls.Add(this.optChuyen);
            this.Controls.Add(this.cbbMaCB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimKiem";
            this.Text = "FrmTimKiem";
            this.Load += new System.EventHandler(this.FrmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbMaCB;
        private System.Windows.Forms.RadioButton optChuyen;
        private System.Windows.Forms.RadioButton optNgay;
        private System.Windows.Forms.Button btnThoat;
    }
}
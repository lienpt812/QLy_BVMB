namespace QLy_BVMB
{
    partial class FrmVeChuyenBay
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
            this.cboMACB = new System.Windows.Forms.ComboBox();
            this.cboMAHK = new System.Windows.Forms.ComboBox();
            this.cboMAGHE = new System.Windows.Forms.ComboBox();
            this.dtTHOIGIANDAT = new System.Windows.Forms.DateTimePicker();
            this.Data_VECHUYENBAY = new System.Windows.Forms.DataGridView();
            this.lblTIEUDE = new System.Windows.Forms.Label();
            this.lblMAGHE = new System.Windows.Forms.Label();
            this.lblTHOIGIANDAT = new System.Windows.Forms.Label();
            this.lblMACB = new System.Windows.Forms.Label();
            this.lblMAVE = new System.Windows.Forms.Label();
            this.lblMAHK = new System.Windows.Forms.Label();
            this.txtMAVE = new System.Windows.Forms.TextBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnTAOMOI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_VECHUYENBAY)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMACB
            // 
            this.cboMACB.FormattingEnabled = true;
            this.cboMACB.Location = new System.Drawing.Point(315, 183);
            this.cboMACB.Name = "cboMACB";
            this.cboMACB.Size = new System.Drawing.Size(206, 24);
            this.cboMACB.TabIndex = 67;
            // 
            // cboMAHK
            // 
            this.cboMAHK.FormattingEnabled = true;
            this.cboMAHK.Location = new System.Drawing.Point(315, 145);
            this.cboMAHK.Name = "cboMAHK";
            this.cboMAHK.Size = new System.Drawing.Size(206, 24);
            this.cboMAHK.TabIndex = 66;
            // 
            // cboMAGHE
            // 
            this.cboMAGHE.FormattingEnabled = true;
            this.cboMAGHE.Location = new System.Drawing.Point(315, 232);
            this.cboMAGHE.Name = "cboMAGHE";
            this.cboMAGHE.Size = new System.Drawing.Size(206, 24);
            this.cboMAGHE.TabIndex = 65;
            // 
            // dtTHOIGIANDAT
            // 
            this.dtTHOIGIANDAT.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTHOIGIANDAT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTHOIGIANDAT.Location = new System.Drawing.Point(315, 271);
            this.dtTHOIGIANDAT.Name = "dtTHOIGIANDAT";
            this.dtTHOIGIANDAT.ShowUpDown = true;
            this.dtTHOIGIANDAT.Size = new System.Drawing.Size(209, 22);
            this.dtTHOIGIANDAT.TabIndex = 64;
            // 
            // Data_VECHUYENBAY
            // 
            this.Data_VECHUYENBAY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_VECHUYENBAY.Location = new System.Drawing.Point(94, 328);
            this.Data_VECHUYENBAY.Name = "Data_VECHUYENBAY";
            this.Data_VECHUYENBAY.RowHeadersWidth = 51;
            this.Data_VECHUYENBAY.RowTemplate.Height = 24;
            this.Data_VECHUYENBAY.Size = new System.Drawing.Size(705, 189);
            this.Data_VECHUYENBAY.TabIndex = 63;
            // 
            // lblTIEUDE
            // 
            this.lblTIEUDE.AutoSize = true;
            this.lblTIEUDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIEUDE.Location = new System.Drawing.Point(220, 33);
            this.lblTIEUDE.Name = "lblTIEUDE";
            this.lblTIEUDE.Size = new System.Drawing.Size(639, 51);
            this.lblTIEUDE.TabIndex = 62;
            this.lblTIEUDE.Text = "THÔNG TIN VÉ CHUYẾN BAY";
            // 
            // lblMAGHE
            // 
            this.lblMAGHE.AutoSize = true;
            this.lblMAGHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAGHE.Location = new System.Drawing.Point(111, 230);
            this.lblMAGHE.Name = "lblMAGHE";
            this.lblMAGHE.Size = new System.Drawing.Size(92, 22);
            this.lblMAGHE.TabIndex = 58;
            this.lblMAGHE.Text = "MÃ GHẾ:";
            // 
            // lblTHOIGIANDAT
            // 
            this.lblTHOIGIANDAT.AutoSize = true;
            this.lblTHOIGIANDAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHOIGIANDAT.Location = new System.Drawing.Point(111, 271);
            this.lblTHOIGIANDAT.Name = "lblTHOIGIANDAT";
            this.lblTHOIGIANDAT.Size = new System.Drawing.Size(162, 22);
            this.lblTHOIGIANDAT.TabIndex = 59;
            this.lblTHOIGIANDAT.Text = "THỜI GIAN ĐẶT:";
            // 
            // lblMACB
            // 
            this.lblMACB.AutoSize = true;
            this.lblMACB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMACB.Location = new System.Drawing.Point(111, 185);
            this.lblMACB.Name = "lblMACB";
            this.lblMACB.Size = new System.Drawing.Size(177, 22);
            this.lblMACB.TabIndex = 57;
            this.lblMACB.Text = "MÃ CHUYẾN BAY:";
            // 
            // lblMAVE
            // 
            this.lblMAVE.AutoSize = true;
            this.lblMAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAVE.Location = new System.Drawing.Point(111, 100);
            this.lblMAVE.Name = "lblMAVE";
            this.lblMAVE.Size = new System.Drawing.Size(76, 22);
            this.lblMAVE.TabIndex = 60;
            this.lblMAVE.Text = "MÃ VÉ:";
            // 
            // lblMAHK
            // 
            this.lblMAHK.AutoSize = true;
            this.lblMAHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAHK.Location = new System.Drawing.Point(111, 147);
            this.lblMAHK.Name = "lblMAHK";
            this.lblMAHK.Size = new System.Drawing.Size(179, 22);
            this.lblMAHK.TabIndex = 61;
            this.lblMAHK.Text = "MÃ HÀNH KHÁCH:";
            // 
            // txtMAVE
            // 
            this.txtMAVE.Location = new System.Drawing.Point(315, 102);
            this.txtMAVE.Name = "txtMAVE";
            this.txtMAVE.Size = new System.Drawing.Size(209, 22);
            this.txtMAVE.TabIndex = 56;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(846, 328);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(192, 34);
            this.btnTHOAT.TabIndex = 55;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(846, 271);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(192, 40);
            this.btnXOA.TabIndex = 54;
            this.btnXOA.Text = "XÓA DỮ LIỆU";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUA.Location = new System.Drawing.Point(846, 215);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(192, 41);
            this.btnSUA.TabIndex = 53;
            this.btnSUA.Text = "SỬA DỮ LIỆU";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLUU.Location = new System.Drawing.Point(846, 168);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(192, 39);
            this.btnLUU.TabIndex = 52;
            this.btnLUU.Text = "LƯU DỮ LIỆU";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // btnTAOMOI
            // 
            this.btnTAOMOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAOMOI.Location = new System.Drawing.Point(846, 108);
            this.btnTAOMOI.Name = "btnTAOMOI";
            this.btnTAOMOI.Size = new System.Drawing.Size(192, 43);
            this.btnTAOMOI.TabIndex = 51;
            this.btnTAOMOI.Text = "TẠO MỚI";
            this.btnTAOMOI.UseVisualStyleBackColor = true;
            this.btnTAOMOI.Click += new System.EventHandler(this.btnTAOMOI_Click);
            // 
            // FrmVeChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 666);
            this.Controls.Add(this.cboMACB);
            this.Controls.Add(this.cboMAHK);
            this.Controls.Add(this.cboMAGHE);
            this.Controls.Add(this.dtTHOIGIANDAT);
            this.Controls.Add(this.Data_VECHUYENBAY);
            this.Controls.Add(this.lblTIEUDE);
            this.Controls.Add(this.lblMAGHE);
            this.Controls.Add(this.lblTHOIGIANDAT);
            this.Controls.Add(this.lblMACB);
            this.Controls.Add(this.lblMAVE);
            this.Controls.Add(this.lblMAHK);
            this.Controls.Add(this.txtMAVE);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnTAOMOI);
            this.Name = "FrmVeChuyenBay";
            this.Text = "FrmVeChuyenBay";
            this.Load += new System.EventHandler(this.FrmVeChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_VECHUYENBAY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMACB;
        private System.Windows.Forms.ComboBox cboMAHK;
        private System.Windows.Forms.ComboBox cboMAGHE;
        private System.Windows.Forms.DateTimePicker dtTHOIGIANDAT;
        private System.Windows.Forms.DataGridView Data_VECHUYENBAY;
        private System.Windows.Forms.Label lblTIEUDE;
        private System.Windows.Forms.Label lblMAGHE;
        private System.Windows.Forms.Label lblTHOIGIANDAT;
        private System.Windows.Forms.Label lblMACB;
        private System.Windows.Forms.Label lblMAVE;
        private System.Windows.Forms.Label lblMAHK;
        private System.Windows.Forms.TextBox txtMAVE;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnTAOMOI;
    }
}
namespace QLy_BVMB
{
    partial class FrmChuyenBay
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
            this.cboSANBAYDEN = new System.Windows.Forms.ComboBox();
            this.dtNGAYDI = new System.Windows.Forms.DateTimePicker();
            this.Data_CHUYENBAY = new System.Windows.Forms.DataGridView();
            this.lblTIEUDE = new System.Windows.Forms.Label();
            this.lblSANBAYDEN = new System.Windows.Forms.Label();
            this.lblNGAYDI = new System.Windows.Forms.Label();
            this.lblSANBAYDI = new System.Windows.Forms.Label();
            this.lblMACHUYENBAY = new System.Windows.Forms.Label();
            this.lblMAMAYBAY = new System.Windows.Forms.Label();
            this.txtMACHUYENBAY = new System.Windows.Forms.TextBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnTAOMOI = new System.Windows.Forms.Button();
            this.cboMAMAYBAY = new System.Windows.Forms.ComboBox();
            this.cboSANBAYDI = new System.Windows.Forms.ComboBox();
            this.dtNGAYDEN = new System.Windows.Forms.DateTimePicker();
            this.lblNGAYDEN = new System.Windows.Forms.Label();
            this.cboTRANGTHAI = new System.Windows.Forms.ComboBox();
            this.lblTRANGTHAI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data_CHUYENBAY)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSANBAYDEN
            // 
            this.cboSANBAYDEN.FormattingEnabled = true;
            this.cboSANBAYDEN.Location = new System.Drawing.Point(380, 228);
            this.cboSANBAYDEN.Name = "cboSANBAYDEN";
            this.cboSANBAYDEN.Size = new System.Drawing.Size(206, 24);
            this.cboSANBAYDEN.TabIndex = 44;
            // 
            // dtNGAYDI
            // 
            this.dtNGAYDI.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtNGAYDI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNGAYDI.Location = new System.Drawing.Point(380, 267);
            this.dtNGAYDI.Name = "dtNGAYDI";
            this.dtNGAYDI.ShowUpDown = true;
            this.dtNGAYDI.Size = new System.Drawing.Size(209, 22);
            this.dtNGAYDI.TabIndex = 43;
            // 
            // Data_CHUYENBAY
            // 
            this.Data_CHUYENBAY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_CHUYENBAY.Location = new System.Drawing.Point(156, 372);
            this.Data_CHUYENBAY.Name = "Data_CHUYENBAY";
            this.Data_CHUYENBAY.RowHeadersWidth = 51;
            this.Data_CHUYENBAY.RowTemplate.Height = 24;
            this.Data_CHUYENBAY.Size = new System.Drawing.Size(705, 189);
            this.Data_CHUYENBAY.TabIndex = 40;
            // 
            // lblTIEUDE
            // 
            this.lblTIEUDE.AutoSize = true;
            this.lblTIEUDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIEUDE.Location = new System.Drawing.Point(285, 29);
            this.lblTIEUDE.Name = "lblTIEUDE";
            this.lblTIEUDE.Size = new System.Drawing.Size(567, 51);
            this.lblTIEUDE.TabIndex = 39;
            this.lblTIEUDE.Text = "THÔNG TIN CHUYẾN BAY";
            // 
            // lblSANBAYDEN
            // 
            this.lblSANBAYDEN.AutoSize = true;
            this.lblSANBAYDEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSANBAYDEN.Location = new System.Drawing.Point(176, 226);
            this.lblSANBAYDEN.Name = "lblSANBAYDEN";
            this.lblSANBAYDEN.Size = new System.Drawing.Size(148, 22);
            this.lblSANBAYDEN.TabIndex = 34;
            this.lblSANBAYDEN.Text = "SÂN BAY ĐẾN:";
            this.lblSANBAYDEN.Click += new System.EventHandler(this.lblMalop_Click);
            // 
            // lblNGAYDI
            // 
            this.lblNGAYDI.AutoSize = true;
            this.lblNGAYDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNGAYDI.Location = new System.Drawing.Point(176, 267);
            this.lblNGAYDI.Name = "lblNGAYDI";
            this.lblNGAYDI.Size = new System.Drawing.Size(96, 22);
            this.lblNGAYDI.TabIndex = 36;
            this.lblNGAYDI.Text = "NGÀY ĐI:";
            this.lblNGAYDI.Click += new System.EventHandler(this.lblNGAYSINH_Click);
            // 
            // lblSANBAYDI
            // 
            this.lblSANBAYDI.AutoSize = true;
            this.lblSANBAYDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSANBAYDI.Location = new System.Drawing.Point(176, 181);
            this.lblSANBAYDI.Name = "lblSANBAYDI";
            this.lblSANBAYDI.Size = new System.Drawing.Size(126, 22);
            this.lblSANBAYDI.TabIndex = 33;
            this.lblSANBAYDI.Text = "SÂN BAY ĐI:";
            // 
            // lblMACHUYENBAY
            // 
            this.lblMACHUYENBAY.AutoSize = true;
            this.lblMACHUYENBAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMACHUYENBAY.Location = new System.Drawing.Point(176, 96);
            this.lblMACHUYENBAY.Name = "lblMACHUYENBAY";
            this.lblMACHUYENBAY.Size = new System.Drawing.Size(177, 22);
            this.lblMACHUYENBAY.TabIndex = 37;
            this.lblMACHUYENBAY.Text = "MÃ CHUYẾN BAY:";
            // 
            // lblMAMAYBAY
            // 
            this.lblMAMAYBAY.AutoSize = true;
            this.lblMAMAYBAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAMAYBAY.Location = new System.Drawing.Point(176, 143);
            this.lblMAMAYBAY.Name = "lblMAMAYBAY";
            this.lblMAMAYBAY.Size = new System.Drawing.Size(136, 22);
            this.lblMAMAYBAY.TabIndex = 38;
            this.lblMAMAYBAY.Text = "MÃ MÁY BAY:";
            // 
            // txtMACHUYENBAY
            // 
            this.txtMACHUYENBAY.Location = new System.Drawing.Point(380, 98);
            this.txtMACHUYENBAY.Name = "txtMACHUYENBAY";
            this.txtMACHUYENBAY.Size = new System.Drawing.Size(209, 22);
            this.txtMACHUYENBAY.TabIndex = 32;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(911, 324);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(192, 34);
            this.btnTHOAT.TabIndex = 29;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(911, 267);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(192, 40);
            this.btnXOA.TabIndex = 28;
            this.btnXOA.Text = "XÓA DỮ LIỆU";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUA.Location = new System.Drawing.Point(911, 211);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(192, 41);
            this.btnSUA.TabIndex = 27;
            this.btnSUA.Text = "SỬA DỮ LIỆU";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLUU.Location = new System.Drawing.Point(911, 164);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(192, 39);
            this.btnLUU.TabIndex = 26;
            this.btnLUU.Text = "LƯU DỮ LIỆU";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // btnTAOMOI
            // 
            this.btnTAOMOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAOMOI.Location = new System.Drawing.Point(911, 104);
            this.btnTAOMOI.Name = "btnTAOMOI";
            this.btnTAOMOI.Size = new System.Drawing.Size(192, 43);
            this.btnTAOMOI.TabIndex = 25;
            this.btnTAOMOI.Text = "TẠO MỚI";
            this.btnTAOMOI.UseVisualStyleBackColor = true;
            this.btnTAOMOI.Click += new System.EventHandler(this.btnTAOMOI_Click);
            // 
            // cboMAMAYBAY
            // 
            this.cboMAMAYBAY.FormattingEnabled = true;
            this.cboMAMAYBAY.Location = new System.Drawing.Point(380, 141);
            this.cboMAMAYBAY.Name = "cboMAMAYBAY";
            this.cboMAMAYBAY.Size = new System.Drawing.Size(206, 24);
            this.cboMAMAYBAY.TabIndex = 45;
            // 
            // cboSANBAYDI
            // 
            this.cboSANBAYDI.FormattingEnabled = true;
            this.cboSANBAYDI.Location = new System.Drawing.Point(380, 179);
            this.cboSANBAYDI.Name = "cboSANBAYDI";
            this.cboSANBAYDI.Size = new System.Drawing.Size(206, 24);
            this.cboSANBAYDI.TabIndex = 46;
            // 
            // dtNGAYDEN
            // 
            this.dtNGAYDEN.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtNGAYDEN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNGAYDEN.Location = new System.Drawing.Point(380, 303);
            this.dtNGAYDEN.Name = "dtNGAYDEN";
            this.dtNGAYDEN.ShowUpDown = true;
            this.dtNGAYDEN.Size = new System.Drawing.Size(209, 22);
            this.dtNGAYDEN.TabIndex = 48;
            // 
            // lblNGAYDEN
            // 
            this.lblNGAYDEN.AutoSize = true;
            this.lblNGAYDEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNGAYDEN.Location = new System.Drawing.Point(176, 303);
            this.lblNGAYDEN.Name = "lblNGAYDEN";
            this.lblNGAYDEN.Size = new System.Drawing.Size(118, 22);
            this.lblNGAYDEN.TabIndex = 47;
            this.lblNGAYDEN.Text = "NGÀY ĐẾN:";
            // 
            // cboTRANGTHAI
            // 
            this.cboTRANGTHAI.FormattingEnabled = true;
            this.cboTRANGTHAI.Location = new System.Drawing.Point(380, 334);
            this.cboTRANGTHAI.Name = "cboTRANGTHAI";
            this.cboTRANGTHAI.Size = new System.Drawing.Size(206, 24);
            this.cboTRANGTHAI.TabIndex = 50;
            // 
            // lblTRANGTHAI
            // 
            this.lblTRANGTHAI.AutoSize = true;
            this.lblTRANGTHAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTRANGTHAI.Location = new System.Drawing.Point(176, 336);
            this.lblTRANGTHAI.Name = "lblTRANGTHAI";
            this.lblTRANGTHAI.Size = new System.Drawing.Size(136, 22);
            this.lblTRANGTHAI.TabIndex = 49;
            this.lblTRANGTHAI.Text = "TRẠNG THÁI:";
            // 
            // FrmChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 542);
            this.Controls.Add(this.cboTRANGTHAI);
            this.Controls.Add(this.lblTRANGTHAI);
            this.Controls.Add(this.dtNGAYDEN);
            this.Controls.Add(this.lblNGAYDEN);
            this.Controls.Add(this.cboSANBAYDI);
            this.Controls.Add(this.cboMAMAYBAY);
            this.Controls.Add(this.cboSANBAYDEN);
            this.Controls.Add(this.dtNGAYDI);
            this.Controls.Add(this.Data_CHUYENBAY);
            this.Controls.Add(this.lblTIEUDE);
            this.Controls.Add(this.lblSANBAYDEN);
            this.Controls.Add(this.lblNGAYDI);
            this.Controls.Add(this.lblSANBAYDI);
            this.Controls.Add(this.lblMACHUYENBAY);
            this.Controls.Add(this.lblMAMAYBAY);
            this.Controls.Add(this.txtMACHUYENBAY);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnTAOMOI);
            this.Name = "FrmChuyenBay";
            this.Text = "FrmChuyenBay";
            this.Load += new System.EventHandler(this.FrmChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_CHUYENBAY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSANBAYDEN;
        private System.Windows.Forms.DateTimePicker dtNGAYDI;
        private System.Windows.Forms.DataGridView Data_CHUYENBAY;
        private System.Windows.Forms.Label lblTIEUDE;
        private System.Windows.Forms.Label lblSANBAYDEN;
        private System.Windows.Forms.Label lblNGAYDI;
        private System.Windows.Forms.Label lblSANBAYDI;
        private System.Windows.Forms.Label lblMACHUYENBAY;
        private System.Windows.Forms.Label lblMAMAYBAY;
        private System.Windows.Forms.TextBox txtMACHUYENBAY;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnTAOMOI;
        private System.Windows.Forms.ComboBox cboMAMAYBAY;
        private System.Windows.Forms.ComboBox cboSANBAYDI;
        private System.Windows.Forms.DateTimePicker dtNGAYDEN;
        private System.Windows.Forms.Label lblNGAYDEN;
        private System.Windows.Forms.ComboBox cboTRANGTHAI;
        private System.Windows.Forms.Label lblTRANGTHAI;
    }
}
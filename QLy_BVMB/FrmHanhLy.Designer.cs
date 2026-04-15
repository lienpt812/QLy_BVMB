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
            this.cboMAVE = new System.Windows.Forms.ComboBox();
            this.Data_HANHLY = new System.Windows.Forms.DataGridView();
            this.lblTIEUDE = new System.Windows.Forms.Label();
            this.lblKHOILUONG = new System.Windows.Forms.Label();
            this.lblMAHANHLY = new System.Windows.Forms.Label();
            this.lblMAVE = new System.Windows.Forms.Label();
            this.txtMAHANHLY = new System.Windows.Forms.TextBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnTAOMOI = new System.Windows.Forms.Button();
            this.txtKHOILUONG = new System.Windows.Forms.TextBox();
            this.txtPHITHEM = new System.Windows.Forms.TextBox();
            this.lblPHITHEM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data_HANHLY)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMAVE
            // 
            this.cboMAVE.FormattingEnabled = true;
            this.cboMAVE.Location = new System.Drawing.Point(290, 178);
            this.cboMAVE.Name = "cboMAVE";
            this.cboMAVE.Size = new System.Drawing.Size(206, 24);
            this.cboMAVE.TabIndex = 79;
            // 
            // Data_HANHLY
            // 
            this.Data_HANHLY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_HANHLY.Location = new System.Drawing.Point(76, 317);
            this.Data_HANHLY.Name = "Data_HANHLY";
            this.Data_HANHLY.RowHeadersWidth = 51;
            this.Data_HANHLY.RowTemplate.Height = 24;
            this.Data_HANHLY.Size = new System.Drawing.Size(705, 189);
            this.Data_HANHLY.TabIndex = 78;
            // 
            // lblTIEUDE
            // 
            this.lblTIEUDE.AutoSize = true;
            this.lblTIEUDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIEUDE.Location = new System.Drawing.Point(298, 46);
            this.lblTIEUDE.Name = "lblTIEUDE";
            this.lblTIEUDE.Size = new System.Drawing.Size(470, 51);
            this.lblTIEUDE.TabIndex = 77;
            this.lblTIEUDE.Text = "THÔNG TIN HÀNH LÝ";
            // 
            // lblKHOILUONG
            // 
            this.lblKHOILUONG.AutoSize = true;
            this.lblKHOILUONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKHOILUONG.Location = new System.Drawing.Point(86, 218);
            this.lblKHOILUONG.Name = "lblKHOILUONG";
            this.lblKHOILUONG.Size = new System.Drawing.Size(138, 22);
            this.lblKHOILUONG.TabIndex = 74;
            this.lblKHOILUONG.Text = "KHỐI LƯỢNG:";
            // 
            // lblMAHANHLY
            // 
            this.lblMAHANHLY.AutoSize = true;
            this.lblMAHANHLY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAHANHLY.Location = new System.Drawing.Point(86, 133);
            this.lblMAHANHLY.Name = "lblMAHANHLY";
            this.lblMAHANHLY.Size = new System.Drawing.Size(135, 22);
            this.lblMAHANHLY.TabIndex = 75;
            this.lblMAHANHLY.Text = "MÃ HÀNH LÝ:";
            // 
            // lblMAVE
            // 
            this.lblMAVE.AutoSize = true;
            this.lblMAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAVE.Location = new System.Drawing.Point(86, 180);
            this.lblMAVE.Name = "lblMAVE";
            this.lblMAVE.Size = new System.Drawing.Size(76, 22);
            this.lblMAVE.TabIndex = 76;
            this.lblMAVE.Text = "MÃ VÉ:";
            // 
            // txtMAHANHLY
            // 
            this.txtMAHANHLY.Location = new System.Drawing.Point(287, 133);
            this.txtMAHANHLY.Name = "txtMAHANHLY";
            this.txtMAHANHLY.Size = new System.Drawing.Size(209, 22);
            this.txtMAHANHLY.TabIndex = 73;
            this.txtMAHANHLY.TextChanged += new System.EventHandler(this.txtGIAVE_TextChanged);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(844, 332);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(192, 34);
            this.btnTHOAT.TabIndex = 72;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(844, 275);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(192, 40);
            this.btnXOA.TabIndex = 71;
            this.btnXOA.Text = "XÓA DỮ LIỆU";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUA.Location = new System.Drawing.Point(844, 217);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(192, 41);
            this.btnSUA.TabIndex = 70;
            this.btnSUA.Text = "SỬA DỮ LIỆU";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLUU.Location = new System.Drawing.Point(844, 172);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(192, 39);
            this.btnLUU.TabIndex = 69;
            this.btnLUU.Text = "LƯU DỮ LIỆU";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // btnTAOMOI
            // 
            this.btnTAOMOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAOMOI.Location = new System.Drawing.Point(844, 112);
            this.btnTAOMOI.Name = "btnTAOMOI";
            this.btnTAOMOI.Size = new System.Drawing.Size(192, 43);
            this.btnTAOMOI.TabIndex = 68;
            this.btnTAOMOI.Text = "TẠO MỚI";
            this.btnTAOMOI.UseVisualStyleBackColor = true;
            this.btnTAOMOI.Click += new System.EventHandler(this.btnTAOMOI_Click);
            // 
            // txtKHOILUONG
            // 
            this.txtKHOILUONG.Location = new System.Drawing.Point(290, 218);
            this.txtKHOILUONG.Name = "txtKHOILUONG";
            this.txtKHOILUONG.Size = new System.Drawing.Size(209, 22);
            this.txtKHOILUONG.TabIndex = 80;
            // 
            // txtPHITHEM
            // 
            this.txtPHITHEM.Location = new System.Drawing.Point(290, 255);
            this.txtPHITHEM.Name = "txtPHITHEM";
            this.txtPHITHEM.Size = new System.Drawing.Size(209, 22);
            this.txtPHITHEM.TabIndex = 81;
            // 
            // lblPHITHEM
            // 
            this.lblPHITHEM.AutoSize = true;
            this.lblPHITHEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPHITHEM.Location = new System.Drawing.Point(86, 255);
            this.lblPHITHEM.Name = "lblPHITHEM";
            this.lblPHITHEM.Size = new System.Drawing.Size(109, 22);
            this.lblPHITHEM.TabIndex = 82;
            this.lblPHITHEM.Text = "PHÍ THÊM:";
            // 
            // FrmHanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 599);
            this.Controls.Add(this.lblPHITHEM);
            this.Controls.Add(this.txtPHITHEM);
            this.Controls.Add(this.txtKHOILUONG);
            this.Controls.Add(this.cboMAVE);
            this.Controls.Add(this.Data_HANHLY);
            this.Controls.Add(this.lblTIEUDE);
            this.Controls.Add(this.lblKHOILUONG);
            this.Controls.Add(this.lblMAHANHLY);
            this.Controls.Add(this.lblMAVE);
            this.Controls.Add(this.txtMAHANHLY);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnTAOMOI);
            this.Name = "FrmHanhLy";
            this.Text = "FrmHanhLy";
            this.Load += new System.EventHandler(this.FrmHanhLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_HANHLY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMAVE;
        private System.Windows.Forms.DataGridView Data_HANHLY;
        private System.Windows.Forms.Label lblTIEUDE;
        private System.Windows.Forms.Label lblKHOILUONG;
        private System.Windows.Forms.Label lblMAHANHLY;
        private System.Windows.Forms.Label lblMAVE;
        private System.Windows.Forms.TextBox txtMAHANHLY;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnTAOMOI;
        private System.Windows.Forms.TextBox txtKHOILUONG;
        private System.Windows.Forms.TextBox txtPHITHEM;
        private System.Windows.Forms.Label lblPHITHEM;
    }
}
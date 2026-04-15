namespace QLy_BVMB
{
    partial class FrmGiaVe
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
            this.cboLOAIGHE = new System.Windows.Forms.ComboBox();
            this.Data_GIAVE = new System.Windows.Forms.DataGridView();
            this.lblTIEUDE = new System.Windows.Forms.Label();
            this.lblMACHUYENBAY = new System.Windows.Forms.Label();
            this.lblLOAIGHE = new System.Windows.Forms.Label();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnTAOMOI = new System.Windows.Forms.Button();
            this.lblGIAVE = new System.Windows.Forms.Label();
            this.txtGIAVE = new System.Windows.Forms.TextBox();
            this.cboMACHUYENBAY = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_GIAVE)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLOAIGHE
            // 
            this.cboLOAIGHE.FormattingEnabled = true;
            this.cboLOAIGHE.Location = new System.Drawing.Point(321, 162);
            this.cboLOAIGHE.Name = "cboLOAIGHE";
            this.cboLOAIGHE.Size = new System.Drawing.Size(206, 24);
            this.cboLOAIGHE.TabIndex = 66;
            // 
            // Data_GIAVE
            // 
            this.Data_GIAVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_GIAVE.Location = new System.Drawing.Point(103, 278);
            this.Data_GIAVE.Name = "Data_GIAVE";
            this.Data_GIAVE.RowHeadersWidth = 51;
            this.Data_GIAVE.RowTemplate.Height = 24;
            this.Data_GIAVE.Size = new System.Drawing.Size(705, 189);
            this.Data_GIAVE.TabIndex = 63;
            this.Data_GIAVE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CHUYENBAY_CellContentClick);
            // 
            // lblTIEUDE
            // 
            this.lblTIEUDE.AutoSize = true;
            this.lblTIEUDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIEUDE.Location = new System.Drawing.Point(329, 30);
            this.lblTIEUDE.Name = "lblTIEUDE";
            this.lblTIEUDE.Size = new System.Drawing.Size(426, 51);
            this.lblTIEUDE.TabIndex = 62;
            this.lblTIEUDE.Text = "THÔNG TIN GIÁ VÉ";
            // 
            // lblMACHUYENBAY
            // 
            this.lblMACHUYENBAY.AutoSize = true;
            this.lblMACHUYENBAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMACHUYENBAY.Location = new System.Drawing.Point(117, 117);
            this.lblMACHUYENBAY.Name = "lblMACHUYENBAY";
            this.lblMACHUYENBAY.Size = new System.Drawing.Size(177, 22);
            this.lblMACHUYENBAY.TabIndex = 60;
            this.lblMACHUYENBAY.Text = "MÃ CHUYẾN BAY:";
            // 
            // lblLOAIGHE
            // 
            this.lblLOAIGHE.AutoSize = true;
            this.lblLOAIGHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOAIGHE.Location = new System.Drawing.Point(117, 164);
            this.lblLOAIGHE.Name = "lblLOAIGHE";
            this.lblLOAIGHE.Size = new System.Drawing.Size(108, 22);
            this.lblLOAIGHE.TabIndex = 61;
            this.lblLOAIGHE.Text = "LOẠI GHẾ:";
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(875, 316);
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
            this.btnXOA.Location = new System.Drawing.Point(875, 259);
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
            this.btnSUA.Location = new System.Drawing.Point(875, 201);
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
            this.btnLUU.Location = new System.Drawing.Point(875, 156);
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
            this.btnTAOMOI.Location = new System.Drawing.Point(875, 96);
            this.btnTAOMOI.Name = "btnTAOMOI";
            this.btnTAOMOI.Size = new System.Drawing.Size(192, 43);
            this.btnTAOMOI.TabIndex = 51;
            this.btnTAOMOI.Text = "TẠO MỚI";
            this.btnTAOMOI.UseVisualStyleBackColor = true;
            this.btnTAOMOI.Click += new System.EventHandler(this.btnTAOMOI_Click);
            // 
            // lblGIAVE
            // 
            this.lblGIAVE.AutoSize = true;
            this.lblGIAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGIAVE.Location = new System.Drawing.Point(117, 202);
            this.lblGIAVE.Name = "lblGIAVE";
            this.lblGIAVE.Size = new System.Drawing.Size(81, 22);
            this.lblGIAVE.TabIndex = 57;
            this.lblGIAVE.Text = "GIÁ VÉ:";
            // 
            // txtGIAVE
            // 
            this.txtGIAVE.Location = new System.Drawing.Point(321, 204);
            this.txtGIAVE.Name = "txtGIAVE";
            this.txtGIAVE.Size = new System.Drawing.Size(209, 22);
            this.txtGIAVE.TabIndex = 56;
            // 
            // cboMACHUYENBAY
            // 
            this.cboMACHUYENBAY.FormattingEnabled = true;
            this.cboMACHUYENBAY.Location = new System.Drawing.Point(321, 117);
            this.cboMACHUYENBAY.Name = "cboMACHUYENBAY";
            this.cboMACHUYENBAY.Size = new System.Drawing.Size(206, 24);
            this.cboMACHUYENBAY.TabIndex = 67;
            // 
            // FrmGiaVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 544);
            this.Controls.Add(this.cboMACHUYENBAY);
            this.Controls.Add(this.cboLOAIGHE);
            this.Controls.Add(this.Data_GIAVE);
            this.Controls.Add(this.lblTIEUDE);
            this.Controls.Add(this.lblGIAVE);
            this.Controls.Add(this.lblMACHUYENBAY);
            this.Controls.Add(this.lblLOAIGHE);
            this.Controls.Add(this.txtGIAVE);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnTAOMOI);
            this.Name = "FrmGiaVe";
            this.Text = "FrmGiaVe";
            this.Load += new System.EventHandler(this.FrmGiaVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_GIAVE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboLOAIGHE;
        private System.Windows.Forms.DataGridView Data_GIAVE;
        private System.Windows.Forms.Label lblTIEUDE;
        private System.Windows.Forms.Label lblMACHUYENBAY;
        private System.Windows.Forms.Label lblLOAIGHE;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnTAOMOI;
        private System.Windows.Forms.Label lblGIAVE;
        private System.Windows.Forms.TextBox txtGIAVE;
        private System.Windows.Forms.ComboBox cboMACHUYENBAY;
    }
}
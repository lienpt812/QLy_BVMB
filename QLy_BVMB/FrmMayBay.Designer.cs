namespace QLy_BVMB
{
    partial class FrmMayBay
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
            this.Data_MAYBAY = new System.Windows.Forms.DataGridView();
            this.lblTIEUDE = new System.Windows.Forms.Label();
            this.lblSOGHE = new System.Windows.Forms.Label();
            this.lblMAMAYBAY = new System.Windows.Forms.Label();
            this.lblHANGHANGKHONG = new System.Windows.Forms.Label();
            this.txtSOGHE = new System.Windows.Forms.TextBox();
            this.txtHANGHANGKHONG = new System.Windows.Forms.TextBox();
            this.txtMAMAYBAY = new System.Windows.Forms.TextBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnTAOMOI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_MAYBAY)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_MAYBAY
            // 
            this.Data_MAYBAY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_MAYBAY.Location = new System.Drawing.Point(129, 306);
            this.Data_MAYBAY.Name = "Data_MAYBAY";
            this.Data_MAYBAY.RowHeadersWidth = 51;
            this.Data_MAYBAY.RowTemplate.Height = 24;
            this.Data_MAYBAY.Size = new System.Drawing.Size(705, 189);
            this.Data_MAYBAY.TabIndex = 49;
            this.Data_MAYBAY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_SANBAY_CellContentClick);
            // 
            // lblTIEUDE
            // 
            this.lblTIEUDE.AutoSize = true;
            this.lblTIEUDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIEUDE.Location = new System.Drawing.Point(324, 8);
            this.lblTIEUDE.Name = "lblTIEUDE";
            this.lblTIEUDE.Size = new System.Drawing.Size(476, 51);
            this.lblTIEUDE.TabIndex = 48;
            this.lblTIEUDE.Text = "THÔNG TIN MÁY BAY";
            this.lblTIEUDE.Click += new System.EventHandler(this.lblTIEUDE_Click);
            // 
            // lblSOGHE
            // 
            this.lblSOGHE.AutoSize = true;
            this.lblSOGHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSOGHE.Location = new System.Drawing.Point(152, 204);
            this.lblSOGHE.Name = "lblSOGHE";
            this.lblSOGHE.Size = new System.Drawing.Size(92, 22);
            this.lblSOGHE.TabIndex = 45;
            this.lblSOGHE.Text = "SỐ GHẾ:";
            // 
            // lblMAMAYBAY
            // 
            this.lblMAMAYBAY.AutoSize = true;
            this.lblMAMAYBAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAMAYBAY.Location = new System.Drawing.Point(152, 112);
            this.lblMAMAYBAY.Name = "lblMAMAYBAY";
            this.lblMAMAYBAY.Size = new System.Drawing.Size(136, 22);
            this.lblMAMAYBAY.TabIndex = 46;
            this.lblMAMAYBAY.Text = "MÃ MÁY BAY:";
            // 
            // lblHANGHANGKHONG
            // 
            this.lblHANGHANGKHONG.AutoSize = true;
            this.lblHANGHANGKHONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHANGHANGKHONG.Location = new System.Drawing.Point(152, 161);
            this.lblHANGHANGKHONG.Name = "lblHANGHANGKHONG";
            this.lblHANGHANGKHONG.Size = new System.Drawing.Size(211, 22);
            this.lblHANGHANGKHONG.TabIndex = 47;
            this.lblHANGHANGKHONG.Text = "HÃNG HÀNG KHÔNG:";
            // 
            // txtSOGHE
            // 
            this.txtSOGHE.Location = new System.Drawing.Point(403, 206);
            this.txtSOGHE.Name = "txtSOGHE";
            this.txtSOGHE.Size = new System.Drawing.Size(209, 22);
            this.txtSOGHE.TabIndex = 42;
            // 
            // txtHANGHANGKHONG
            // 
            this.txtHANGHANGKHONG.Location = new System.Drawing.Point(403, 161);
            this.txtHANGHANGKHONG.Name = "txtHANGHANGKHONG";
            this.txtHANGHANGKHONG.Size = new System.Drawing.Size(209, 22);
            this.txtHANGHANGKHONG.TabIndex = 43;
            // 
            // txtMAMAYBAY
            // 
            this.txtMAMAYBAY.Location = new System.Drawing.Point(403, 112);
            this.txtMAMAYBAY.Name = "txtMAMAYBAY";
            this.txtMAMAYBAY.Size = new System.Drawing.Size(209, 22);
            this.txtMAMAYBAY.TabIndex = 44;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(861, 332);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(192, 34);
            this.btnTHOAT.TabIndex = 41;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(861, 275);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(192, 40);
            this.btnXOA.TabIndex = 40;
            this.btnXOA.Text = "XÓA DỮ LIỆU";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUA.Location = new System.Drawing.Point(861, 219);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(192, 41);
            this.btnSUA.TabIndex = 39;
            this.btnSUA.Text = "SỬA DỮ LIỆU";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLUU.Location = new System.Drawing.Point(861, 172);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(192, 39);
            this.btnLUU.TabIndex = 38;
            this.btnLUU.Text = "LƯU DỮ LIỆU";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // btnTAOMOI
            // 
            this.btnTAOMOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAOMOI.Location = new System.Drawing.Point(861, 112);
            this.btnTAOMOI.Name = "btnTAOMOI";
            this.btnTAOMOI.Size = new System.Drawing.Size(192, 43);
            this.btnTAOMOI.TabIndex = 37;
            this.btnTAOMOI.Text = "TẠO MỚI";
            this.btnTAOMOI.UseVisualStyleBackColor = true;
            this.btnTAOMOI.Click += new System.EventHandler(this.btnTAOMOI_Click);
            // 
            // FrmMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 503);
            this.Controls.Add(this.Data_MAYBAY);
            this.Controls.Add(this.lblTIEUDE);
            this.Controls.Add(this.lblSOGHE);
            this.Controls.Add(this.lblMAMAYBAY);
            this.Controls.Add(this.lblHANGHANGKHONG);
            this.Controls.Add(this.txtSOGHE);
            this.Controls.Add(this.txtHANGHANGKHONG);
            this.Controls.Add(this.txtMAMAYBAY);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnTAOMOI);
            this.Name = "FrmMayBay";
            this.Text = "FrmMayBay";
            this.Load += new System.EventHandler(this.FrmMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_MAYBAY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Data_MAYBAY;
        private System.Windows.Forms.Label lblTIEUDE;
        private System.Windows.Forms.Label lblSOGHE;
        private System.Windows.Forms.Label lblMAMAYBAY;
        private System.Windows.Forms.Label lblHANGHANGKHONG;
        private System.Windows.Forms.TextBox txtSOGHE;
        private System.Windows.Forms.TextBox txtHANGHANGKHONG;
        private System.Windows.Forms.TextBox txtMAMAYBAY;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnTAOMOI;
    }
}
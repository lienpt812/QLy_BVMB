namespace QLy_BVMB
{
    partial class FrmDangNhap
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
            this.txtMATKHAU = new System.Windows.Forms.TextBox();
            this.txtDANGNHAP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnDANGNHAP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMATKHAU.Location = new System.Drawing.Point(380, 269);
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.PasswordChar = '*';
            this.txtMATKHAU.Size = new System.Drawing.Size(593, 39);
            this.txtMATKHAU.TabIndex = 13;
            // 
            // txtDANGNHAP
            // 
            this.txtDANGNHAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDANGNHAP.Location = new System.Drawing.Point(380, 124);
            this.txtDANGNHAP.Name = "txtDANGNHAP";
            this.txtDANGNHAP.Size = new System.Drawing.Size(593, 39);
            this.txtDANGNHAP.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đăng nhập: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(708, 390);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(265, 68);
            this.btnEXIT.TabIndex = 8;
            this.btnEXIT.Text = "THOÁT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnDANGNHAP
            // 
            this.btnDANGNHAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDANGNHAP.Location = new System.Drawing.Point(380, 390);
            this.btnDANGNHAP.Name = "btnDANGNHAP";
            this.btnDANGNHAP.Size = new System.Drawing.Size(275, 68);
            this.btnDANGNHAP.TabIndex = 7;
            this.btnDANGNHAP.Text = "ĐĂNG NHẬP";
            this.btnDANGNHAP.UseVisualStyleBackColor = true;
            this.btnDANGNHAP.Click += new System.EventHandler(this.btnDANGNHAP_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 784);
            this.Controls.Add(this.txtMATKHAU);
            this.Controls.Add(this.txtDANGNHAP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnDANGNHAP);
            this.Name = "FrmDangNhap";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMATKHAU;
        private System.Windows.Forms.TextBox txtDANGNHAP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnDANGNHAP;
    }
}


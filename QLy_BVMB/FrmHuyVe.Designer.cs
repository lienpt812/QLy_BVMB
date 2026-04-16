namespace QLy_BVMB
{
    partial class FrmHuyVe
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
            this.dgvHuyVe = new System.Windows.Forms.DataGridView();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.btnHuyVe = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuyVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHuyVe
            // 
            this.dgvHuyVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuyVe.Location = new System.Drawing.Point(105, 297);
            this.dgvHuyVe.Name = "dgvHuyVe";
            this.dgvHuyVe.RowHeadersWidth = 62;
            this.dgvHuyVe.RowTemplate.Height = 28;
            this.dgvHuyVe.Size = new System.Drawing.Size(684, 290);
            this.dgvHuyVe.TabIndex = 65;
            // 
            // txtMaVe
            // 
            this.txtMaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVe.Location = new System.Drawing.Point(333, 187);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(446, 35);
            this.txtMaVe.TabIndex = 64;
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyVe.Location = new System.Drawing.Point(871, 193);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(154, 49);
            this.btnHuyVe.TabIndex = 61;
            this.btnHuyVe.Text = "Huỷ vé";
            this.btnHuyVe.UseVisualStyleBackColor = true;
            this.btnHuyVe.Click += new System.EventHandler(this.btnHuyVe_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(871, 283);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(154, 49);
            this.btnTHOAT.TabIndex = 60;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "MÃ VÉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 55);
            this.label1.TabIndex = 56;
            this.label1.Text = "HUỶ VÉ";
            // 
            // FrmHuyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 832);
            this.Controls.Add(this.dgvHuyVe);
            this.Controls.Add(this.txtMaVe);
            this.Controls.Add(this.btnHuyVe);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmHuyVe";
            this.Text = "FrmHuyVe";
            this.Load += new System.EventHandler(this.FrmHuyVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuyVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHuyVe;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Button btnHuyVe;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
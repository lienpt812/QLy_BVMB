using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLy_BVMB
{
    public partial class FrmBanVe : Form
    {
        public FrmBanVe()
        {
      //      InitializeComponent();
        }

        private void FrmBanVe_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmBanVe
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "FrmBanVe";
            this.Load += new System.EventHandler(this.FrmBanVe_Load_1);
            this.ResumeLayout(false);

        }

        private void FrmBanVe_Load_1(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSI
{
    public partial class frmPrincipal1 : Form
    {
        public frmPrincipal1()
        {
            InitializeComponent();
        }

        private void frmPrincipal1_Load(object sender, EventArgs e)
        {
            this.frmPrincipal1_ResizeEnd(null,null);
        }

        private void frmPrincipal1_ResizeEnd(object sender, EventArgs e)
        {

            pbLogo.Top = this.Size.Height - 110;
            pbLogo.Left = this.Size.Width - 90;

            lbLogo.Top = this.Size.Height - 60;
            lbLogo.Left = this.Size.Width - 210;

            
        }

        private void tipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoUsuario frm = new frmTipoUsuario();
                    frm.Show();
        }


   
    }
}

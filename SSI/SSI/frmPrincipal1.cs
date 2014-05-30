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
            ConexionSQL CSQL = new ConexionSQL(); //instanciar clase conexion
            CSQL.CONECTAR();
            if (CSQL.txEstadoCnx)
            {
                frmTipoUsuario frmTUsuario = new frmTipoUsuario();
                frmTUsuario.MdiParent = this;
                frmTUsuario.Show();
            }
            else
            {
                MessageBox.Show("No se puede conectar a la Base de datos\r\nVerifique conexión al servidor");
            }
        }

 
  
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConexionSQL CSQL = new ConexionSQL(); //instanciar clase conexion
            CSQL.CONECTAR();
            if (CSQL.txEstadoCnx)
            {
                frmRoles frmRoles = new frmRoles();
                frmRoles.MdiParent = this;
                frmRoles.Show();
            }
            else
            {
                MessageBox.Show("No se puede conectar a la Base de datos\r\nVerifique conexión al servidor");
            }
        }


   
    }
}

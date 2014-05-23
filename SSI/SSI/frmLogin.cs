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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

    
        private void btIngreso_Click(object sender, EventArgs e)
        {

   /*--------------------------------------------
   Nombre:         Acceder
   Autor:          Jaime Pérez
   fecha:          17may2014
   Detalle:        Verificar usuario y contraseña
   Modificación:   implementación inicial
  
   --------------------------------------*/

            
            
            ConexionSQL CSQL = new ConexionSQL(); //instanciar clase conexion

            CSQL.CONECTAR();
            if (CSQL.txEstadoCnx== true) {
            lbConex.Text = "Conexión establecida";

            string stSQL = "SELECT COUNT( idUsuario ) AS nmUsr "
                + "FROM  `tmausuario` "
                + "GROUP BY  `txUsuario` ,  `txContrasena` "
                + "having  `txUsuario` =  '" + tbUsuario.Text.ToString() + "' AND  `txContrasena` =  PASSWORD('" + tbPassword.Text.ToString() + "') "; //string de consulta";


                CSQL.mostrar(stSQL); //enviar consulta a clase común

                if (CSQL.ds.Tables[0].Rows.Count != 0)
                {
                 //   MessageBox.Show(stSQL + "\r\n" + CSQL.ds.Tables[0].Rows[0].ToString()); //.ToString()); //llenar datagrid

                   
                    frmPrincipal1 frm = new frmPrincipal1();
                    this.Hide();  
                    frm.Show();
                  
                }
                else
                {
                    MessageBox.Show("Usuario y contraseña inválidas \r\nNo se ha podido autenticar");
                }


            }


            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          this.tbUsuario.Focus();
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            this.tbUsuario.Focus();
        }



    
       
    }
}

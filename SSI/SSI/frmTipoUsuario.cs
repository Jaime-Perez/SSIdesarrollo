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
    public partial class frmTipoUsuario : Form
    {
        public frmTipoUsuario()
        {
            InitializeComponent();
        }

        private void frmTipoUsuario_Load(object sender, EventArgs e)
        {

     /*--------------------------------------------
     Nombre:         Redimensionador
     Autor:          Jaime Pérez
     fecha:          19may2014
     Detalle:        permite alinear el logo en la esquina inferior derecha 
     Modificación:   implementación inicial
  
     --------------------------------------*/

            pbLogo.Top = this.Size.Height - 110;
            pbLogo.Left = this.Size.Width - 90;

            lbLogo.Top = this.Size.Height - 60;
            lbLogo.Left = this.Size.Width - 210;


            /*--------------------------------------------
                 Nombre:         Llenar grid
                 Autor:          Jaime Pérez
                 fecha:          19may2014
                 Detalle:        permite llenar grid con clase común 
                 Modificación:   implementación inicial
  
                 --------------------------------------*/

            string stSQL = "SELECT * FROM  tmatipousuario"; //string de consulta

            ConexionSQL CSQL = new ConexionSQL(); //instanciar clase conexion

            CSQL.CONECTAR(); //verifica conexión

            CSQL.mostrar(stSQL); //enviar consulta a clase común
            dgForma.DataSource = CSQL.ds.Tables[0]; //llenar datagrid
            /*
            this.ta_Consola_SQL.SelectedIndex = 2;  //cambiar pestaña JP
            this.lbTituloTabla.Text = "Contenido de tabla " + lt_Multi_funcion.Text; //colocar nombre de tabla en título JP
            this.dgTabla.AutoResizeColumns(); //ajusta tamaño adecuado de columna para lectura
            */
        }

        private void dgForma_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("Aquí va"); 
        }

       
    }
}

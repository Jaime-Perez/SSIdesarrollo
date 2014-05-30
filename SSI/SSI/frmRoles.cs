using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SSI
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        ConexionSQL CSQL = new ConexionSQL(); //instanciar clase conexion
        private void frmRoles_Load(object sender, EventArgs e)
        {

     /*--------------------------------------------
     Nombre:         Bloquear controles default
     Autor:          Jaime Pérez
     fecha:          26may2014
     Detalle:        Bloquea los controles hasta la intervención del usuario 
     Modificación:   implementación inicial
  
     --------------------------------------*/

            tbCodigo.Enabled = false;
            tbDescrip.Enabled = false;
            btAceptar.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnnuevo.Enabled = true;
            btnbuscar.Enabled = true;
            btnguardar.Enabled = false;
            cbRol.Enabled = false;

    
     /*--------------------------------------------
     Nombre:         Llenar elementos
     Autor:          Jaime Pérez
     fecha:          19may2014
     Detalle:        permite llenar grid y combobox con clase común 
     Modificación:   implementación inicial
  
     --------------------------------------*/

            string stSQL = "SELECT a.idTipoUsuario as ID, a.txTipoUsuario as Descripcion, b.txRol as Rol " +
                           " FROM  tmatipousuario a, tmarol b where a.idRol = b.idRol"; //string de consulta grid

            try
            {
            

            CSQL.CONECTAR(); //verifica conexión

            if (CSQL.txEstadoCnx)
            {
                CSQL.mostrar(stSQL); //enviar consulta a clase común
                dgForma.DataSource = CSQL.ds.Tables[0]; //llenar datagrid




                //--------COMBO BOX
                stSQL = "SELECT idRol, txRol FROM tmarol;"; //string de consulta grid
                CSQL.mostrar(stSQL);
                cbRol.DataSource = CSQL.ds.Tables[0]; //llenar combobox
                cbRol.ValueMember = "idRol";
                cbRol.DisplayMember = "txRol";
                cbRol.SelectedValue = -1;
            }
            else
                 {
                MessageBox.Show("No se puede conectar a la Base de Datos");
                frmRoles.ActiveForm.Close();
                 }
            }
            catch (MySqlException ex)
            {
             //   MessageBox.Show("No es posible conectarse al sistema\r\n Error: " + ex.Message);
            this.Close();
            }

            this.dgForma.AutoResizeColumns( ); //coloca el tamaño adecuado para lectura
            this.dgForma.AutoResizeColumnHeadersHeight();
        }

  
        public void fnMuestra()
        {
            /*--------------------------------------------
             Nombre:         Seleccionar elementos
             Autor:          Jaime Pérez
             fecha:          26may2014
             Detalle:        permite mostrar los elementos a utilizar según la acción del usuario 
             Modificación:   implementación inicial
  
             --------------------------------------*/
            //MOSTRAR CAMPOS BÁSICOS
            tbDescrip.Enabled = true;
            cbRol.Enabled = true;
            btAceptar.Enabled = true;

       switch (Convert.ToInt32(tbTipo.Text))
        {
            case 1:  // NUEVO

                btnnuevo.Enabled = false;
                btnguardar.Enabled = true;
                btnbuscar.Enabled = false;

                break;
            case 2: //buscar
                tbCodigo.Enabled = true;
                btnguardar.Enabled = true;
                btnnuevo.Enabled = false;
                break;

            case 3: //editar
                tbCodigo.Enabled = false;
                btnguardar.Enabled = true;
                btnnuevo.Enabled = false;
                btnbuscar.Enabled = false;

                tbDescrip.Focus();
                break;

            default:
                Console.WriteLine("Default case");
                break;
        }
      

        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            tbTipo.Text = "1"; 
            fnMuestra();
            tbDescrip.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stSQLins="";

            switch (Convert.ToInt32(tbTipo.Text))
            {
                case 1:  // NUEVO

                    stSQLins = "insert into tmatipousuario(txTipoUsuario, idRol) values('" + tbDescrip.Text + "', " + cbRol.SelectedValue + ")";
                    //MessageBox.Show(stSQLins);
                    frmRoles_Load(null, null);
                    CSQL.mostrar(stSQLins);
                    break;

                case 2: //buscar
                    stSQLins = "SELECT a.idTipoUsuario as ID, a.txTipoUsuario as Descripcion, b.txRol as Rol " +
                           " FROM  tmatipousuario a, tmarol b where a.idRol = b.idRol"; //string de consulta grid

                    if (tbCodigo.Text != "" && tbCodigo.Text != " ")
                    {

                        if (CSQL.EsEntero(tbCodigo.Text))
                        {

                            stSQLins = stSQLins + " and idTipoUsuario = " + Convert.ToInt32(tbCodigo.Text);
                        }
                        else
                        {
                            MessageBox.Show("Código Inválido, verifique datos");
                            tbCodigo.Focus();
                            return;
                        }
                    }

                    if (tbDescrip.Text != "" && tbDescrip.Text != " ")
                    {
                        stSQLins = stSQLins + " and txTipoUsuario like '%" + tbDescrip.Text + "%'";
                    }

                    if (cbRol.IsAccessible)
                        stSQLins = stSQLins + " and idRol = " + Convert.ToInt32(cbRol.SelectedValue);

                    MessageBox.Show(stSQLins);
                    
                    if (CSQL.txEstadoCnx) //VERIFICA CONEXIÓN
                    {
                        CSQL.mostrar(stSQLins); //enviar consulta a clase común
                        dgForma.DataSource = CSQL.ds.Tables[0]; //llenar datagrid

                    }
                    else
                    {
                        MessageBox.Show("No se puede conectar a la Base de Datos");
                     
                    }

                    
                    break;

                case 3: //editar
                    cbRol.Select();
                    stSQLins = "update tmatipousuario set txTipoUsuario= '" + tbDescrip.Text + 
                                "', idRol= (select idRol from tmarol where txRol ='" +cbRol.SelectedText + "') where idTipoUsuario=" +
                                Convert.ToInt32( tbCodigo.Text);// cbRol.SelectedValue ;
                  
                    MessageBox.Show(stSQLins);

                    CSQL.CONECTAR();
                    if (CSQL.txEstadoCnx) //VERIFICA CONEXIÓN
                    {
                        CSQL.mostrar(stSQLins); //enviar consulta a clase común
                        tbTipo.Text = "";
                        tbCodigo.Text = "";
                        tbDescrip.Text = "";
                        frmRoles_Load(null,null);
                    }
                    else
                    {
                        MessageBox.Show("No se puede conectar a la Base de Datos");

                    }


                    break;
                default:
                    Console.WriteLine("Operación no admitida");
                    break;
            }
            
            
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            frmRoles_Load(null, null);
            // this.Close();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            tbTipo.Text = "3"; //editar
            fnMuestra();
            tbCodigo.Focus();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            tbTipo.Text = "2"; //buscar
            fnMuestra();
            tbCodigo.Focus();
        }

        private void frmRoles_ResizeEnd(object sender, EventArgs e)
        {
    /*--------------------------------------------
    Nombre:         Redimensionador
    Autor:          Jaime Pérez
    fecha:          19may2014
    Detalle:        permite alinear el logo en la esquina inferior derecha 
    Modificación:   implementación inicial
  
    --------------------------------------*/

            pbLogo.Top = this.Size.Height - 70;
            pbLogo.Left = this.Size.Width - 90;

            lbLogo.Top = this.Size.Height - 50;
            lbLogo.Left = this.Size.Width - 210;
        }

        private void dgForma_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbCodigo.Text = dgForma.CurrentRow.Cells[0].Value.ToString();
            tbDescrip.Text = dgForma.CurrentRow.Cells[1].Value.ToString();
            //cbRol.SelectedValue = dgForma.CurrentRow.Cells[2].Value;
            cbRol.Text = "";
            cbRol.SelectedText = dgForma.CurrentRow.Cells[2].Value.ToString();

            tbTipo.Text = "3";
            fnMuestra();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }



       
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace SSI
{
    public class ConexionSQL
    {
        public MySqlConnection conectarSQL = new MySqlConnection();
        
        public DataSet ds;  //JP
        public String txConexGlobal = "Server=localhost;Database=educassi;Uid=EducativoAdmin;Pwd=Educ4583+;Port=3306";  //JP
        public MySqlConnection cnn;  //JP
        public Boolean txEstadoCnx = false;


  /*--------------------------------------------
   Nombre:         Mostrar
   Autor:          Jaime Pérez
   fecha:          16may2014
   Detalle:        Permite gestionar la conexión en la BD
   Modificación:   implementación inicial
  
   --------------------------------------*/

        public void CONECTAR() { 
        
        try
            {
                //connectionString = "Server=" + HO + "; Database="+BD+";Uid=" + US + "; Pwd=" + CO + "";
                conectarSQL.ConnectionString = txConexGlobal;
                conectarSQL.Open();
                txEstadoCnx = true;
                cnn = new MySqlConnection(txConexGlobal);
            }
           
        catch (MySqlException ex)
        {
           MessageBox.Show("No es posible conectarse al sistema\r\n Error: " +ex.Message);
        }
        }






        /*--------------------------------------------
           Nombre:         Mostrar
           Autor:          Jaime Pérez
           fecha:          18ago2013
           Detalle:        Permite gestionar la conexión en la BD
           Modificación:   implementación inicial
            * 
           --------------------------------------*/

        public void mostrar(string sql) //version2
        {
            cnn = new MySqlConnection(txConexGlobal);
            try
            {
                //cnn = new MySqlConnection(cnx);
                cnn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cnn);
                ds = new DataSet();
                da.Fill(ds);
                cnn.Close();
            }
            catch (MySqlException Msq)
            {
                MessageBox.Show("Error de Base de datos\n" + Msq.ErrorCode.ToString() + "\n" + Msq.Message, "Error de SQL");
                Application.Exit();
            }
        }
    }

     

}

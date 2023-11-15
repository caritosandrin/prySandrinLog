using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace prySandrinLog
{
    internal class ClsAccesoBD
    {
        public string EstadoConexion;
        public string Errores;
        public string DatosExtraidos;
        OleDbConnection conexionBD;
        public string rutaArchivo;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorDS;
        DataSet objDataSet = new DataSet();

        public void ConectarBaseDatos()
        {
            try
            {
                if (rutaArchivo == null)
                {
                    rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ../../Base/LOG.accdb";
                }
                else
                {
                    rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + rutaArchivo;
                }

                conexionBD = new OleDbConnection();

                conexionBD.ConnectionString = rutaArchivo;

                conexionBD.Open();

                EstadoConexion = "Conectado a la base " + conexionBD.DataSource;
            }
            catch (Exception exepcion)
            {
                EstadoConexion = "Error en la conexión." + exepcion.Message;
            }

        }

        public void TraerDatos(DataGridView grilla)
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Registros";

                lectorBD = comandoBD.ExecuteReader();
                grilla.Columns.Add("ID", "ID");
                grilla.Columns.Add("Categoría", "Categoría");
                grilla.Columns.Add("Fecha/Hora", "Fecha/Hora");
                grilla.Columns.Add("Descripción", "Descripción");

                while (lectorBD.Read())
                {
                    //DatosExtraidos += lectorBD[7] + "\n";
                    grilla.Rows.Add(lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4]);

                }
            }
            catch (Exception ex)
            {
                Errores = ex.Message;
            }

        }
        public void TraerDatosDataSet(DataGridView grilla)
        {
            try
            {
                //conectamos a la base//
                ConectarBaseDatos();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Registros";

                //crea en la memoria el adaptador//
                adaptadorDS = new OleDbDataAdapter(comandoBD);//con lo que el comando indique//
                //el adaptador rellena el DataSet//
                adaptadorDS.Fill(objDataSet, "Registros");


                //sirve el if para preguntar si tiene datos//
                if (objDataSet.Tables["Registros"].Rows.Count > 0)
                {
                    grilla.Columns.Add("ID", "ID");
                    grilla.Columns.Add("Categoría", "Categoría");
                    grilla.Columns.Add("Fecha y Hora", "Fecha y Hora");
                    grilla.Columns.Add("Descripción", "Descripción");


                    //para cada fila de la tabla Registros hacer...//
                    foreach (DataRow fila in objDataSet.Tables[0].Rows)
                    {
                        //DatosExtraidos += fila[1] + "\n";// //....grabar lo que está en la fila 0 de la columna0//

                        grilla.Rows.Add(fila[0], fila[1], fila[2], fila[3]);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }



        }
        public void RegistrarDatosDataSet(string ID)
        {
            try
            {
                //conectamos a la base//
                ConectarBaseDatos();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Registros";

                //crea en la memoria el adaptador//
                adaptadorDS = new OleDbDataAdapter(comandoBD);//con lo que el comando indique//
                //el adaptador rellena el DataSet//
                adaptadorDS.Fill(objDataSet, "Registros");

                //carga y graba todo lo que trae el dataset de  Registros//
                DataTable TablaGrabar = objDataSet.Tables["Registros"];

                //Crea una nueva fila con todos los campos//
                DataRow filaGrabar = TablaGrabar.NewRow();

                //graba en cada caracter como si fuera caja de texto//
                filaGrabar[1] = ID;


                //en la tabla agrega el nuevo registro//
                TablaGrabar.Rows.Add(filaGrabar);


                //se crea un constructor para que pase a la base de datos//  
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorDS);

                //actualiza el DataSet con la nueva informacion//
                adaptadorDS.Update(objDataSet);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}





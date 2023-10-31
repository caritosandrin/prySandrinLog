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
                    rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ../../Base/Log.accdb";
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
                comandoBD.CommandText = "SOCIOS";

                lectorBD = comandoBD.ExecuteReader();

                grilla.Columns.Add("Nombre", "Nombre");
                grilla.Columns.Add("Apellido", "Apellido");
                grilla.Columns.Add("Puntaje", "Puntaje");

                while (lectorBD.Read())
                {
                    //DatosExtraidos += lectorBD[7] + "\n";
                    grilla.Rows.Add(lectorBD[1], lectorBD[2], lectorBD[7]);

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
                ConectarBaseDatos();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Log";

                adaptadorDS = new OleDbDataAdapter(comandoBD);
                adaptadorDS.Fill(objDataSet, "Log");

                if (objDataSet.Tables["Log"].Rows.Count > 0)
                {
                    grilla.Columns.Add("ID", "ID");
                    grilla.Columns.Add("Categoria", "Categoria");
                    grilla.Columns.Add("Fecha Hora", "Fecha Hora");
                    grilla.Columns.Add("Descripcion", "Descripcion");

                    foreach (DataRow fila in objDataSet.Tables[0].Rows)
                    {
                        //DatosExtraidos += fila[1] + "\n";

                        grilla.Rows.Add(fila[0], fila[1], fila[2]);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


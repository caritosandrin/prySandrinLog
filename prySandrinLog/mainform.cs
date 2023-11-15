using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prySandrinLog
{
    public partial class mainform : Form
    {
        ClsAccesoBD ObjAccesoBd = new ClsAccesoBD();

        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjAccesoBd.ConectarBaseDatos();
            lblEstadoConexion.Text = ObjAccesoBd.EstadoConexion;

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ObjAccesoBd.TraerDatos(DataGridViewLOG);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ObjAccesoBd.TraerDatosDataSet(DataGridViewLOG);

            //si la caja de texto es distinta de ID, entonces lo ingreso//
            if (txtID.Text != "")
            {
                ObjAccesoBd.RegistrarDatosDataSet(txtID.Text);
            }
        }

        private void DataGridViewLOG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }


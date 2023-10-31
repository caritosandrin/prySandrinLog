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
    public partial class Form1 : Form
    {
        ClsAccesoBD ObjAccesoBd = new ClsAccesoBD();

        public Form1()
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
            
        }
    }
    }


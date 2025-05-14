using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionStock.Datos;

namespace GestionStock.Presentacion
{
    public partial class FrmConectar : Form
    {
        public FrmConectar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();

            SqlCon = Conexion.crearInstancia().CrearConexion();

            try
            {
                SqlCon.Open();
                MessageBox.Show("Conectado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar");
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionStock.Datos;
using GestionStock.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionStock.Presentacion
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private CancellationTokenSource cts;

        #region "Variables"

        int iCodigoEmpleado = 0;

        bool bEstadoGuardar = true;

        #endregion


        #region "Métodos"

        private void CargarEmpleados(string cBusqueda)
        {
            D_Empleados Datos = new D_Empleados();
            DataTable dtEmpleados = Datos.Listar_Empleados(cBusqueda);


            var colCodigo = (DataGridViewComboBoxColumn)dataGridView1.Columns["Código"];
            colCodigo.DataSource = dtEmpleados;
            colCodigo.DisplayMember = "Código";
            colCodigo.ValueMember = "Código";
            dataGridView1.Refresh();
        }




        /* private void Limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Value = 0;
            txtTelefono.Clear();
            txtSalario.Clear();
            txtBuscar.Clear();

            cmbDepartamento.SelectedIndex = -1;
            cmbCargo.SelectedIndex = -1;

            dtpNacimiento.Value = DateTime.Now;

            iCodigoEmpleado = 0;
        }*/





        #endregion
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarEmpleados("%");

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bEstadoGuardar = true;

            /*Limpiar();*/
        }


        /*  private void btnGuardar_Click(object sender, EventArgs e)
          {
              if (ValidarTextos())
              {
                  MessageBox.Show("Hay campos vacíos, debes llenar todos los campos (*) obligatorios", "Sistema gestión de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }

              else
              {
                  if (bEstadoGuardar)
                  {
                      GuardarEmpleados();
                  }

                  else
                  {
                      ActualizarEmpleados();
                  }
              }
          }*/

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmEmpleados Empleados = new FrmEmpleados();
            Empleados.Show();
            this.Close();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            string colActual = dataGridView1.CurrentCell.OwningColumn.Name;
            int colNombre = dataGridView1.Columns[colActual].Index;

            if (colActual == "Código")
            {
                if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["Código"].Index)
                {

                    ComboBox comboBox = e.Control as ComboBox;

                    if (comboBox != null)
                    {
                        dataGridView1.Refresh();
                        comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                        comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

                        comboBox.SelectedIndex = -1;
                    }
                }

                if (dataGridView1.CurrentCell.OwningColumn.Name == "Cantidad")
                {

                    e.Control.KeyPress -= ValidarNum;

                    e.Control.KeyPress += ValidarNum;
                }
            }
        }

        private void ValidarNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var colNombre = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colNombre == "Código")
            {


                string input = dataGridView1.Rows[e.RowIndex].Cells["Código"].Value?.ToString();

                if (!string.IsNullOrEmpty(input))
                {
                    D_Empleados Datos = new D_Empleados();
                    DataTable datos = Datos.Listar_Empleados(input);

                    if (datos != null && datos.Rows.Count > 0)
                    {
                        DataRow row = datos.Rows[0];

                        
                        dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value = null;
                        dataGridView1.Rows[e.RowIndex].Cells["Marca"].Value = null;
                        dataGridView1.Rows[e.RowIndex].Cells["Tipo"].Value = null;
                        dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value = null;
                        dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value = null;

                        
                        dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value = row["Nombre"].ToString();
                        dataGridView1.Rows[e.RowIndex].Cells["Marca"].Value = row["Marca"].ToString();
                        dataGridView1.Rows[e.RowIndex].Cells["Tipo"].Value = row["Tipo"].ToString();
                        dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value = "1";
                        dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value = row["Precio"].ToString();


                    }
                }
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {

        }
    }
}

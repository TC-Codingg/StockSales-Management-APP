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

namespace GestionStock.Presentacion
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
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

            dgvLista.DataSource = Datos.Listar_Empleados(cBusqueda);

            FormatoListaEmpleados();

            int count = 0;

            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                if (int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out int cantidad) && int.TryParse(row.Cells["Min"].Value?.ToString(), out int min)){
                    if (cantidad <= min)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        count++;
                    }
                }
            }
            labelAdvertencia.Text = count.ToString();
        }

        private void FormatoListaEmpleados()
        {
            dgvLista.Columns[0].Width = 45;
            dgvLista.Columns[1].Width = 120;
            dgvLista.Columns[2].Width = 160;
            dgvLista.Columns[4].Width = 160;
            dgvLista.Columns[5].Width = 90;
            dgvLista.Columns[6].Width = 160;
            dgvLista.Columns[8].Width = 50;
            dgvLista.Columns[9].Width = 50;
        }

        private void CargarDepartamentos()
        {
            D_Departamentos Datos = new D_Departamentos();
            cmbDepartamento.DataSource = Datos.Listar_Departamentos();
            cmbDepartamento.ValueMember = "id_departamento";
            cmbDepartamento.DisplayMember = "nombre_departamento";
            cmbDepartamento.SelectedIndex = -1;
        }

        private void CargarCargos()
        {
            D_Cargos Datos = new D_Cargos();
            cmbCargo.DataSource = Datos.Listar_Cargos();
            cmbCargo.ValueMember = "id";
            cmbCargo.DisplayMember = "nombre_cargo";
            cmbCargo.SelectedIndex = -1;
        }

        private void ActivarTextos(bool bEstado)
        {
            txtNombre.Enabled = bEstado;
            txtDireccion.Enabled = bEstado;
            stockMin.Enabled = bEstado;
            stockMax.Enabled = bEstado;
            txtTelefono.Enabled = bEstado;
            txtSalario.Enabled = bEstado;

            txtPrecioLista.Enabled = bEstado;
            numGanancia.Enabled = bEstado;


            cmbDepartamento.Enabled = bEstado;
            cmbCargo.Enabled = bEstado;

            dtpNacimiento.Enabled = bEstado;

            txtBuscar.Enabled = !bEstado;
        }

        private void ActivarBotones(bool bEstado)
        {
            btnNuevo.Enabled = bEstado;
            btnActualizar.Enabled = bEstado;
            btnEliminar.Enabled = bEstado;

            btnGuardar.Visible = !bEstado;
            btnCancelar.Visible = !bEstado;

        }

        private void SeleccionarEmpleado()
        {
            iCodigoEmpleado = Convert.ToInt32(dgvLista.CurrentRow.Cells["ID"].Value);

            txtNombre.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Nombre"].Value);
            txtDireccion.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Cantidad"].Value);
            txtTelefono.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Código"].Value);
            txtSalario.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Precio"].Value);

            cmbDepartamento.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Marca"].Value);
            cmbCargo.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Tipo"].Value);

            dtpNacimiento.Value = Convert.ToDateTime(dgvLista.CurrentRow.Cells["Fecha Ingreso"].Value);
        }

        private void Limpiar()
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
        }

        private void GuardarEmpleados()
        {
            E_Empleado Empleado = new E_Empleado();

            Empleado.Nombre_Empleado = txtNombre.Text;
            Empleado.Cantidad = txtDireccion.Text;
            Empleado.Telefono_Empleado = txtTelefono.Text;
            Empleado.Salario_Empleado = Convert.ToDecimal(txtSalario.Text);
            Empleado.Fecha_Nacimiento_Empleado = dtpNacimiento.Value;
            Empleado.ID_Departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
            Empleado.ID_Cargo = Convert.ToInt32(cmbCargo.SelectedValue);
            Empleado.stockMin = Convert.ToInt32(stockMin.Value);
            Empleado.stockMax = Convert.ToInt32(stockMax.Value);

            D_Empleados Datos = new D_Empleados();
            string respuesta = Datos.Guardar_Empleado(Empleado);

            if (respuesta == "OK")
            {
                CargarEmpleados("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);

                MessageBox.Show("Datos guardados correctamente", "Sistema gestión de stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show(respuesta, "Sistema gestión de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEmpleados()
        {
            E_Empleado Empleado = new E_Empleado();

            Empleado.ID_Empleado = iCodigoEmpleado;
            Empleado.Nombre_Empleado = txtNombre.Text;
            Empleado.Cantidad = txtDireccion.Text;
            Empleado.Telefono_Empleado = txtTelefono.Text;
            Empleado.Salario_Empleado = Convert.ToDecimal(txtSalario.Text);
            Empleado.Fecha_Nacimiento_Empleado = dtpNacimiento.Value;
            Empleado.ID_Departamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
            Empleado.ID_Cargo = Convert.ToInt32(cmbCargo.SelectedValue);
            Empleado.stockMin = Convert.ToInt32(stockMin.Value);
            Empleado.stockMax = Convert.ToInt32(stockMax.Value);

            D_Empleados Datos = new D_Empleados();
            string respuesta = Datos.Actualizar_Empleado(Empleado);

            if (respuesta == "OK")
            {
                CargarEmpleados("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);

                MessageBox.Show("Datos actualizados correctamente", "Sistema gestión de stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show(respuesta, "Sistema gestión de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DesactivarEmpleados(int iCodigoEmpleado)
        {
            D_Empleados Datos = new D_Empleados();
            string respuesta = Datos.Desactivar_Empleado(iCodigoEmpleado);

            if (respuesta == "OK")
            {
                CargarEmpleados("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);

                MessageBox.Show("Registro eliminado correctamente", "Sistema gestión de stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show(respuesta, "Sistema gestión de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidarTextos()
        {
            bool hayTextosVacios = false;

            if (string.IsNullOrEmpty(txtNombre.Text)) hayTextosVacios = true;
            if (string.IsNullOrEmpty(txtTelefono.Text)) hayTextosVacios = true;
            if (string.IsNullOrEmpty(txtSalario.Text)) hayTextosVacios = true;

            return hayTextosVacios;
        }

        private int CalcularGanancia()
        {
            int precioLista;
            int Ganancia = (int)numGanancia.Value;

            if (!int.TryParse(txtPrecioLista.Text, out precioLista))
                return 0;

            int precioVenta = precioLista + (precioLista * Ganancia / 100);

            return precioVenta;
        }


        #endregion 
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados("%");
            CargarDepartamentos();
            CargarCargos();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bEstadoGuardar = true;

            ActivarTextos(true);
            ActivarBotones(false);

            txtTelefono.Select();

            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bEstadoGuardar = true;

            ActivarTextos(false);
            ActivarBotones(true);

            Limpiar();
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarEmpleado();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (iCodigoEmpleado == 0)
            {
                MessageBox.Show("Selecciona un registro: ", "Sistema de gestión de empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                bEstadoGuardar = false;

                ActivarTextos(true);
                ActivarBotones(false);

                txtNombre.Select();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (iCodigoEmpleado == 0)
            {
                MessageBox.Show("Selecciona un registro: ", "Sistema de gestión de empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                DialogResult resultado = MessageBox.Show("Estás seguro de eliminar este registro?", "Sistema de gestión de stock",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DesactivarEmpleados(iCodigoEmpleado);
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPrecioLista_TextChanged(object sender, EventArgs e)
        {
            txtSalario.Text = Convert.ToString(CalcularGanancia());
        }

        private void numGanancia_ValueChanged(object sender, EventArgs e)
        {
            txtSalario.Text = Convert.ToString(CalcularGanancia());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas Ventas = new FrmVentas();
            Ventas.Show();
            this.Hide();
        }
    }
}
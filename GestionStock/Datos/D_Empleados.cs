using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.Entidades;

namespace GestionStock.Datos
{
    public class D_Empleados
    {
        public DataTable Listar_Empleados (string cBusqueda) {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.crearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_LISTAR_EMPLEADOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@cBusqueda", SqlDbType.VarChar).Value = cBusqueda;
                SqlCon.Open();

                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }

        public string Guardar_Empleado(E_Empleado Empleado)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.crearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_GUARDAR_EMPLEADOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = Empleado.Nombre_Empleado;
                comando.Parameters.Add("@cDireccion", SqlDbType.VarChar).Value = Empleado.Cantidad;
                comando.Parameters.Add("@dFechaNacimiento", SqlDbType.Date).Value = Empleado.Fecha_Nacimiento_Empleado;
                comando.Parameters.Add("@cTelefono", SqlDbType.VarChar).Value = Empleado.Telefono_Empleado;
                comando.Parameters.Add("@nSalario", SqlDbType.Money).Value = Empleado.Salario_Empleado;
                comando.Parameters.Add("@nIdDepartamento", SqlDbType.Int).Value = Empleado.ID_Departamento;
                comando.Parameters.Add("@nIdCargo", SqlDbType.Int).Value = Empleado.ID_Cargo;
                comando.Parameters.Add("@stockMin", SqlDbType.Int).Value = Empleado.stockMin;
                comando.Parameters.Add("@stockMax", SqlDbType.Int).Value = Empleado.stockMax;


                SqlCon.Open();

                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no se pudieron registrar";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

        public string Actualizar_Empleado(E_Empleado Empleado)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.crearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ACTUALIZAR_EMPLEADOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nIdEmpleado", SqlDbType.Int).Value = Empleado.ID_Empleado;
                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = Empleado.Nombre_Empleado;
                comando.Parameters.Add("@cDireccion", SqlDbType.VarChar).Value = Empleado.Cantidad;
                comando.Parameters.Add("@dFechaNacimiento", SqlDbType.Date).Value = Empleado.Fecha_Nacimiento_Empleado;
                comando.Parameters.Add("@cTelefono", SqlDbType.VarChar).Value = Empleado.Telefono_Empleado;
                comando.Parameters.Add("@nSalario", SqlDbType.Money).Value = Empleado.Salario_Empleado;
                comando.Parameters.Add("@nIdDepartamento", SqlDbType.Int).Value = Empleado.ID_Departamento;
                comando.Parameters.Add("@nIdCargo", SqlDbType.Int).Value = Empleado.ID_Cargo;
                comando.Parameters.Add("@stockMin", SqlDbType.Int).Value = Empleado.stockMin;
                comando.Parameters.Add("@stockMax", SqlDbType.Int).Value = Empleado.stockMax;

                SqlCon.Open();

                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no se pudieron registrar";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

        public string VenderProducto(string codigo, int cantidad)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.crearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_VENDER_PRODUCTO", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@cCodigo", SqlDbType.VarChar, 15).Value = codigo;
                comando.Parameters.Add("@iCantidad", SqlDbType.Int).Value = cantidad;

                SqlParameter resultado = new SqlParameter("@Resultado", SqlDbType.NVarChar, 100);
                resultado.Direction = ParameterDirection.Output;
                comando.Parameters.Add(resultado);

                SqlCon.Open();
                comando.ExecuteNonQuery();

                respuesta = resultado.Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }


        public string Desactivar_Empleado(int iCodigoEmpleado)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.crearInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_DESACTIVAR_EMPLEADOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nIdEmpleado", SqlDbType.Int).Value = iCodigoEmpleado;

                SqlCon.Open();

                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no se pudieron registrar";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }
    }
}

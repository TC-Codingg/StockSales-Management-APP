using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GestionStock.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;

        private static Conexion Con = null;

        private Conexion()
        {
            this.Servidor = "DESKTOP-V21QH4M";
            this.Base = "db_gestion_stock";
            this.Usuario = "stock";
            this.Clave = "1234";

        }

        /* public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor+ ",1433" +
                    "; Database="+ this.Base +
                    "; User Id="+this.Usuario +
                    "; Password="+this.Clave+
                    "; TrustServerCertificate=True";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }*/

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            try
            {
                Cadena.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=db_gestion_stock;Trusted_Connection=True"
;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion crearInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }

            return Con;
        }

    }
}

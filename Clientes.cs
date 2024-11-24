using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Clientes
    {
        public int NumeroDeCliente { get; set; }
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public string Correo {  get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNazi {  get; set; }
        ConectarBase ConectarBase = new ConectarBase();

        public void mostrar_clientes()
        {
            SqlConnection Conexion = new SqlConnection(ConectarBase.Conexion);
            SqlCommand cmd = new SqlCommand("SELECT ", Conexion);

        }
        
    }
}

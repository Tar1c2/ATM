using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Clientes
    {
        public int NumeroDeCliente { get; set; }
        public int ID {  get; set; }    
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public string Correo {  get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNazi {  get; set; }
        ConectarBase Conectar = new ConectarBase();

        public DataTable mostrar_clientes()
        {
            SqlConnection Conexion = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Info_Cliente ORDER BY Cliente_ID", Conexion);
            Conexion.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            Conexion.Close();
            if (tab.Rows.Count > 0)
                return tab;
            else
                return null;
        }
        public void cliente_alta(Clientes cliente)
        {
            SqlConnection Conexionalabase = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("INSERT INTO Info_Cliente(RFC,Nombre,Apellidos,Correo, Telefono, Direccion, Fecha_Nacimiento) VALUES( @rfc, @Nombre, @Apellido, @correo, @Telefono, @Direccion, @nacimiento) SELECT SCOPE_IDENTITY();", Conexionalabase);
            cmd.Parameters.AddWithValue("@rfc", cliente.RFC);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", cliente.Apellidos); 
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@correo", cliente.Correo);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@nacimiento",cliente.FechaNazi);
            Conexionalabase.Open();
            cmd.ExecuteNonQuery();
            
            Conexionalabase.Close();

        }
        public void Clientes_baja(Clientes cliente)
        {
            SqlConnection Conexionalabase = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("Delete From Info_Cliente WHERE Cliente_ID = @id", Conexionalabase);
            SqlCommand cmd2 = new SqlCommand("Delete From Info_Usuario WHERE Cliente_ID = @id");
            cmd.Parameters.AddWithValue("@id", cliente.ID);
            Conexionalabase.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            Conexionalabase.Close();
        }
    }
}

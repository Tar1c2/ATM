using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class CuentasDeAdministracion
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int AdminID { get; set; }
        public string Usuario { get; set; }
        public string NivelAdmin { get; set; } //Admin, Gerente, Cajero
        public string Contraseña { get; set; }

        ConectarBase Conectar = new ConectarBase();


        public CuentasDeAdministracion() { }


        public void Admin_Alta(CuentasDeAdministracion Admin) {
            SqlConnection Conexionalabase = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("INSERT INTO Acceso_Administrativo(Administrador_ID,Nombre,Apellido,Usuario, Password, Nivel_Autoridad) VALUES(@Aministrador_ID, @Nombre, @Apellido, @Usuario, @Password, @Nivel_Autoridad)", Conexionalabase);
            cmd.Parameters.AddWithValue("@Administrador_ID", Admin.AdminID);
            cmd.Parameters.AddWithValue("@Nombre", Admin.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Admin.Apellidos);
            cmd.Parameters.AddWithValue("@Usuario", Admin.Usuario);
            cmd.Parameters.AddWithValue("@Password", Admin.Contraseña);
            cmd.Parameters.AddWithValue("@Nivel_Autoridad", Admin.NivelAdmin);
            Conexionalabase.Open();
            cmd.ExecuteNonQuery();
            Conexionalabase.Close();

        }
        public void Gerente_Alta_Cliente(Clientes cliente){
            SqlConnection Conexionalabase = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("INSERT INTO Info_Clientes(Cliente_ID, RFC, Nombre,Apellido,Telefono, Correo, Direccion, Fecha_de_nacimiento) VALUES(@Cliente_ID,@RFC, @Nombre, @Apellido, @Telefono, @Correo, @Direccion,@Fecha_de_nacimiento)", Conexionalabase);
            cmd.Parameters.AddWithValue("@Cliente_ID", cliente.NumeroDeCliente);
            cmd.Parameters.AddWithValue("@RFC", cliente.RFC);            
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", cliente.Apellidos);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@Fecha_de_nacimiento", cliente.FechaNazi);
            Conexionalabase.Open();
            cmd.ExecuteNonQuery();
            Conexionalabase.Close();
        }
        public void Gerente_Asignar_Cuenta(Cuentas cuenta, Clientes cliente) {
            SqlConnection Conexionalabase = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("INSERT INTO Info_Usuarios(Cliente_ID, Usuario, Password, Saldo, Numero_De_Cuenta) VALUES(@Cliente_ID, @Usuario, @Password, @Saldo, @Numero_De_Cuenta)", Conexionalabase);
            cmd.Parameters.AddWithValue("@Cliente_ID", cliente.NumeroDeCliente);
            cmd.Parameters.AddWithValue("@Usuario", cuenta.Usuario);
            cmd.Parameters.AddWithValue("@Password", cuenta.Contraseña);
            cmd.Parameters.AddWithValue("@Saldo", cuenta.Saldo);
            cmd.Parameters.AddWithValue("@Numero_De_Cuenta", cuenta.NumeroDeCuenta);
            Conexionalabase.Open();
            cmd.ExecuteNonQuery();
            Conexionalabase.Close();
        }
             

    }
}

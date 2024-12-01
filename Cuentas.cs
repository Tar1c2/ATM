using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Cuentas
    {
        public int NumeroDeCuenta { get; set; }
        public int NumeroDeCliente { get; set; }
        public double Saldo { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        ConectarBase Conectar = new ConectarBase();

        Random rand = new Random();
        public void ActualizacionSaldo(Cuentas cuenta, string tipo, double monto)
        {
            if(tipo == "Cargo") { cuenta.Saldo = cuenta.Saldo - monto; }
            if(tipo == "Abono") { cuenta.Saldo = cuenta.Saldo + monto; }

            SqlConnection Conexionalabase = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("UPDATE Info_Usuarios SET Saldo = @Saldo,  WHERE  Numero_De_Cuenta = @NumeroDeCuenta", Conexionalabase);
            cmd.Parameters.AddWithValue("@Saldo", cuenta.Saldo);
            Conexionalabase.Open();
            cmd.ExecuteNonQuery();
            Conexionalabase.Close();
        }
        public void crear_cuenta(Cuentas cuenta, Clientes cliente)
        {
            numero_cuenta(cuenta);
            SqlConnection Conexionalabase = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("INSERT INTO Info_Usuarios(Cliente_ID,Usuario,Password,Saldo,Numero_cuenta) VALUES(@id,@usuario, @pass,@saldo,@cuenta)", Conexionalabase);
            cmd.Parameters.AddWithValue("@id", cliente.ID);
            cmd.Parameters.AddWithValue("@cuenta", cuenta.NumeroDeCuenta);
            cmd.Parameters.AddWithValue("@usuario", cuenta.Usuario);
            cmd.Parameters.AddWithValue("@pass", cuenta.Contraseña);
            cmd.Parameters.AddWithValue("@saldo",cuenta.Saldo);
            Conexionalabase.Open();
            cmd.ExecuteNonQuery();
            Conexionalabase.Close();
        }
        public int numero_cuenta(Cuentas cuenta)
        {
            NumeroDeCuenta = rand.Next(10000000);
            SqlConnection Conexionalabase = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Info_Usuarios WHERE MumeroCuenta = @cuenta",Conexionalabase);
            cmd.Parameters.AddWithValue("@cuenta", cuenta.NumeroDeCuenta);
            Conexionalabase.Open();
            cmd.ExecuteNonQuery(); 
            Conexionalabase.Close ();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return NumeroDeCuenta;
            }
            else
            {
                return numero_cuenta(cuenta);
            }
        }
    }
}

using System;
using System.Collections.Generic;
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
        
        
        
    }
}

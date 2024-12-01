using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    internal class Transacciones
    {
        public string Folio { get; set; }
        public int NumeroDeCuenta { get; set; }
        public int NumeroDeCliente { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }

        ConectarBase Conectar = new ConectarBase();

        public void Transaccion(Transacciones Trans, Cuentas cuenta, Clientes cliente)
        {
            SqlConnection Conexionalabase = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("INSERT INTO Transacciones(Folio,NumeroCuenta,NumeroCliente,TipoTransaccion,Fecha,Monto) VALUES(@Folio, @NumeroCuenta, @NumeroCliente, @TipoTransaccion, @Fecha,@Monto)", Conexionalabase);
            cmd.Parameters.AddWithValue("@Folio", Trans.Folio);
            cmd.Parameters.AddWithValue("@NumeroCuenta", cuenta.NumeroDeCuenta);
            cmd.Parameters.AddWithValue("@NumeroCliente", cliente.NumeroDeCliente);
            cmd.Parameters.AddWithValue("@TipoTransaccion", Trans.Tipo);
            cmd.Parameters.AddWithValue("@Fecha", Trans.Fecha);
            Conexionalabase.Open();
            cmd.ExecuteNonQuery();
            Conexionalabase.Close();
        }
        
    }
}

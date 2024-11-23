using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ATM
{
    internal class Transferencias
    {
        public string Folio { get; set; }
        public int CuentaDeOrigen { get; set; } //Número de cuenta
        public int CuentaDeDestino { get; set; }
        public DateTime FechaDeTransferencia { get; set; }
        public double Monto {  get; set; }

        ConectarBase Conectar = new ConectarBase();

        public void Traferir(Transferencias Tra, Transacciones Trans, Cuentas Origen, Cuentas Destino) {
            SqlConnection Conexionalabase = new SqlConnection(Conectar.Conexion);
            SqlCommand cmd = new SqlCommand("INSERT INTO Transferencia(Folio,CuentaOrigen,CuentaDestino,Fecha, Monto) VALUES(@Folio, @CuentaOrigen, @CuentaDestino, @Fecha, @Monto)", Conexionalabase);
            cmd.Parameters.AddWithValue("@Folio", Trans.Folio);
            cmd.Parameters.AddWithValue("@CuentaOrigen", Origen.NumeroDeCuenta);
            cmd.Parameters.AddWithValue("@CuentaDestino", Destino.NumeroDeCuenta);
            cmd.Parameters.AddWithValue("@Fecha", Tra.FechaDeTransferencia);
            cmd.Parameters.AddWithValue("@Monto", Tra.Monto);
            Conexionalabase.Open();
            cmd.ExecuteNonQuery();
            Conexionalabase.Close();

        }
        
    }
} 

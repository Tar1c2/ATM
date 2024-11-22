using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Transacciones
    {
        public string Folio { get; set; }
        public int NumeroDeCuenta { get; set; }
        public int NumeroDeCliente { get; set; }
        public string TipoDeTransaccion { get; set; }
        public DateTime FechaDeTransaccion { get; set; }
    }
}

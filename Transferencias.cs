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
        
    }
} 

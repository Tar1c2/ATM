using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class CuentasDeAdministracion
    {
        public string Propietario { get; set; }
        public int ID { get; set; }
        public string NivelAdmin { get; set; } //Admin, Gerente, Cajero
        public string Contraseña { get; set; }

        public void Admin_Alta() { }
        public void Gerente_Alta_Cliente(){ }
        public void Gerente_Crear_Cliente() { }
        public void Gerente_Asignar_Cuenta() { }
             

    }
}

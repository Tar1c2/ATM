using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form_Gerente : Form
    {

        ConectarBase conectarBase = new ConectarBase();

        public Form_Gerente()
        {
            InitializeComponent();
        }

        private void Asignar_Click(object sender, EventArgs e) { 
            
            int Cliente_ID = Convert.ToInt32(TBX_CL_ID.Text);
            string selec = "SELECT Cliente_ID FROM Info_Usuarios WHERE Cliente_ID = @Cliente_ID";
            SqlConnection conectando = new SqlConnection(conectarBase.Conexion);
            Cuentas cuenta = new Cuentas();
            conectando.Open();
            SqlCommand slc = new SqlCommand(selec, conectando);

            if (slc != null )  { 
                if(TBX_Contraseña_Cuenta.Text != null && TBX_Contraseña_Cuenta.Text != null) { 
                    CuentasDeAdministracion ger = new CuentasDeAdministracion();
                    cuenta.Contraseña = TBX_Contraseña_Cuenta.Text;
                    cuenta.Usuario = TBX_Usuario_Cuenta.Text;
                    ger.Gerente_Asignar_Cuenta(cuenta, Cliente_ID);
                    
                }
                else { MessageBox.Show("Falta llenar todos los campos", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("ID de usuario inexistente", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void Registrar_Click(Object sender, EventArgs e) {

            if (TBX_Nombre_Cliente.Text != null && TBX_Apellidos_Cliente.Text != null && TBX_RFC.Text != null
                && TBX_FechaNaci_Cliente.Text != null && TBX_Direccion_Cliente != null ) { 
                Clientes nuevo = new Clientes();
                CuentasDeAdministracion Ad = new CuentasDeAdministracion();
                nuevo.Nombre = TBX_Direccion_Cliente.Text;
                nuevo.Apellidos = TBX_Apellidos_Cliente.Text;
                nuevo.RFC = TBX_RFC.Text;
                nuevo.FechaNazi = Convert.ToDateTime(TBX_FechaNaci_Cliente.Text);
                nuevo.Direccion = TBX_Direccion_Cliente.Text;
                nuevo.Correo = TBX_Correo_Cliente.Text;
                nuevo.Telefono = Convert.ToInt32(TBX_Telefon_Cliente.Text);
                Ad.Gerente_Alta_Cliente(nuevo);
            }
            else { MessageBox.Show("Falta llenar todos los campos", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        
        }

        private void Form_Gerente_Load(object sender, EventArgs e)
        {
            Size = new Size (332, 362);
            Controls.Remove(GBX_Asignar);
            GBX_Registrar.Location = new Point(0, 27);
            GBX_Asignar.Location = new Point(0, 27);
            Controls.Contains(GBX_Asignar);
        }

        private void Menu_Resgistra_Click(object sender, EventArgs e) {
            if (Controls.Contains(GBX_Asignar)){Controls.Remove(GBX_Asignar); }       
            if (!Controls.Contains(GBX_Registrar)) { Controls.Add(GBX_Registrar); }
        }

        private void Menu_Asignar_Click(object sender, EventArgs e)
        {
            if (!Controls.Contains(GBX_Asignar)) { Controls.Add(GBX_Asignar); }
            if (Controls.Contains(GBX_Registrar)) { Controls.Remove(GBX_Registrar); }
        }
        

    }
}

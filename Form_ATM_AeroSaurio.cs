using System;
using System.CodeDom;
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
    public partial class Form_ATM_AeroSaurio : Form
    {
        int inicio_sesion;
        ConectarBase conectarBase = new ConectarBase(); 
        public Form_ATM_AeroSaurio()
        {
            InitializeComponent();
        }
        private void inicio_sesion_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String Usuario = usuario_tbx.Text;
                String Contrasena = contrasena_tbx.Text;

                switch (inicio_sesion)
                {
                    case 1:
                        logear_cliente(Usuario,Contrasena);
                        break;
                    case 2:
                        logear_Admin(Usuario,Contrasena);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
            finally { }
                
        }      
        public void logear_cliente(String Usuario, String Contrasena)
        {
            try
            {
                SqlConnection conectando = new SqlConnection(conectarBase.Conexion);
                conectando.Open();
                SqlCommand cmd = new SqlCommand("SELECT Usuario FROM Info_Usuario WHERE Usuario = @usuario AND Password = @pass", conectando);
                cmd.Parameters.AddWithValue("usuario", Usuario);
                cmd.Parameters.AddWithValue("pass", Contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                        new Form_Clientes().Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos");
                }
            
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

            }
        }
        public void logear_Admin(String Usuario, String Contrasena)
        {
            try
            {
                SqlConnection conectando = new SqlConnection(conectarBase.Conexion);
                conectando.Open();
                SqlCommand cmd = new SqlCommand("SELECT Usuario, Nivel_Autoridad FROM Acceso_Administrativo WHERE Usuario = @usuario AND Password = @pass", conectando);
                cmd.Parameters.AddWithValue("usuario", Usuario);
                cmd.Parameters.AddWithValue("pass", Contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        new Form_Administracion_De_Permisos().Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Gerente")
                    {
                        new Form_Gerente().Show();
                    }
                    else
                    {
                        new Form_Cajero_Manual().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

            }
        }
        private void trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio_sesion = 2;
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio_sesion = 1;
        }
    }
}

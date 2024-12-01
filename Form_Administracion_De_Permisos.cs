using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ATM
{
    public partial class Form_Administracion_De_Permisos : Form
    {
        CuentasDeAdministracion chambeadores = new CuentasDeAdministracion();
        Clientes clientes = new Clientes();
        Cuentas cuentas = new Cuentas();
        public Form_Administracion_De_Permisos()
        {
            InitializeComponent();
            invisibilidad();
            cargar_clientes();
            cargar_empleados();
        }
        String realizar = " ";
        String tipo = " ";
        public void invisibilidad()
        {
            titulo_lbl.Text = " ";
            titulo_lbl.Visible = false;
            nombre_lbl.Visible = false;
            nombre_tbx.Visible = false;
            nombre_lbl.Text = " ";
            apellidos_lbl.Visible = false;
            apellidos_tbx.Visible = false;
            apellidos_lbl.Text = " ";
            usuario_lbl.Visible = false;
            usuario_tbx.Visible = false;
            usuario_lbl.Text = " ";
            contrasena_tbx.Visible = false;
            contrasena_lbl.Visible = false; 
            contrasena_lbl.Text = " ";   
            finalizar_btn.Visible = false;
            finalizar_btn.Text = " ";
            trabajadores_lbl.Visible = false;
            clientes_lbl.Visible = false;
        }
        public void agregar()
        {
            realizar = "agregar";
            titulo_lbl.Text = "Agregar";
            nombre_lbl.Text = "Nombre";
            apellidos_lbl.Text = "Apellidos";
            usuario_lbl.Text = "Usuario";
            contrasena_lbl.Text = "Contraseña";
            finalizar_btn.Text = "Agregar";
            nombre_lbl.Visible = true;
            nombre_tbx.Visible = true;
            usuario_lbl.Visible = true;
            usuario_tbx.Visible = true;
            apellidos_lbl.Visible = true;
            apellidos_tbx.Visible = true;
            contrasena_lbl.Visible = true;
            contrasena_tbx.Visible = true;
            finalizar_btn.Visible = true;
        }
        private void Form_Administracion_De_Permisos_Load(object sender, EventArgs e)
        {

        }
        private void Admin_mst_Click(object sender, EventArgs e)
        {
            tipo = "Administrador";
            agregar();
        }
        private void gerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = "Gerente";
            agregar();
            
        }
        private void cajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo = "Cajero";
            agregar();         
        }
        private void finalizar_btn_Click(object sender, EventArgs e)
        {
            if (realizar == "agregar")
            {
                switch (tipo)
                {
                    case "Administrador":
                        chambeadores.Nombre = nombre_tbx.Text;
                        chambeadores.Apellidos = apellidos_tbx.Text;
                        chambeadores.Usuario = usuario_tbx.Text;
                        chambeadores.Contraseña = contrasena_tbx.Text;
                        chambeadores.NivelAdmin = "Administrador";
                        MessageBox.Show("Administrador registrado correctamente", "Aerosaurio Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chambeadores.Admin_Alta(chambeadores);
                        break;
                    case "Gerente":
                        chambeadores.Nombre = nombre_tbx.Text;
                        chambeadores.Apellidos = apellidos_tbx.Text;
                        chambeadores.Usuario = usuario_tbx.Text;
                        chambeadores.Contraseña = contrasena_tbx.Text;
                        chambeadores.NivelAdmin = "Gerente";
                        MessageBox.Show("Gerente registrado correctamente", "Aerosaurio Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chambeadores.Admin_Alta(chambeadores);
                        break;
                    case "Cajero":
                        chambeadores.Nombre = nombre_tbx.Text;
                        chambeadores.Apellidos = apellidos_tbx.Text;
                        chambeadores.Usuario = usuario_tbx.Text;
                        chambeadores.Contraseña = contrasena_tbx.Text;
                        chambeadores.NivelAdmin = "Cajero";
                        MessageBox.Show("Cajero registrado correctamente", "Aerosaurio Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chambeadores.Admin_Alta(chambeadores);
                        break;
                    case "Cliente":
                        clientes.Nombre = nombre_tbx.Text;
                        clientes.Apellidos = apellidos_tbx.Text;
                        cuentas.Usuario = usuario_tbx.Text;
                        cuentas.Contraseña = contrasena_tbx.Text;
                        clientes.Correo = contrasena_tbx.Text;
                        clientes.Direccion = direccion_tbx.Text;
                        cuentas.Saldo = double.Parse(depo_ini_tbx.Text);
                        clientes.Telefono = int.Parse(telefono_tbx.Text);
                        clientes.FechaNazi = dateTimePicker1.Value;
                        clientes.RFC = rfc_tbx.Text;
                        MessageBox.Show("Cliente registrado correctamente", "Aerosaurio Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clientes.cliente_alta(clientes);
                        cuentas.crear_cuenta(cuentas,clientes);
                        break;
                }
            }
            else if(realizar == "eliminar")
            {
                switch (tipo)
                {
                    case "Clientes":
                        clientes.ID = int.Parse(nombre_tbx.Text);
                        clientes.Clientes_baja(clientes);
                        break;
                    case "Gerente": case "Administrador": case "Cajero":
                        chambeadores.ID = int.Parse(nombre_tbx.Text);
                        chambeadores.Admin_Baja(chambeadores);
                        break;
                }

            }
            cargar_clientes();
            cargar_empleados();
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {       
        }
        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            invisibilidad();
            realizar = "eliminar";
            tipo = "Clientes";
            finalizar_btn.Text = "Eliminar";
            nombre_lbl.Text = "ID";
            nombre_lbl.Visible = true;
            nombre_tbx.Visible = true;
            finalizar_btn.Visible = true;
        }
        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trabajadores_lbl.Visible= true;
            Administradores_dgv.Visible = true;
        }
        private void Administradores_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void cargar_empleados()
        {
            DataTable tab = chambeadores.mostrar_chambeadores();
            if (tab != null)
            {
                Administradores_dgv.DataSource = tab;
                Administradores_dgv.AutoSize = true;
            }
        }
        public void cargar_clientes()
        {
            DataTable tab = clientes.mostrar_clientes();
            if (tab != null)
            {
                clientes_dgv.DataSource = tab;
                clientes_dgv.AutoSize = true;
            }
        }
        public void clientes_load()
        {
            cargar_clientes();
        }
        public void empleados_load()
        {
            cargar_empleados();
        }
        public void Administradores_dvg_SelectionChanged(object sender, EventArgs e)
        {
            chambeadores = new CuentasDeAdministracion();
            chambeadores.ID = int.Parse(Administradores_dgv.Rows[Administradores_dgv.CurrentCell.RowIndex].Cells[0].Value.ToString());
            nombre_tbx.Text = Administradores_dgv.Rows[Administradores_dgv.CurrentCell.RowIndex].Cells[1].Value.ToString();
            apellidos_tbx.Text = Administradores_dgv.Rows[Administradores_dgv.CurrentCell.RowIndex].Cells[2].Value.ToString();
            usuario_tbx.Text = Administradores_dgv.Rows[Administradores_dgv.CurrentCell.RowIndex].Cells[3].Value.ToString();

        }
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes_lbl.Visible = true;
            clientes_dgv.Visible = true;    
        }
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            correo_tbx.Visible = true;
            Correo_lbl.Visible = true;
            telefono_tbx.Visible = true;
            label3.Visible = true;
            dateTimePicker1.Visible = true;
            nacimiento_lbl.Visible = true;
            rfc_lbl.Visible = true;
            rfc_tbx.Visible = true;
            tipo = "Cliente";
            direccion_tbx.Visible = true;
            Direccion_lbl.Visible = true;
            depo_ini_tbx.Visible = true;
            deposito_inicial_lbl.Visible = true;
            agregar();
        }

        private void cajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invisibilidad();
            realizar = "eliminar";
            tipo = "Cajero";
            finalizar_btn.Text = "Eliminar";
            nombre_lbl.Text = "ID";
            nombre_lbl.Visible = true;
            nombre_tbx.Visible = true;
            finalizar_btn.Visible = true;
        }
    }
}

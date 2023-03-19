using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Clases;

namespace Hotel.Formulario
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            personalizarDiseno();
        }
        void personalizarDiseno()
        {
            pnlCliente.Visible = false;
            pnlAdmin.Visible = false;
        }

        void ocultarSubmenu()
        {
            if(pnlCliente.Visible == true) { pnlCliente.Visible = false; }
            if (pnlAdmin.Visible == true) { pnlAdmin.Visible = false; }
        }

        void mostrarSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        private Form formularioActivo = null;
        private void abrirFormularioHijos(Form formularioHijos)
        {
            if(formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijos;
            formularioHijos.TopLevel= false;
            formularioHijos.FormBorderStyle= FormBorderStyle.None;
            formularioHijos.Dock= DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijos);
            pnlContenedor.Tag = formularioHijos;
            formularioHijos.BringToFront();
            formularioHijos.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlAdmin);
        }

        private void btnHabitacion(object sender, EventArgs e)
        {
            abrirFormularioHijos(new frmHabitacion());
            ocultarSubmenu();
        }

        private void btnClud_Click(object sender, EventArgs e)
        {
            abrirFormularioHijos(new frmCliente());
            ocultarSubmenu();
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlCliente);
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            abrirFormularioHijos(new frmCliente());
            ocultarSubmenu();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            abrirFormularioHijos(new frmReserva());
            ocultarSubmenu();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            Form_LogIn frm = new Form_LogIn();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormularioHijos(new frmEstadoDisponible());
            ocultarSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormularioHijos(new frmEstadoOcupado());
            ocultarSubmenu();
        } 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hotel.Clases;
using Hotel.Formulario;

namespace Hotel
{
    public partial class Form_LogIn : Form
    {
        cConexion cn; //Variable cConexion
        SqlCommand cmd; //Variaable para entrar los comandos de sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        int contador = 0;



        public Form_LogIn()
        {
            InitializeComponent();
            cn = new cConexion();   
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string fechaSesion = DateTime.Now.ToString("yyyy-MM-dd");
            cmd = new SqlCommand("select * from tblUsuario where usuario = '" + txtUsuario.Text + "' and contrasena = '" + txtContrasena.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);



            //Validar el iUngreso
            if (dt.Rows.Count==0)
            {
                contador++;
                MessageBox.Show("Usuario o contraseña incorrectos, llevas  " + contador + " intentos");
                txtContrasena.Clear();
                txtUsuario.Clear();
                if (contador >= 3)
                {
                    MessageBox.Show("No puedes ingresar ¡Datos incorrectos!");
                    this.Close();
                }
            }

            else
            {
                
                cmd = new SqlCommand("UPDATE tblAcceso SET acceso = @acceso", cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@acceso", txtUsuario.Text);
                cmd.ExecuteNonQuery();

                SqlCommand sesion = new SqlCommand("UPDATE tblHabitacion SET estaDisponible = 1 WHERE IdHabitacion IN (SELECT IdHabitacion FROM tblReserva_Habitacion JOIN tblReserva ON tblReserva_Habitacion.IdReserva = tblReserva.IdReserva WHERE tblReserva.fechaSalida < @fechaSesion)", cn.AbrirConexion());
                sesion.Parameters.AddWithValue("@fechaSesion", fechaSesion);
                sesion.ExecuteNonQuery();


                frmMenuPrincipal frm = new frmMenuPrincipal();
                frm.Show();
                this.Hide();
                timer1.Stop();
            }

        }

        private void Form_LogIn_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

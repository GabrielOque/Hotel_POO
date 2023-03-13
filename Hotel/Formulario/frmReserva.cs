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

namespace Hotel.Formulario
{
    public partial class frmReserva : Form
    {
        cConexion cn;
        SqlCommand cmd;
        public frmReserva()
        {
            InitializeComponent();
            cn = new cConexion();
            cmd = new SqlCommand("select * from tblHabitacion", cn.AbrirConexion());
        }

        private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFechaIngreso.Value > dtpFechaSalida.Value)
            {
                MessageBox.Show("La fecha de entrada no debe de ser mayor a la fecha de salida");
            }
        }

        private void txtNumeroHabitaciones_Leave(object sender, EventArgs e)
        { 
            int limite = Convert.ToInt32(txtNumeroPersonas.Text) / Convert.ToInt32(txtNumeroHabitaciones.Text);
            SqlCommand cmd = new SqlCommand("select IdHabitacion, LimitePersonas, th.descripcion, ServicioCuarto, AireAcondicionado from tblHabitacion h" +
                " inner join tblTipoHabitacion th on th.IdTipo=h.IdTipo   where LimitePersonas >= '" + limite + "'", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dtgDisponibilidad.DataSource = dt;
            da.Fill(dt);
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {

        }

      
    }
}

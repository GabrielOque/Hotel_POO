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
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;

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
            SqlCommand cmd = new SqlCommand("select IdHabitacion, LimitePersonas, th.descripcion, ServicioCuarto, AireAcondicionado, estaDisponible from tblHabitacion h" +
                " inner join tblTipoHabitacion th on th.IdTipo=h.IdTipo   where LimitePersonas >= '" + limite + "' and estaDisponible= '" + true + "'", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dtgDisponibilidad.DataSource = dt;
            da.Fill(dt);
        }

        private void btnNuevReserva_Click(object sender, EventArgs e)
        {
            for (int Indice = 0; Indice <= dtgDisponibilidad.Rows.GetLastRow(DataGridViewElementStates.Displayed); Indice++)
            {
                if (dtgDisponibilidad.Rows[Indice].Cells[0].Value != null)
                {
                    if ((bool)dtgDisponibilidad.Rows[Indice].Cells[0].Value)
                    {
                        string id = dtgDisponibilidad.Rows[Indice].Cells[1].Value.ToString();
                        SqlCommand cmd = new SqlCommand("select * from tblHabitacion where IdHabitacion = '" + id + "'", cn.AbrirConexion());
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        int noches = Convert.ToInt32((dtpFechaSalida.Value - dtpFechaIngreso.Value).TotalDays);
                        cmd = new SqlCommand("insert into tblReserva values ('" + 20230101 + "', '" + 20230606 + "' , '" + noches + "', '" + dt.Rows[0][7] + "', '" + txtCedula.Text + "')", cn.AbrirConexion());
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("SELECT TOP 1 * FROM tblReserva ORDER BY IdReserva DESC", cn.AbrirConexion());
                        da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);


                        cmd = new SqlCommand("insert into tblReserva_Habitacion values('" + dt.Rows[0][0].ToString() + "','" + id + "')", cn.AbrirConexion());
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("UPDATE tblHabitacion SET estaDisponible = @estaDisponible WHERE IdHabitacion = '" + id + "'", cn.AbrirConexion());
                        cmd.Parameters.AddWithValue("@estaDisponible", false);
                        cmd.ExecuteNonQuery();

                        SqlCommand total = new SqlCommand("select sum(valorNoche) as 'valorPagar' from tblHabitacion where IdHabitacion = '" + id + "'", cn.AbrirConexion());
                        SqlDataAdapter data = new SqlDataAdapter(total);
                        DataTable dt2 = new DataTable();
                        data.Fill(dt2);

                        txtTotal.Text = dt2.Rows[0][0].ToString();

                        MessageBox.Show("Reserva exitosa");
                    }
                }
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblCliente where cedula = '" + txtCedula.Text + "'", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0) txtNombre.Text = dt.Rows[0][1].ToString();
         

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroPersonas.Clear();
            txtNumeroHabitaciones.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
        }
    }
}

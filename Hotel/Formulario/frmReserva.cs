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
using System.Globalization;
using System.Data.Odbc;

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
            string fi = dtpFechaIngreso.Value.ToString("yyyy-MM-dd");
            string fs = dtpFechaSalida.Value.ToString("yyyy-MM-dd");

            int limite = Convert.ToInt32(txtNumeroPersonas.Text) / Convert.ToInt32(txtNumeroHabitaciones.Text);
            SqlCommand cmd = new SqlCommand("select IdHabitacion, LimitePersonas, th.descripcion, ServicioCuarto, AireAcondicionado, estaDisponible, valorNoche from tblHabitacion h" +
                " inner join tblTipoHabitacion th on th.IdTipo=h.IdTipo  where LimitePersonas >= '" + limite + "' and estaDisponible= '" + true + "'", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dtgDisponibilidad.DataSource = dt;
            da.Fill(dt);
        }

        private void btnNuevReserva_Click(object sender, EventArgs e)
        {
            int saldoPagar = 0;
            int totalHabitaciones = 0;
            bool seSelecciona = false;
            string fechaReserva = DateTime.Now.ToString("yyyy-MM-dd");

            for (int Indice = 0; Indice <= dtgDisponibilidad.Rows.GetLastRow(DataGridViewElementStates.Displayed); Indice++)
            {
                if (dtgDisponibilidad.Rows[Indice].Cells[0].Value != null)
                {
                    if ((bool)dtgDisponibilidad.Rows[Indice].Cells[0].Value)
                    {

                        totalHabitaciones++;
                        seSelecciona=true;
                        string fechaIngreso = dtpFechaIngreso.Value.ToString("yyyy-MM-dd");
                        string fechaSalida = dtpFechaSalida.Value.ToString("yyyy-MM-dd");
                        int noches = Convert.ToInt32((dtpFechaSalida.Value - dtpFechaIngreso.Value).TotalDays);

                        if (noches == 0) noches = 1;
                        saldoPagar += Convert.ToInt32(dtgDisponibilidad.Rows[Indice].Cells[7].Value) * noches;


                        cConexion cn = new cConexion();
                        SqlCommand cmd = new SqlCommand("INSERT INTO tblReserva (fechaIngreso, fechaSalida, numeroNoches, valorPagar, cedula, fechaReserva, numeroHabitaciones, numeroPersonas) VALUES (@fechaIngreso, @fechaSalida, @numeroNoches, @valorPagar, @cedula, @fechaReserva, @numeroHabitaciones, @numeroPersonas)", cn.AbrirConexion());
                        cmd.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                        cmd.Parameters.AddWithValue("@fechaSalida", fechaSalida);
                        cmd.Parameters.AddWithValue("@numeroNoches", noches);
                        cmd.Parameters.AddWithValue("@valorPagar", 0);
                        cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);
                        cmd.Parameters.AddWithValue("@fechaReserva", fechaReserva);
                        cmd.Parameters.AddWithValue("@numeroHabitaciones", 0);
                        cmd.Parameters.AddWithValue("@numeroPersonas", txtNumeroPersonas.Text);
                        cmd.ExecuteNonQuery();


                        SqlCommand cmd2 = new SqlCommand("UPDATE tblHabitacion SET estaDisponible = @estaDisponible WHERE IdHabitacion = @IdHabitacion", cn.AbrirConexion());
                        cmd2.Parameters.AddWithValue("@estaDisponible", 0);
                        cmd2.Parameters.AddWithValue("@IdHabitacion", dtgDisponibilidad.Rows[Indice].Cells[1].Value);
                        cmd2.ExecuteNonQuery();

                        SqlCommand id2 = new SqlCommand("SELECT MAX(IdReserva) FROM tblReserva", cn.AbrirConexion());
                        SqlDataAdapter daid = new SqlDataAdapter(id2);
                        DataTable dtid = new DataTable();
                        daid.Fill(dtid);

                        //Hacer las insersiones en la tabla DetalleReserva
                        SqlCommand cmd3 = new SqlCommand("INSERT INTO tblReserva_Habitacion VALUES (@IdReserva, @IdHabitacion)", cn.AbrirConexion());
                        cmd3.Parameters.AddWithValue("@IdReserva", dtid.Rows[0][0]);
                        cmd3.Parameters.AddWithValue("@IdHabitacion", dtgDisponibilidad.Rows[Indice].Cells[1].Value);
                        cmd3.ExecuteNonQuery();


                    }
                }
            }
            if (!seSelecciona)
            {
                MessageBox.Show("Para hacer una reserva es necesario seleccionar al menos una habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Reserva almacenada exitosamente. El total de su reserva fue: " + saldoPagar, "Reserva almacenada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                cConexion cnF = new cConexion();
                SqlCommand cmdF = new SqlCommand("UPDATE tblReserva SET valorPagar = @valorPagar, numeroHabitaciones = @numeroHabitaciones WHERE cedula = @cedula and fechaReserva = @fechaReserva", cnF.AbrirConexion());
                cmdF.Parameters.AddWithValue("@valorPagar", saldoPagar);
                cmdF.Parameters.AddWithValue("@numeroHabitaciones", totalHabitaciones);
                cmdF.Parameters.AddWithValue("@cedula", txtCedula.Text);
                cmdF.Parameters.AddWithValue("@fechaReserva", fechaReserva);
                cmdF.ExecuteNonQuery();

                dtpFechaIngreso.Value = DateTime.Today;
                dtpFechaSalida.Value = DateTime.Today.AddDays(1);
                txtNumeroPersonas.Clear();
                txtNumeroHabitaciones.Clear();
                txtCedula.Clear();
                txtNombre.Clear();
                dtgDisponibilidad.DataSource = null;
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroPersonas.Clear();
            txtNumeroHabitaciones.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            dtgDisponibilidad.DataSource = "";
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblCliente where cedula = '" + txtCedula.Text + "'", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0) txtNombre.Text = dt.Rows[0][1].ToString();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            txtCedula.Focus();
            dtpFechaIngreso.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Today.AddDays(1);
        }

        private void txtNumeroPersonas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

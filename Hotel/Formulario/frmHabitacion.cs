using Hotel.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel.Formulario
{
    public partial class frmHabitacion : Form
    {
        cConexion cn; //Variable de conexion
        SqlCommand cmd; //Para traer los comandos de sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        int contador, i, boton;
        Image imagenSeleccionada;
        public frmHabitacion()
        {
            InitializeComponent();
            cn = new cConexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblHabitacion", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt); //LLena dt con la consulta de cmd
        }

       

        private void frmHabitacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelDataSet.tblTipoHabitacion' Puede moverla o quitarla según sea necesario.
            //this.tblTipoHabitacionTableAdapter.Fill(this.hotelDataSet.tblTipoHabitacion);
            llenarCombo();
            Llenar(dt, i);
            Desabilita();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            i++;
            if (i == dt.Rows.Count) i = (dt.Rows.Count - 1);
            Llenar(dt, i);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (i <= 0)
            {
                i = 0; Llenar(dt, i);
            }
            else
            {
                i--;
                Llenar(dt, i);

            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            Llenar(dt, i);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            i = (dt.Rows.Count - 1);
            Llenar(dt, i);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Llenar(dt, i);
            Desabilita();

            if (btnGuardar.Visible == true)
            {
                btnGuardar.Visible = false;
            }
        }

        void llenarCombo()
        {
            SqlCommand cmd = new SqlCommand("select * from tblTipoHabitacion", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                cmbTipoHabitacion.Items.Add(dt.Rows[i][1]);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            boton = 1;
            Limpiar();
            Desabilita();
            txtNumHabitacion.Enabled = true;
            txtNumHabitacion.Focus();
      
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            boton = 2;
            Habilita();
            Limpiar();
            txtNumHabitacion.Enabled=true;
            txtNumHabitacion.Focus();
        }

        void Limpiar()
        {
            txtNumHabitacion.Clear();
            txtTamanoHabitacion.Clear();
            txtLimitePersonas.Clear();
            txtValorNoche.Clear();
            rdbServicioAlCuartoSi.Checked = false;
            rdbServicioAlCuartoNo.Checked = false;
            rdbMiniBarSi.Checked = false;
            rdbMiniBarNo.Checked = false;
            rdbAireAcondicionadoSi.Checked = false;
            rdbAireAcondicionadoNo.Checked = false;
            cmbTipoHabitacion.Text = "Sencilla";
        }

        

        

        void Desabilita()
        {
            txtNumHabitacion.Enabled = false;
            txtLimitePersonas.Enabled= false;
            txtTamanoHabitacion.Enabled= false;
            txtValorNoche.Enabled=false;
            cmbTipoHabitacion.Enabled = false;
            rdbAireAcondicionadoNo.Enabled = false;
            rdbAireAcondicionadoSi.Enabled = false;
            rdbMiniBarSi.Enabled = false;
            rdbMiniBarNo.Enabled = false;
            rdbServicioAlCuartoNo.Enabled = false;
            rdbServicioAlCuartoSi.Enabled= false;
        }

        void Habilita()
        {
            txtNumHabitacion.Enabled = true;
            txtLimitePersonas.Enabled = true;
            txtTamanoHabitacion.Enabled = true;
            txtValorNoche.Enabled = true;
            cmbTipoHabitacion.Enabled = true;
            rdbAireAcondicionadoNo.Enabled = true;
            rdbAireAcondicionadoSi.Enabled = true;
            rdbMiniBarSi.Enabled = true;
            rdbMiniBarNo.Enabled = true;
            rdbServicioAlCuartoNo.Enabled = true;
            rdbServicioAlCuartoSi.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (boton == 2)
            {
                int description = 0;
                Boolean servicoCuerto = false;
                Boolean aireAcondicionado = false;
                Boolean miniBar = false;
                
                if (cmbTipoHabitacion.SelectedIndex == 0)
                {
                    description = 14;

                }
                if (cmbTipoHabitacion.SelectedIndex == 1)
                {
                    description = 15;
                }
                if (cmbTipoHabitacion.SelectedIndex == 2)
                {
                    description = 14;
                }
                if (cmbTipoHabitacion.SelectedIndex == 3)
                {
                    description = 17;
                }
                if (rdbAireAcondicionadoSi.Checked) { aireAcondicionado = true; }
                if (rdbServicioAlCuartoSi.Checked) { servicoCuerto = true; }
                if (rdbMiniBarSi.Checked) { miniBar = true; }

                if (string.IsNullOrEmpty(txtRuta.Text)) {
                    MessageBox.Show("Se debe de poner una imagen");
                }
                else
                {
                    byte[] img = System.IO.File.ReadAllBytes(txtRuta.Text);

                    SqlCommand cmd = new SqlCommand("INSERT INTO tblHabitacion (IdHabitacion, IdTipo, tamanoMetros, LimitePersonas, ServicioCuarto, AireAcondicionado, Minibar, valorNoche, estaDisponible, DireccionImg, Imagen) VALUES(@IdHabitacion, @IdTipo, @tamanoMetros, @LimitePersonas, @ServicioCuarto, @AireAcondicionado, @Minibar, @valorNoche, 1, @DireccionImg , @Imagen)", cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@IdHabitacion", txtNumHabitacion.Text);
                    cmd.Parameters.AddWithValue("@IdTipo", description);
                    cmd.Parameters.AddWithValue("@tamanoMetros", txtTamanoHabitacion.Text);
                    cmd.Parameters.AddWithValue("@LimitePersonas", txtLimitePersonas.Text);
                    cmd.Parameters.AddWithValue("@ServicioCuarto", servicoCuerto);
                    cmd.Parameters.AddWithValue("@AireAcondicionado", aireAcondicionado);
                    cmd.Parameters.AddWithValue("@Minibar", miniBar);
                    cmd.Parameters.AddWithValue("@valorNoche", txtValorNoche.Text);
                    cmd.Parameters.AddWithValue("@DireccionImg", txtRuta.Text);
                    cmd.Parameters.AddWithValue("@Imagen", img);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Habitacion " + txtNumHabitacion.Text + " guardada exitosamente.", "Guardar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (boton == 3)
            {
                int description = 0;
                Boolean servicoCuerto = false;
                Boolean aireAcondicionado = false;
                Boolean miniBar = false;
                if (rdbAireAcondicionadoSi.Checked) { aireAcondicionado = true; }
                if (rdbServicioAlCuartoSi.Checked) { servicoCuerto = true; }
                if (rdbMiniBarSi.Checked) { miniBar = true; }

                if (cmbTipoHabitacion.SelectedIndex == 0)
                {
                    description = 14;

                }
                if (cmbTipoHabitacion.SelectedIndex == 1)
                {
                    description = 15;
                }
                if (cmbTipoHabitacion.SelectedIndex == 2)
                {
                    description = 16;
                }
                if (cmbTipoHabitacion.SelectedIndex == 3)
                {
                    description = 17;
                }


                SqlCommand cmd = new SqlCommand("select * from tblHabitacion", cn.AbrirConexion());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (string.IsNullOrEmpty(txtRuta.Text))
                {
                    MessageBox.Show("Se debe de poner una imagen");
                }
                else
                {
                    byte[] img = System.IO.File.ReadAllBytes(txtRuta.Text);
                    cmd = new SqlCommand("UPDATE tblHabitacion SET IdHabitacion = @IdHabitacion, IdTipo = @IdTipo, TamanoMetros = @TamanoMetros, LimitePersonas = @LimitePersonas, servicioCuarto = @servicioCuarto, aireAcondicionado = @aireAcondicionado, miniBar = @miniBar, ValorNoche = @ValorNoche, Imagen = @Imagen, DireccionImg = @DireccionImg  WHERE IdHabitacion = '" + txtNumHabitacion.Text + "'", cn.AbrirConexion());
                    cmd.Parameters.AddWithValue("@IdHabitacion", txtNumHabitacion.Text);
                    cmd.Parameters.AddWithValue("@IdTipo", description);
                    cmd.Parameters.AddWithValue("@TamanoMetros", txtTamanoHabitacion.Text);
                    cmd.Parameters.AddWithValue("@LimitePersonas", txtLimitePersonas.Text);
                    cmd.Parameters.AddWithValue("@servicioCuarto", servicoCuerto);
                    cmd.Parameters.AddWithValue("@aireAcondicionado", aireAcondicionado);
                    cmd.Parameters.AddWithValue("@miniBar", miniBar);
                    cmd.Parameters.AddWithValue("@ValorNoche", txtValorNoche.Text);
                    cmd.Parameters.AddWithValue("@Imagen", img);
                    cmd.Parameters.AddWithValue("@DireccionImg", txtRuta.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Habitación modificada");
                }
               


                
            }
            btnGuardar.Visible = false;
            Desabilita();
        }


        private void btnModificacion_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            boton = 3;
            Habilita();
            Limpiar();
            txtNumHabitacion.Focus();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            Limpiar();
            txtNumHabitacion.Enabled = true;
            txtNumHabitacion.Focus();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            // Abrir un cuadro de diálogo de selección de archivo
            DialogResult r = dlgHabitacion.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtRuta.Text = dlgHabitacion.FileName;
                pcbImagen.Load(txtRuta.Text);
            }
        }

        private void txtNumHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        void Llenar(DataTable dt, int i)
        {
            string dato = dt.Rows[i][1].ToString();
            txtNumHabitacion.Text = dt.Rows[i][0].ToString();
            txtValorNoche.Text = dt.Rows[i][7].ToString();
            cmbTipoHabitacion.Text= dt.Rows[i][1].ToString();   
            switch (dato)
            {
                case "14":
                    cmbTipoHabitacion.Text = "Sencilla";
                    break;
                case "15":
                    cmbTipoHabitacion.Text = "Doble";
                    break;
                case "16":
                    cmbTipoHabitacion.Text = "Triple";
                    break;
                case "17":
                    cmbTipoHabitacion.Text = "Suite";
                    break;

            }

            txtTamanoHabitacion.Text = dt.Rows[i][2].ToString();
            txtLimitePersonas.Text = dt.Rows[i][3].ToString();

            if (dt.Rows[i][4].ToString()== "True")
            {
                rdbServicioAlCuartoSi.Checked = true;
            }
            else
            {
                rdbServicioAlCuartoNo.Checked = true;
            }
            if (dt.Rows[i][5].ToString()== "True")
            {
                rdbAireAcondicionadoSi.Checked = true; 
            }
            else
            {
                rdbAireAcondicionadoNo.Checked = true;
            }
            if (dt.Rows[i][6].ToString() == "True")
            {
                rdbMiniBarSi.Checked = true;
            }
            else
            {
                rdbMiniBarNo.Checked = true;
            }
            //Desabilita();

            // Crear la consulta SQL

            txtRuta.Text = dt.Rows[i][10].ToString();
            string rutaArchivo;
            // Verificar que la posicion en la base de datos sea diferente de nulo y que la informacion que contenga sea la adecuada para mostrar como imagen
            if (dt.Rows[i][9] != null && dt.Rows[i][9] != DBNull.Value && dt.Rows[i][9] is byte[])
            {
                byte[] imgBytes = (byte[])dt.Rows[i][9];
                MemoryStream ms = new MemoryStream(imgBytes);
                Image img = Image.FromStream(ms);
                pcbImagen.Image = img;
            }
            else
            {
                rutaArchivo = @"C:\Users\USUARIO\Documents\IUE\POO\Proyecto 2\Hotel\default_image.png";
                pcbImagen.Load(rutaArchivo);
            }

        }
        private void txtNumHabitacion_Leave(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select * from tblHabitacion where IdHabitacion = '" + txtNumHabitacion.Text + "'", cn.AbrirConexion());
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            i = 0;
            switch (boton)
            {
                case 1:
                    if (dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe");
                        txtNumHabitacion.Clear();
                        txtNumHabitacion.Focus();
                    }
                    else
                    {
                        Llenar(dt1, i);
                        Desabilita();
                    }
                    break;
                case 2:
                    if(dt1.Rows.Count > 0)
                    {
                        Llenar(dt1, i);
                        MessageBox.Show("La cedula ya estas registrada");
                        
                    }
                    break;
                case 3:
                    if (dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe");
                        txtNumHabitacion.Clear();
                        txtNumHabitacion.Focus();
                    }
                    else
                    {
                        Llenar(dt1, i);
                    }
                    break;
                case 4:
                    if (dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe");
                        txtNumHabitacion.Clear();
                        txtNumHabitacion.Focus();
                        Llenar(dt1, 0);
                    }
                    else
                    {
                        Llenar(dt1, i);
                        if (MessageBox.Show("¿Desea eliminar el cliente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlCommand cm = new SqlCommand("DELETE FROM tblHabitacion WHERE IdHabitacion='" + txtNumHabitacion.Text + "'", cn.AbrirConexion());
                            cm.ExecuteNonQuery();
                        }
                    }
                    break;
            }
        }

    }
}

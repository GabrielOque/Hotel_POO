using Hotel.Clases;
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

namespace Hotel.Formulario
{
    public partial class frmHabitacion : Form
    {
        cConexion cn; //Variable de conexion
        SqlCommand cmd; //Para traer los comandos de sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        int contador, i, boton;
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
        void Llenar(DataTable dt, int i)
        {
            string dato = dt.Rows[i][1].ToString();
            txtNumHabitacion.Text = dt.Rows[i][0].ToString();
            cmbTipoHabitacion.Text= dt.Rows[i][1].ToString();   
            switch (dato)
            {
                case "1":
                    cmbTipoHabitacion.Text = "Sencilla";
                    break;
                case "2":
                    cmbTipoHabitacion.Text = "Doble";
                    break;
                case "3":
                    cmbTipoHabitacion.Text = "Triple";
                    break;
                default:
                    cmbTipoHabitacion.Text = "Suite";
                    break;

            }

            txtTamanoHabitacion.Text = dt.Rows[i][2].ToString();
            txtLimitePersonas.Text = dt.Rows[i][3].ToString();

            if (dt.Rows[i][4].ToString() == "true")
            {
                rdbServicioAlCuartoSi.Checked = true;
            }
            else
            {
                rdbServicioAlCuartoNo.Checked = true;
            }
            if (dt.Rows[i][5].ToString()== "true")
            {
                rdbAireAcondicionadoSi.Checked = true;  
            }
            else
            {
                rdbAireAcondicionadoNo.Checked = true;
            }
            if (dt.Rows[i][6].ToString() == "true")
            {
                rdbMiniBarSi.Checked = true;
            }
            else
            {
                rdbMiniBarNo.Checked = true;
            }

        }


    }
}

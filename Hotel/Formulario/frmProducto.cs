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
    public partial class frmProducto : Form
    {
        cConexion cn; //Variable de conexion
        SqlCommand cmd; //Para traer los comandos de sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        int contador, i, boton;

        public frmProducto()
        {
            InitializeComponent();
            cn = new cConexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblProducto", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt); //LLena dt con la consulta de cmd
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Llenar(dt, i);
            Desabilita();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            boton = 1;
            Limpiar();
            txtDescripcion.Enabled = true;
            txtDescripcion.Focus();
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM tblProducto WHERE Descripcion = '" + txtDescripcion.Text + "'", cn.AbrirConexion());
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            i = 0;

            switch (boton)
            {
                case 1:
                    if (dt1.Rows.Count == 0)
                    {
                        
                        MessageBox.Show("El registro seleccionado no existe.");
                        txtDescripcion.Clear();
                        txtDescripcion.Focus();

                    }
                    else
                    {
                        Llenar(dt1, i);
                        Desabilita();
                    }
                    break;
                case 2:
                    if (dt1.Rows.Count != 0)
                    {
                        MessageBox.Show("El registro existe.");
                        Llenar(dt1, i);
                        Desabilita();
                    }
                    break;
                case 3:
                    if (dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("El registro no existe.");
                        txtDescripcion.Clear();
                        txtDescripcion.Focus();
                    }
                    else
                    {
                        Llenar(dt1, i);
                    }
                    break;
                case 4:
                    if (dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe el registro");
                        txtDescripcion.Clear();
                        txtDescripcion.Focus();
                    }
                    else
                    {
                        Llenar(dt1, i);
                        if (MessageBox.Show("¿Esta seguro que desea borrar el cliente?", "¡Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlCommand cm = new SqlCommand("DELETE FROM tblProducto WHERE Descripcion = '" + txtDescripcion.Text + "'", cn.AbrirConexion());
                            cm.ExecuteNonQuery();
                        }
                    }
                    break;
            }
            //txtDescripcion.Enabled = false;
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            boton = 2;
            Habilita();
            Limpiar();
            txtDescripcion.Enabled = true;
            txtDescripcion.Focus();
        }

        void Llenar(DataTable dt, int i)
        {
            txtDescripcion.Text = dt.Rows[i][1].ToString();
            txtVltUnitario.Text = dt.Rows[i][2].ToString();
            
            contador = dt.Rows.Count;
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            boton = 3;
            Habilita();
            Limpiar();
            txtDescripcion.Focus();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            Limpiar();
            txtDescripcion.Enabled = true;
            txtDescripcion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(boton == 2)
            {
                SqlCommand cmd = new SqlCommand("nuevo_producto", cn.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@vlrUnitario", Convert.ToInt32(txtVltUnitario.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto creado");
                cn.CerrarConexion();
                Desabilita();

            }
            if(boton == 3)
            {
                SqlCommand cmd = new SqlCommand("modificar_Producto", cn.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@vlrUnitario", Convert.ToInt32(txtVltUnitario.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto actualizado");
                cn.CerrarConexion();
                Desabilita();
            }
        }

        void Limpiar()
        {
            txtDescripcion.Clear();
            txtVltUnitario.Clear();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            i++;
            if (i == contador) i = (contador - 1);
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
            //Desabilita();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            Llenar(dt, i);
            //Desabilita();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            i = (dt.Rows.Count - 1);
            Llenar(dt, i);
        }

        void Habilita()
        {
            txtDescripcion.Enabled = true;
            txtVltUnitario.Enabled = true;
        }
        void Desabilita()
        {
            txtDescripcion.Enabled = false;
            txtVltUnitario.Enabled = false;
        }

    }
}

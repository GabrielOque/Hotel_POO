﻿using System;
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
    public partial class frmCliente : Form
    {
        cConexion cn; //Variable de conexion
        SqlCommand cmd; //Para traer los comandos de sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        int contador, i, boton, j;

        public frmCliente()
        {
            InitializeComponent();
            cn = new cConexion();
            i = 0; boton = 0; j = 0 ;
            cmd = new SqlCommand("select * from tblCliente", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt); //LLena dt con la consulta de cmd
        }

        void Limpiar()
        {
            txtCedula.Clear();
            txtNRSoacial.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtPProcedencia.Clear();
            txtCProcedencia.Clear();
        }


        void Llenar(DataTable dt, int i)
        {
            txtCedula.Text = dt.Rows[i][0].ToString();
            txtNRSoacial.Text = dt.Rows[i][1].ToString();
            txtDireccion.Text = dt.Rows[i][2].ToString();
            txtTelefono.Text = dt.Rows[i][3].ToString();
            txtPProcedencia.Text = dt.Rows[i][4].ToString();
            txtCProcedencia.Text = dt.Rows[i][5].ToString();
            //Almcena la cantidad de registros de la tabla
            contador = dt.Rows.Count;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            i++;
            if(i == contador) i = (contador - 1);
            Llenar(dt, i);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            
            if (i <= 0)
            {
                i = 0; Llenar(dt, i);
            }else
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
            i = (dt.Rows.Count- 1);
            Llenar(dt, i);
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible= true;
            boton = 2;
            Habilita();
            Limpiar();
            txtCedula.Enabled= true;
            txtCedula.Focus();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Llenar(dt, i); 
        }
        void Habilita()
        {
            txtCedula.Enabled= true;
            txtNRSoacial.Enabled= true;
            txtDireccion.Enabled= true;
            txtTelefono.Enabled= true;
            txtPProcedencia.Enabled= true;
            txtCProcedencia.Enabled= true;  
        }

        void Desabilita()
        {
            txtCedula.Enabled = false;
            txtNRSoacial.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtPProcedencia.Enabled = false;
            txtCProcedencia.Enabled = false;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            boton = 1;
            Limpiar();
            txtCedula.Enabled= true;
            txtCedula.Focus();



        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible= true;
            boton = 3;
            Habilita();
            Limpiar();
            txtCedula.Focus();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Llenar(dt, i);
            Desabilita();
            if (btnGuardar.Visible == true)
            {
                btnGuardar.Visible = false;
            }
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            Limpiar();
            txtCedula.Enabled = true;
            txtCedula.Focus();
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {

            SqlCommand cmd1 = new SqlCommand("SELECT * FROM tblCliente WHERE cedula = '" + txtCedula.Text + "'", cn.AbrirConexion());
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
                        txtCedula.Clear();
                        txtCedula.Focus();
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
                        txtCedula.Clear();
                        txtCedula.Focus();
                    }
                    else
                    {
                        Llenar(dt1, i);
                        Habilita();
                    }
                    break;
                case 4:
                    if (dt1.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe el registro");
                        txtCedula.Clear();
                        txtCedula.Focus();
                    }
                    else
                    {
                        Llenar(dt1, i);
                        if (MessageBox.Show("¿Esta seguro que desea borrar el cliente?", "¡Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlCommand cm = new SqlCommand("DELETE FROM tblCliente WHERE cedula = '" + txtCedula.Text + "'", cn.AbrirConexion());
                            cm.ExecuteNonQuery();
                        }
                    }
                    break;
            }
            txtCedula.Enabled = false;
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (boton == 2)
            {
                SqlCommand cmd = new SqlCommand("insert into tblCliente values ('" + txtCedula.Text + "', '" + txtNRSoacial.Text + "' , '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', '" + txtPProcedencia.Text + "', '" + txtCProcedencia.Text + "')", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente guardado");
            }

            if (boton == 3)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tblCliente SET cedula= @cedula, nombre= @nombre, direccion= @direccion, telefono= @telefono, paisOrigen= @paisOrigen, ciudadOrigen= @ciudadOrigen WHERE cedula = @cedulaParametro", cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNRSoacial.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@paisOrigen", txtPProcedencia.Text);
                cmd.Parameters.AddWithValue("@ciudadOrigen", txtCProcedencia.Text);
                cmd.Parameters.AddWithValue("@cedulaParametro", txtCedula.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente modificado");
            }
            btnGuardar.Visible = false;
            Desabilita();
            
        }
       
    }
}

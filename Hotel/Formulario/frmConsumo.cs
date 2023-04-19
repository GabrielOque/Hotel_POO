using Hotel.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Hotel.Formulario
{
    public partial class frmConsumo : Form
    {
        cConexion cn; //Variable de conexion
        SqlCommand cmd; //Para traer los comandos de sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        int contador, i, boton;
        string idCliente = "";

        private void txtHabitacion_Leave(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("SELECT c.cedula, c.nombre FROM tblHabitacion h" +
               " INNER JOIN tblReserva_Habitacion th ON th.IdHabitacion=h.IdHabitacion INNER JOIN tblReserva r ON r.IdReserva=th.IdReserva INNER JOIN tblCliente c ON c.cedula=r.cedula WHERE h.IdHabitacion = @IdHabitacion and h.estaDisponible = 0 order by r.fechaSalida desc", cn.AbrirConexion());
            cmd2.Parameters.AddWithValue("@IdHabitacion", txtHabitacion.Text);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            idCliente = dt2.Rows[0][0].ToString();

            if (dt2.Rows.Count == 0)
            {
                MessageBox.Show("Esta habitacion no está reservada o no existe");
                txtHabitacion.Clear();
                txtNombreCliente.Clear();
            }
            else
            {
                txtNombreCliente.Text = dt2.Rows[0][1].ToString();
            }
            
        }

        

        public frmConsumo()
        {
            InitializeComponent();
          
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dtgProductos.Rows)
            {
                bool inSelected = Convert.ToBoolean(row.Cells["Elegir"].Value);
                if (inSelected)
                {
                    int n = dgvSeleccionado.Rows.Add();
                    dgvSeleccionado.Rows[n].Cells[0].Value = row.Cells[1].Value.ToString();
                    dgvSeleccionado.Rows[n].Cells[1].Value = row.Cells[2].Value.ToString();
                    dgvSeleccionado.Rows[n].Cells[2].Value = row.Cells[3].Value.ToString();

                    ///////////////////
                    foreach (DataGridViewColumn col in dgvSeleccionado.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
        }

        private void dgvSeleccionado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cantidad = 0, precio_unit = 0, precio_total = 0, total = 0;
            if (dgvSeleccionado.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                try
                {
                    cantidad = int.Parse(dgvSeleccionado.Rows[e.RowIndex].Cells[3].Value.ToString());
                    precio_unit = int.Parse(dgvSeleccionado.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if ((cantidad != 0) && !(dgvSeleccionado.Rows[e.RowIndex].Cells[2].Value.Equals("")))
                {
                    precio_total = cantidad * precio_unit;
                    dgvSeleccionado.Rows[e.RowIndex].Cells[4].Value = precio_total;
                    foreach (DataGridViewRow row in dgvSeleccionado.Rows)
                    {
                        total += Convert.ToInt32(row.Cells["Total"].Value);
                    }
                    txtTotal.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Debe ingresar una cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Word.Application wordApp = new Word.Application();
                Word.Document wordDoc = wordApp.Documents.Open("C:\\Users\\Usuario\\Documents\\IUE\\POO\\Proyecto 2\\Hotel\\Resources\\factura.docx");
                if (wordDoc.Tables.Count >= 1)
                {
                    Word.Table table = wordDoc.Tables[1];
                    table.Cell(3, 2).Range.Text = dtmFechaConsumo.Text;
                    table.Cell(4, 2).Range.Text = lblNumero.Text;
                    table.Cell(5, 2).Range.Text = idCliente;
                    table.Cell(3, 3).Range.Text = "Habitacion: " + txtHabitacion.Text.ToString();
                    
                }
                if (wordDoc.Tables.Count >= 2)
                {
                    Word.Table table1 = wordDoc.Tables[2];
                    int rowsN = dgvSeleccionado.Rows.Count;
                    int rowsT = table1.Rows.Count - 2;
                    if (rowsN > rowsT)
                    {
                        int rowsA = rowsN - rowsT;
                        for (int i = 0; i < rowsA; i++)
                        {
                            table1.Rows.Add(table1.Rows[2]);
                        }
                    }
                    for (int i = 0; i < dgvSeleccionado.Rows.Count; i++)
                    {
                        table1.Cell(2 + i, 1).Range.Text = dgvSeleccionado.Rows[i].Cells[3].Value.ToString();
                        table1.Cell(2 + i, 2).Range.Text = dgvSeleccionado.Rows[i].Cells[1].Value.ToString();
                        table1.Cell(2 + i, 3).Range.Text = string.Format(new CultureInfo("es-CO"), "{0:C2}", Convert.ToInt32(dgvSeleccionado.Rows[i].Cells[2].Value)).ToString();
                        table1.Cell(2 + i, 4).Range.Text = string.Format(new CultureInfo("es-CO"), "{0:C2}", Convert.ToInt32(dgvSeleccionado.Rows[i].Cells[4].Value)).ToString();
                    }
                    table1.Cell(14, 4).Range.Text = string.Format(new CultureInfo("es-CO"), "{0:C2}", Convert.ToInt32(txtTotal.Text)).ToString();
            
                }
                if (!wordApp.ActiveWindow.Visible)
                {
                    wordApp.Visible = true;
                }
                if (wordApp.Visible == false)
                    wordApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cConexion cn = new cConexion();
            int IdPro = 0;
            int Cant = 0;
            try
            {
                SqlCommand save = new SqlCommand("INSERT INTO tblConsumo VALUES (@Fecha, @IdHabitacion, @Cedula, @totalConsumo)", cn.AbrirConexion());
                save.Parameters.AddWithValue("@Fecha", dtmFechaConsumo.Text);
                save.Parameters.AddWithValue("@IdHabitacion", txtHabitacion.Text);
                save.Parameters.AddWithValue("@Cedula", idCliente);
                save.Parameters.AddWithValue("@totalConsumo", txtTotal.Text);
                save.ExecuteNonQuery();
                cn.CerrarConexion();
                for (int i = 0; i < dgvSeleccionado.Rows.Count; i++)
                {
                    IdPro = Convert.ToInt32(dgvSeleccionado.Rows[i].Cells[0].Value);
                    Cant = Convert.ToInt32(dgvSeleccionado.Rows[i].Cells[3].Value);
                    SqlCommand saveDC = new SqlCommand("INSERT INTO tblDetalleConsumo VALUES (@IdConsumo, @IdProducto, @Cantidad)", cn.AbrirConexion());
                    saveDC.Parameters.AddWithValue("@IdConsumo", IdFactura() - 1);
                    saveDC.Parameters.AddWithValue("@IdProducto", IdPro);
                    saveDC.Parameters.AddWithValue("@Cantidad", Cant);
                    saveDC.ExecuteNonQuery();
                    cn.CerrarConexion();
                }
                MessageBox.Show("Consumo almacenado correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmConsumo_Load(object sender, EventArgs e)
        {
            cn = new cConexion();
            SqlCommand cmd1 = new SqlCommand("select idProducto as 'ID del producto', Descripcion as 'Nombre producto', vltUnitario as 'Valor unitario'  from tblProducto", cn.AbrirConexion());
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1); //LLena dt con la consulta de cmd

            dtgProductos.DataSource = dt1;
            foreach(DataGridViewColumn col in dtgProductos.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if(IdFactura() < 10)
            {
                lblNumero.Text = "000" + IdFactura().ToString();

            }
            else if(IdFactura() < 100)
            {
                lblNumero.Text = "00" + IdFactura().ToString();
            }
            else if (IdFactura() < 1000)
            {
                lblNumero.Text = "0" + IdFactura().ToString();
            }
            else
            {
                lblNumero.Text = IdFactura().ToString();
            }


        }

        public int IdFactura()
        {
            cn = new cConexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select MAX(idConsumo) from tblConsumo", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt); //LLena dt con la consulta de cmd

            int idFactura = 0;

            if (dt.Rows[0][0] == DBNull.Value)
            {
                idFactura = 1;
            }
            else
            {
                idFactura = Convert.ToInt32(dt.Rows[0][0]) + 1;
                

            }
            return idFactura;
        }
    }
}

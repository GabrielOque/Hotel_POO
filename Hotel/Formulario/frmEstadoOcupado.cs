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
    public partial class frmEstadoOcupado : Form
    {
        cConexion cn;
        public frmEstadoOcupado()
        {
            InitializeComponent();
            cn = new cConexion();

            SqlCommand cmd = new SqlCommand("select IdHabitacion as 'Numero de habitación', LimitePersonas as 'Limite de personas', th.descripcion as 'Tipo de habitación', ServicioCuarto as 'Servicio al cuarto', AireAcondicionado as 'Aire acondicionado', Minibar as 'Mini bar', estaDisponible as 'Estado de disponibilidad' from tblHabitacion h" +
                " inner join tblTipoHabitacion th on th.IdTipo=h.IdTipo  where estaDisponible= '" + false + "'", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dtgHabitacionesOcupadas.DataSource = dt;
            da.Fill(dt);
        }
    }
}

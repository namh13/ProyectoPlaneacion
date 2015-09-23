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

namespace ProyectoPlaneacion
{
    public partial class frmNoFactible : Form
    {
        private SqlConnection conexionBD;

        public frmNoFactible(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
        }

        private void frmNoFactible_Load(object sender, EventArgs e)
        {
            CargarProyecto();
        }

        private void CargarProyecto()
        {
            try
            {
                DataTable dt = new DataTable();
                string ls = "";

                ls = @"select f.idProyecto, p.denominacion, a.descripcionA, 
                    p.area_afectada, p.descripcion, p.duracion 
                    from Factible f 
                    join Proyecto p
                    on f.idProyecto = p.id_proyecto
                    join Area a
                    on p.id_area = a.id_area
                    where f.Factible = 0
                    order by f.Orden DESC";

                SqlCommand leer = new SqlCommand(ls, conexionBD);
                SqlDataAdapter llenar = new SqlDataAdapter(leer);
                llenar.Fill(dt);

                dataGridProyectos.DataSource = dt;
            }

            catch (Exception ex)
            {

            }
        }

        private void dataGridProyectos_DoubleClick(object sender, EventArgs e)
        {
            string proyecto = "";

            if (dataGridProyectos.RowCount > 0)
            {
                proyecto = dataGridProyectos.CurrentRow.Cells["n_id"].Value.ToString();

                frmFactible frm = new frmFactible(conexionBD);
                frm.proyecto = proyecto;
                frm.ShowDialog(this);
                CargarProyecto();
            }
        }
    }
}

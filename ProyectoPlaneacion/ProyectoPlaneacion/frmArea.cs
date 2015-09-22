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
    public partial class frmArea : Form
    {
        private SqlConnection conexionBD;

        public frmArea(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
        }
        private void CargarArea()
        {
            try
            {
                DataTable dt = new DataTable();
                //conexionBD.Open();
                string ls = @"select *from Area";
                SqlCommand cargar = new SqlCommand(ls, conexionBD);
                SqlDataAdapter llenar = new SqlDataAdapter(cargar);
                llenar.Fill(dt);

                dataGridView1.DataSource = dt;
                //conexionBD.Close();
            }
            catch (Exception ex)
            {

            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Area frm = new Area(conexionBD);
            frm.ShowDialog(this);
            CargarArea();
        }
        private void EliminarRegistro()
        {
            try
            {
                string ls = "";
                ls = @"delete from Area where id_area = @area";
                string fila = dataGridView1.CurrentRow.Cells["n_id"].Value.ToString();

                SqlCommand borrar = new SqlCommand(ls, conexionBD);
                borrar.Parameters.AddWithValue("@area", fila);
                borrar.ExecuteNonQuery();
                //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                CargarArea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string area = "";

            if (dataGridView1.RowCount > 0)
            {
                area = dataGridView1.CurrentRow.Cells["n_id"].Value.ToString();

                Area frm = new Area(conexionBD);
                frm.area = area;
                frm.ShowDialog(this);
                CargarArea();
            }
        }

        private void frmArea_Load(object sender, EventArgs e)
        {

        }
    }
}

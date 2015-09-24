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
using System.Collections;

namespace ProyectoPlaneacion
{
    public partial class frmDetalleBeneficio : Form
    {
        private SqlConnection conexionBD;
        private SqlCommand comando;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private bool ProyectosAgregados = false;
        private string _final = "";
        

        public frmDetalleBeneficio(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
            CargarProyectos();
            CargarRelevancias();
            //CargarBeneficios();
        }

       

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDetalleProyecto_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void CargarBeneficios()
        {
            string query = "select b.Beneficio, r.Descripcion, Total from Beneficio as b inner join Proyecto as p on b.idProyecto = p.id_proyecto inner join Relevancia as r on b.idRelevancia = r.idRelevancia where idproyecto = " + cmbProyecto.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(query, conexionBD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridBeneficios.Rows.Clear();
            dataGridBeneficios.Refresh();
            //dataGridBeneficios.DataSource = dt;
            int f = 0;
            int c = 0;
            int f1 = dt.Rows.Count;
            int c1 = dt.Columns.Count;
            MessageBox.Show(c1.ToString());


            foreach (DataRow row in dt.Rows) 
            {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        var field1 = row[c].ToString();
                        
                             
                             MessageBox.Show(field1.ToString());
                            dataGridBeneficios.Rows[f].Cells[c].Value = field1.ToString();
                    }
             }
        }

        private void CargarProyectos()
        {
            try
            {

                DataTable dt = new DataTable();
                comando = new SqlCommand("select * from Proyecto", conexionBD);
                adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);
                cmbProyecto.DataSource = dt;
                cmbProyecto.ValueMember = "id_proyecto";
                cmbProyecto.DisplayMember = "denominacion";     
            }

            catch(SqlException ex)
            {
                MessageBox.Show("Surgio un problema al obtener los proyectos: " + ex.ToString());
            }
        }
        
        private void CargarRelevancias()
        {
            try
            {

                DataTable dt = new DataTable();
                comando = new SqlCommand("select * from Relevancia", conexionBD);
                adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);
                DataGridViewComboBoxColumn dgcmbRelevancia = dataGridBeneficios.Columns["Relevancia"] as DataGridViewComboBoxColumn;
                dgcmbRelevancia.DataSource = dt;
                dgcmbRelevancia.ValueMember = "idRelevancia";
                dgcmbRelevancia.DisplayMember = "Descripcion";
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Surgio un problema al obtener las relevancias: " + ex.ToString());
            }
        }

        
        private void cmbProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
                try
                {

                    comando = new SqlCommand(recorrergrid(), conexionBD);
                    comando.Prepare();
                    comando.ExecuteNonQuery();
                    dataGridBeneficios.Rows.Clear();
                    dataGridBeneficios.Refresh();
                    _final = "";
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Error al guardar beneficios " +
                        ex.Message, "Error al guardad los beneficios",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private string recorrergrid() 
        {
            string _Beneficio = "";
            string _Relevancia = "";
            string _Total = "";
            string query = "";
            for (int i = 0; i < dataGridBeneficios.Rows.Count - 1; i++)
            {
                query = "insert into beneficio (idproyecto, Beneficio, idRelevancia, Total) values ( ";
               _Beneficio = dataGridBeneficios.Rows[i].Cells[0].Value.ToString();
               _Relevancia = dataGridBeneficios.Rows[i].Cells[1].Value.ToString();
               _Total = dataGridBeneficios.Rows[i].Cells[2].Value.ToString();
               query = query + cmbProyecto.SelectedValue.ToString() + ", '" + _Beneficio + "', " + _Relevancia + ", " + _Total + ")" + "\n";
               _final = _final + query;
            }
            return _final;

        }

        
    }
}

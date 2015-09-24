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
    public partial class frmDetalleRecursos : Form
    {
        private SqlConnection conexionBD;
        private SqlCommand comando;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private bool ProyectosAgregados = false;
        private string _final = "";
        

        public frmDetalleRecursos(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
            CargarProyectos();
            CargarRelevancias();
            CargarFuentes();
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

            catch (SqlException ex)
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
                DataGridViewComboBoxColumn dgcmbRelevancia = dataGridRecursos.Columns["Relevancia"] as DataGridViewComboBoxColumn;
                dgcmbRelevancia.DataSource = dt;
                dgcmbRelevancia.ValueMember = "idRelevancia";
                dgcmbRelevancia.DisplayMember = "Descripcion";
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Surgio un problema al obtener las relevancias: " + ex.ToString());
            }
        }

        private void CargarFuentes()
        {
            try
            {

                DataTable dt = new DataTable();
                comando = new SqlCommand("select * from Fuente", conexionBD);
                adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);
                DataGridViewComboBoxColumn dgcmbRelevancia = dataGridRecursos.Columns["Fuente"] as DataGridViewComboBoxColumn;
                dgcmbRelevancia.DataSource = dt;
                dgcmbRelevancia.ValueMember = "idFuente";
                dgcmbRelevancia.DisplayMember = "Fuente";
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Surgio un problema al obtener las fuentes: " + ex.ToString());
            }
        }
        private void cmbProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                comando = new SqlCommand(recorrergrid(), conexionBD);
                comando.Prepare();
                comando.ExecuteNonQuery();
                dataGridRecursos.Rows.Clear();
                dataGridRecursos.Refresh();
                _final = "";
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar Costos " +
                    ex.Message, "Error al guardad los Costos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string recorrergrid()
        {
            string _Recurso = "";
            string _Relevancia = "";
            string _Fuente = "";
            string query = "";
            for (int i = 0; i < dataGridRecursos.Rows.Count - 1; i++)
            {
                query = "insert into RecursoXFuente(idproyecto, Recurso, idFuente, idRelevancia) values ( ";
                _Recurso = dataGridRecursos.Rows[i].Cells[0].Value.ToString();
                _Relevancia = dataGridRecursos.Rows[i].Cells[1].Value.ToString();
                _Fuente = dataGridRecursos.Rows[i].Cells[2].Value.ToString();
                query = query + cmbProyecto.SelectedValue.ToString() + ", '" + _Recurso + "', " + _Fuente + ", " + _Relevancia + ")" + "\n";
                _final = _final + query;
            }
            return _final;

        }
    }
}

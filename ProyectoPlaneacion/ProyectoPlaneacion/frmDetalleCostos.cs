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
    public partial class frmDetalleCostos : Form
    {
        private SqlConnection conexionBD;
        private SqlCommand comando;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private bool ProyectosAgregados = false;
        private string _final = "";
        

        public frmDetalleCostos(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
            CargarProyectos();
            CargarRelevancias();
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
                DataGridViewComboBoxColumn dgcmbRelevancia = dataGridCostos.Columns["Relevancia"] as DataGridViewComboBoxColumn;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
                try
                {

                    comando = new SqlCommand(recorrergrid(), conexionBD);
                    comando.Prepare();
                    comando.ExecuteNonQuery();
                    dataGridCostos.Rows.Clear();
                    dataGridCostos.Refresh();
                    _final = "";
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Error al guardar Costos " +
                        ex.Message, "Error al guardad los Costos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
        }

        private string recorrergrid()
        {
            string _Costo = "";
            string _Relevancia = "";
            string _Total = "";
            string query = "";
            for (int i = 0; i < dataGridCostos.Rows.Count - 1; i++)
            {
                query = "insert into Costos(idproyecto, Costo_Desc, idRelevancia, Total) values ( ";
                _Costo = dataGridCostos.Rows[i].Cells[0].Value.ToString();
                _Relevancia = dataGridCostos.Rows[i].Cells[1].Value.ToString();
                _Total = dataGridCostos.Rows[i].Cells[2].Value.ToString();
                query = query + cmbProyecto.SelectedValue.ToString() + ", '" + _Costo + "', " + _Relevancia + ", " + _Total + ")" + "\n";
                _final = _final + query;
            }
            return _final;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

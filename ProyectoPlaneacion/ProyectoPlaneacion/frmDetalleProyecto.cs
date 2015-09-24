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
    public partial class frmDetalleProyecto : Form
    {
        private SqlConnection conexionBD;
        private SqlCommand comando;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private bool ProyectosAgregados = false;
        

        public frmDetalleProyecto(SqlConnection conexionBD)
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

               
                comando = new SqlCommand("select *from Proyecto", conexionBD);
                adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);

                cmbProyecto.DataSource = dt;
                cmbProyecto.ValueMember = "id_proyecto";
                cmbProyecto.DisplayMember = "denominacion";
                //DataTable resultado = null;
                //comando = new SqlCommand("Select * from Proyecto", conexionBD);
                //adapter = new SqlDataAdapter("Select * from Proyecto", conexionBD);
                //DataSet ds = new DataSet();
                //adapter.Fill(ds);
                //cmbProyecto.DataSource = ds.Tables[0];
                //cmbProyecto.ValueMember = "id_proyecto";
                //cmbProyecto.DisplayMember = "denominacion";
                //reader = comando.ExecuteReader();
                //cmbProyecto.Items.Add(" ");
                //cmbProyecto.ValueMember = reader["id_proyecto"];
                //cmbProyecto.DisplayMember = reader["denominacion"].ToString();
                //while (adapter.Read())
                //{
                //    cmbProyecto.Items.Add(reader["denominacion"].ToString());
                //}
                //reader.Close();

                //comando = new SqlCommand("Select * from Proyecto", conexionBD);
                //conexionBD.Open();
                //reader = comando.ExecuteReader();
                //ArrayList Proyectos = new ArrayList();

                //while (reader.Read())
                //{
                //    Proyectos.Add(new AddValue
                //        (reader.GetString(1), reader.GetInt32(0)));

                //}
                //reader.Close();
                //this.conexionBD.Close();

                //this.cmbProyecto.DataSource = Proyectos;
                //this.cmbProyecto.DisplayMember = "Display";
                //this.cmbProyecto.ValueMember = "Value";
                //ProyectosAgregados = true;   
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


                comando = new SqlCommand("select *from Relevancia", conexionBD);
                adapter = new SqlDataAdapter(comando);
                adapter.Fill(dt);

                //tabControl1.TabPages[0].Controls[]
                cmbProyecto.DataSource = dt;
                cmbProyecto.ValueMember = "idRelevancia";
                cmbProyecto.DisplayMember = "Descripcion";
                //DataTable resultado = null;
                //comando = new SqlCommand("Select * from Proyecto", conexionBD);
                //adapter = new SqlDataAdapter("Select * from Proyecto", conexionBD);
                //DataSet ds = new DataSet();
                //adapter.Fill(ds);
                //cmbProyecto.DataSource = ds.Tables[0];
                //cmbProyecto.ValueMember = "id_proyecto";
                //cmbProyecto.DisplayMember = "denominacion";
                //reader = comando.ExecuteReader();
                //cmbProyecto.Items.Add(" ");
                //cmbProyecto.ValueMember = reader["id_proyecto"];
                //cmbProyecto.DisplayMember = reader["denominacion"].ToString();
                //while (adapter.Read())
                //{
                //    cmbProyecto.Items.Add(reader["denominacion"].ToString());
                //}
                //reader.Close();

                //comando = new SqlCommand("Select * from Proyecto", conexionBD);
                //conexionBD.Open();
                //reader = comando.ExecuteReader();
                //ArrayList Proyectos = new ArrayList();

                //while (reader.Read())
                //{
                //    Proyectos.Add(new AddValue
                //        (reader.GetString(1), reader.GetInt32(0)));

                //}
                //reader.Close();
                //this.conexionBD.Close();

                //this.cmbProyecto.DataSource = Proyectos;
                //this.cmbProyecto.DisplayMember = "Display";
                //this.cmbProyecto.ValueMember = "Value";
                //ProyectosAgregados = true;   
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Surgio un problema al obtener los proyectos: " + ex.ToString());
            }
        }

        
        private void cmbProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}

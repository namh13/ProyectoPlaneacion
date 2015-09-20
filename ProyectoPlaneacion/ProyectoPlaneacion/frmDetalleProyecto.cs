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
    public partial class frmDetalleProyecto : Form
    {
        private SqlConnection conexionBD;

        public frmDetalleProyecto(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
        }

       

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDetalleProyecto_Load(object sender, EventArgs e)
        {
            LlenarProyecto();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LlenarProyecto()
        {
            string ls = "";
            DataTable dt = null;

            ls = @"select *from Proyecto";

            if(auxiliar.c.SQLSelectDataTable(ls,ref dt))
            {
                cmbProyecto.DataSource = dt;
                cmbProyecto.ValueMember = "id_proyecto";
                cmbProyecto.DisplayMember = "denominacion";
            }
        }

    }
}

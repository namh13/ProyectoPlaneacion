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
    public partial class MenuPrincipal : Form
    {
        private SqlConnection conexionBD;
        public MenuPrincipal(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
        }

        public MenuPrincipal() 
        { 
        
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void crearProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1(conexionBD);
            Form1.MdiParent = this;
            Form1.Show();
        }

        private void detalleProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void beneficiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalleBeneficio frmDetalle = new frmDetalleBeneficio(conexionBD);
            frmDetalle.MdiParent = this;
            frmDetalle.Show();
        }

        private void costosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalleCostos frmDetalle = new frmDetalleCostos(conexionBD);
            frmDetalle.MdiParent = this;
            frmDetalle.Show();
        }

        private void recursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalleRecursos frmDetalle = new frmDetalleRecursos(conexionBD);
            frmDetalle.MdiParent = this;
            frmDetalle.Show();
        }

        

    }
}

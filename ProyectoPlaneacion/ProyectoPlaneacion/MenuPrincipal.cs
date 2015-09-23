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
            frmDetalleProyecto frmDetalle = new frmDetalleProyecto(conexionBD);
            frmDetalle.MdiParent = this;
            frmDetalle.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuente fuente = new frmFuente(conexionBD);
            fuente.MdiParent = this;
            fuente.Show();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArea area = new frmArea(conexionBD);
            area.MdiParent = this;
            area.Show(); 
        }

        private void verProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyectos frm = new frmProyectos(conexionBD);
            frm.MdiParent = this;
            frm.Show();
        }

        private void factiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factibilidad frm = new Factibilidad(conexionBD);
            frm.MdiParent = this;
            frm.Show();
        }

        private void noFactiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNoFactible frm = new frmNoFactible(conexionBD);
            frm.MdiParent = this;
            frm.Show();
        }

    }
}

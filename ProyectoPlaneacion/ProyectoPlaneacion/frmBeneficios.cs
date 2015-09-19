using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlaneacion
{
    public partial class frmBeneficios : Form
    {
        public string p_beneficios = "";
        public int p_contador = 0;
        public frmBeneficios()
        {
            InitializeComponent();
        }

        private void frmBeneficios_Load(object sender, EventArgs e)
        {
            LlenarProyecto();
        }
        private void LlenarProyecto()
        {
            string sql = "";
            DataTable dt = null;
            sql = @"select *from Proyecto ";
            if (auxiliar.c.SQLSelectDataTable(sql, ref dt))
            {
                cmbProyecto.DataSource = dt; //the data table which contains data
                cmbProyecto.ValueMember = "id_proyecto";   // column name which you want in SelectedValue
                cmbProyecto.DisplayMember = "proyecto"; // column name that you need to display as text
            }        

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
        }
    }
}

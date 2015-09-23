using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProyectoPlaneacion
{
    public partial class frmProyectos : Form
    {
        public SqlConnection conexionBD;

        public frmProyectos(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
        }

        private void frmProyectos_Load(object sender, EventArgs e)
        {
            CargarProyectos();
        }

        private void CargarProyectos()
        {
            DataTable dt = new DataTable();
            string ls = "";

            ls = @"select p.denominacion, a.descripcionA, p.area_afectada, p.descripcion, p.duracion 
                    from Proyecto p
                    join Area a
                    on p.id_area = a.id_area";
            SqlCommand llenar = new SqlCommand(ls, conexionBD);
            SqlDataAdapter leer = new SqlDataAdapter(llenar);
            leer.Fill(dt);

            dataGridProyectos.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ls = "[dbo].[factibilidad]";
            SqlCommand verificar = new SqlCommand(ls, conexionBD);
            verificar.CommandType = CommandType.StoredProcedure;
            int i = verificar.ExecuteNonQuery();

            if(i>0)
            { MessageBox.Show("Otro rollo");}
            else
            { MessageBox.Show("Nada"); }
        }
    }
}

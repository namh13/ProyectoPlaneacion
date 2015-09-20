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
    public partial class Factibilidad : Form
    {
        public Factibilidad()
        {
            InitializeComponent();
        }

        private void Factibilidad_Load(object sender, EventArgs e)
        {

        }

        private void CargarProyecto()
        {
            string ls = "";
            DataRow dt = null;

            ls = @"select
                        f.id_proyecto
                       ,p.denominacion
                       ,a.descripcion
                       ,p.duracion
                       ,r.Recurso
                       ,b.Beneficio
                       from Factible f
                       join Proyecto p
                       on f.id_proyecto = p.id_proyecto
                       join Area a
                       on p.id_area  = a.id_area
                       join Recurso r
                       on p.id_proyecto = r.id_proyecto
                       join Beneficio b
                       on p.id_proyecto = b.id_proyecto";

            if (auxiliar.c.SQLSelectRow(ls, ref dt))
            {
               //// lblProyecto.Text = dt[""].ToString();
                //txtPoblacion.Text = dr["poblacion"].ToString();
            }
        }
    }
}

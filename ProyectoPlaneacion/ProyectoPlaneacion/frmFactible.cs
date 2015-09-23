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
    public partial class frmFactible : Form
    {
        private SqlConnection conexionBD;
        public string proyecto = "";
        bool  factible;

        public frmFactible(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
        }

        private void CargarProyecto()
        {
            try
            {
                int Proyecto1 = int.Parse(proyecto);
                string ls_sql = "";
                //DataRow dr = null;
               ls_sql=  @"select f.idProyecto, f.Factible, p.denominacion, a.descripcionA, 
                    p.area_afectada, p.descripcion, p.duracion
                    from Factible f 
                    join Proyecto p
                    on f.idProyecto = p.id_proyecto
                    join Area a
                    on p.id_area = a.id_area
                    where f.idProyecto = '" + Proyecto1 + "'";

                SqlCommand llenar = new SqlCommand(ls_sql, conexionBD);
                //conexionBD.Open();
                SqlDataReader leer = llenar.ExecuteReader();
                if (leer.Read() == true)
                {
                    lbl10.Text = leer["Factible"].ToString();
                    lbl1.Text = leer["denominacion"].ToString();
                    lbl2.Text = leer["descripcion"].ToString();
                    lbl3.Text = leer["descripcionA"].ToString();
                    lbl4.Text = leer["area_afectada"].ToString();
                    lbl5.Text = leer["duracion"].ToString() + " Meses";
                }
                leer.Close();
                //conexionBD.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al Cargar la Fuente: " + ex.ToString());
            }
        }

        private void Factibilidades()
        {
            if(lbl10.Text == "True")
            {
                lbl6.Text = "El Proyecto es factible economicamente, ya que brinda mas beneficios que costos.";
                lbl7.Text = "El Proyecto es factible tecnicamente, ya que contamos con las tecnologias necesarias y son confiables.";
                lbl8.Text = "El Proyecto es factible operacional, ya que se cuenta con todos los recursos necesarios.";
            }
            else
            {
                lbl6.Text = "El Proyecto no es factible economicamente, ya que sus costos son mas altos que los beneficios.";
                lbl7.Text = "El Proyecto es factible tecnicamente, ya que contamos con las tecnologias necesarias y son confiables.";
                lbl8.Text = "El Proyecto no es factible operacional, ya que no se cuenta con todos los recursos necesarios.";
            }
            
        }
        private void frmFactible_Load(object sender, EventArgs e)
        {
            CargarProyecto();
            Factibilidades();
        }


       
    }
}

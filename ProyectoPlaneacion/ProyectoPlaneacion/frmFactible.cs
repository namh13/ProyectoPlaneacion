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
                DataRow dr = null;
                ls_sql = @"select p.denominacion, a.descripcionA, p.area_afectada, p.descripcion 
                           ,p.duracion
                            from Proyecto p
                            join Area a
                            on p.id_area = a.id_area
                            where id_proyecto = '" + Proyecto1 + "'";

                SqlCommand llenar = new SqlCommand(ls_sql, conexionBD);
                //conexionBD.Open();
                SqlDataReader leer = llenar.ExecuteReader();
                if (leer.Read() == true)
                {
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

        private void frmFactible_Load(object sender, EventArgs e)
        {
            CargarProyecto();
        }


       
    }
}

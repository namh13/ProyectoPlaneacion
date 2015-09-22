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
    public partial class Area : Form
    {
        private SqlConnection conexionBD;
        public string area = "";

        public Area(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
        }

        
        private void Actualizar()
        {
            try
            {
                //conexionBD.Open();
                string ls_Sql = "";
                ls_Sql = @"update Area set descripcion = @area where id_area = @id ";

                SqlCommand actualizar = new SqlCommand(ls_Sql, conexionBD);
                actualizar.Parameters.AddWithValue("@id", area);
                actualizar.Parameters.AddWithValue("@area", txtArea.Text);
                int fila = actualizar.ExecuteNonQuery();
                if (fila > 0)
                {
                    MessageBox.Show("Se actualizo correctamente El Area");
                    txtArea.Text = "";
                }
                // conexionBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        private void Insertar()
        {
            try
            {
                //conexionBD.Open();
                string ls = "";
                ls = @"insert into Area(descripcion) values(@area)";

                SqlCommand insertar = new SqlCommand(ls, conexionBD);
                insertar.Parameters.AddWithValue("@area", txtArea.Text);
                int filas = insertar.ExecuteNonQuery();
                //conexionBD.Close();
                if (filas > 0)
                {
                    MessageBox.Show("Se inserto correctamente el Area");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarArea()
        {
            try
            {
                int Area1 = int.Parse(area);
                string ls_sql = "";
                DataRow dr = null;
                ls_sql = @"select *from Area where id_area = '" + Area1 + "'";

                SqlCommand llenar = new SqlCommand(ls_sql, conexionBD);
                //conexionBD.Open();
                SqlDataReader leer = llenar.ExecuteReader();
                if (leer.Read() == true)
                {
                    txtArea.Text = leer["descripcionA"].ToString();
                }
                leer.Close();
                //conexionBD.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al Cargar la Fuente: " + ex.ToString());
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtArea.Text != "")
            {
                if (area != "")
                {
                    Actualizar();
                    txtArea.Text = "";
                }
                else
                {
                    Insertar();
                    txtArea.Text = "";
                }
            }
            else
            {
                MessageBox.Show("El area esta Vacia");
            }
           
        }
    }
}

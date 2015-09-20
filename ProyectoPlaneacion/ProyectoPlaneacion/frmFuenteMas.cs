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
    public partial class frmFuenteMas : Form
    {
        private SqlConnection conexionBD;
        public string fuente = "";

        public frmFuenteMas(SqlConnection conexionBD)
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
                ls_Sql = @"update Fuente set Fuente = @fuente where idFuente = @id ";

                SqlCommand actualizar = new SqlCommand(ls_Sql, conexionBD);
                actualizar.Parameters.AddWithValue("@id", fuente);
                actualizar.Parameters.AddWithValue("@fuente", txtFuente.Text);
                int fila = actualizar.ExecuteNonQuery();
                if (fila > 0)
                {
                    MessageBox.Show("Se actualizo correctamente la Fuente");
                }
                // conexionBD.Close();
            }
            catch(Exception ex)
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
                ls = @"insert into Fuente(Fuente) values(@fuente)";

                SqlCommand insertar = new SqlCommand(ls, conexionBD);
                insertar.Parameters.AddWithValue("@fuente", txtFuente.Text);
                int filas = insertar.ExecuteNonQuery();
                //conexionBD.Close();
                if(filas > 0 )
                {
                    MessageBox.Show("Se inserto correctamente la Fuente");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarFuente()
        {
            
            try
            {
                int Fuente = int.Parse(fuente);
                string ls_sql = "";
                DataRow dr = null;
                ls_sql = @"select *from Fuente where idFuente = '"+ Fuente +"'";

                SqlCommand llenar = new SqlCommand(ls_sql, conexionBD);
                //conexionBD.Open();
                SqlDataReader leer = llenar.ExecuteReader();
                if(leer.Read() == true)
                {
                    txtFuente.Text = leer["Fuente"].ToString();
                }
                leer.Close();
                //conexionBD.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al Cargar la Fuente: " + ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtFuente.Text != "")
            {
                if(fuente != "")
                {
                    Actualizar();
                    txtFuente.Text = "";
                }
                else
                {
                    Insertar();
                    txtFuente.Text = "";
                }
            }
            else
            {
                MessageBox.Show("La fuente esta Vacia");
            }
        }

        private void frmFuenteMas_Load(object sender, EventArgs e)
        {
            CargarFuente();
        }
    }
}

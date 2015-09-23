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
    public partial class Form1 : Form
    {

        private SqlConnection conexionBD;

        public Form1(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
        }

        public Form1() 
        { 
        
        }

         private bool Conectar()
        {
            if (auxiliar.c.Conectar("MUNGUIA\\SQLEXPRESS", "Planeacion", "sa", "Elquenosabe13"))
            {
                return true;
            }
            else
            {
                auxiliar.MsgError("Error en la Conexion: " + auxiliar.c.SQLError());
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conectar();
            LlenarArea();
        }

        private void limpiar()
        {
            txtDenominacion.Text = "";
            cmbArea.SelectedIndex = 0;
            txtArea.Text = "";
            txtDescripcion.Text = "";
            dateInicio.Value = DateTime.Now;
            dateFinal.Value = DateTime.Now;
        }
        private void CrearProyecto()
        {
            try
            {
                string sql = "";

                int duracion = 0;
                int dias = (dateFinal.Value - dateInicio.Value).Days;
                if (dias > 30)
                { duracion = dias / 30; }
                else
                { duracion = dias; }

                sql = @"insert into Proyecto(denominacion,id_area,area_afectada,descripcion,fecha_inicio,fecha_final,duracion) 
                    values(@denominacion,@id_area,@area_afectada,@descripcion,@fecha_inicio,@fecha_final,@duracion)";
                SqlCommand insertar = new SqlCommand(sql, conexionBD);
                insertar.Parameters.AddWithValue("@denominacion", txtDenominacion.Text);
                insertar.Parameters.AddWithValue("@id_area", cmbArea.SelectedIndex + 1);
                insertar.Parameters.AddWithValue("@area_afectada", txtArea.Text);
                insertar.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                insertar.Parameters.AddWithValue("@fecha_inicio", dateInicio.Value.ToString("yyyy/mm/dd"));
                insertar.Parameters.AddWithValue("@fecha_final", dateFinal.Value.ToString("yyyy/mm/dd"));
                insertar.Parameters.AddWithValue("@duracion", duracion);
                int fila = insertar.ExecuteNonQuery();

                if (fila > 0)
                {
                    MessageBox.Show("Se Creo Correctamente el Proyecto");
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CrearProyecto();
        }

        private void LlenarArea()
        {
            string ls = "";
            DataTable dt = new DataTable();

            ls = @"select *from Area";
            SqlCommand llenar = new SqlCommand(ls, conexionBD);
            SqlDataAdapter leer = new SqlDataAdapter(llenar);
            leer.Fill(dt);

            cmbArea.DataSource = dt;
            cmbArea.ValueMember = "id_area";
            cmbArea.DisplayMember = "descripcionA";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Area frm = new Area(conexionBD);
            frm.ShowDialog(this);
            LlenarArea();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            //this.Close();
        }

    }
}

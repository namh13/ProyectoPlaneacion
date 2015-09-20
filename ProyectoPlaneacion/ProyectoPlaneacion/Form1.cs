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


        private void CrearProyecto()
        {
            string sql = "";

            int duracion = 0;
            int dias = (dateFinal.Value - dateInicio.Value).Days;
            if (dias > 30)
            {duracion = dias / 30;}
            else
            {duracion = dias;}

            sql = @"insert into Proyecto(denominacion,id_area,area_afectada,descripcion,fecha_inicio,fecha_final,duracion) 
                    values('{0}',{1},'{2}','{3}','{4}','{5}',{6})";
            sql = string.Format(sql, txtDenominacion.Text, cmbArea.SelectedIndex + 1, txtArea.Text, txtDescripcion.Text, dateInicio.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"),duracion);

            if (auxiliar.c.SqlExec(sql))
            {
                MessageBox.Show("Proyecto insertado correctamente");
                //Limpiar();
            }
            else
            {
                MessageBox.Show("Error al ingresar Proyecto:" + auxiliar.c.SQLError());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CrearProyecto();
        }

        private void LlenarArea()
        {
            string ls = "";
            DataTable dt = null;

            ls = @"select *from Area";

            if (auxiliar.c.SQLSelectDataTable(ls, ref dt))
            {
                cmbArea.DataSource = dt;
                cmbArea.ValueMember = "id_area";
                cmbArea.DisplayMember = "descripcion";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Area frm = new Area(conexionBD);
            frm.ShowDialog(this);
            LlenarArea();
        }

    }
}

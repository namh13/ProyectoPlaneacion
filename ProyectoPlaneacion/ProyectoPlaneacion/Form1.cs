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
    public partial class Form1 : Form
    {
        int contadorF = 0;
        int contadorR = 0;
        int contadorB = 0;
        int contadorFuncionario = 0;
        int contadorAreas = 0;


        public Form1()
        {
            InitializeComponent();
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
        }

       

        private void ContadorAreas()
        {
            string area = cmbArea.SelectedItem.ToString();
            if (area == "Administracion" || area == "Ventas")
            {
                contadorAreas += 3;
            }
            if (area == "Otra")
            {
                contadorAreas += 1;
            }
            if (area != "Administracion" && area != "Ventas" && area != "Otra")
            {
                contadorAreas += 2;
            }
        }

        private void CrearProyecto()
        {
            string sql = "";



            sql = @"insert into Proyecto(denominacion,area_solicitante,area_afectada,descripcion,fecha_inicio,fecha_final) 
                    values('{0}','{1}','{2}','{3}','{4}','{5}')";
            sql = string.Format(sql, txtDenominacion.Text, cmbFuncionario.SelectedItem.ToString(), txtArea.Text, txtDescripcion.Text, dateInicio.Value.ToString("yyyy-MM-dd"), dateFinal.Value.ToString("yyyy-MM-dd"));

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

    }
}

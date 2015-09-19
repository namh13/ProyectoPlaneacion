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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void CrearArea()
        {
            string ls = "";

            ls = @"insert into Area(descripcion) values('{0}')";
            ls = string.Format(ls, txtArea.Text);

            if (auxiliar.c.SqlExec(ls))
            {
                MessageBox.Show("Area creada correctamente");
                txtArea.Text = "";
            }
            else
            {
                MessageBox.Show("Error al crear Area:" + auxiliar.c.SQLError());
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtArea.Text != "")
            {
                CrearArea();
            }
            else
            {
                MessageBox.Show("El area esta Vacia");
            }
           
        }
    }
}

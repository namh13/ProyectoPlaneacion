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
using System.Threading;

namespace ProyectoPlaneacion
{
    public partial class frmLogin : Form
    {
        private SqlConnection conexionBD;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void EjecutarMenu()
        {
            MenuPrincipal MenuForm = new MenuPrincipal(conexionBD);
            MenuForm.ShowDialog();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if (conexionBD != null)
                conexionBD.Close();

            string connStr =
                String.Format("server={0};user id={2}; password={3}; " +
                "database=planeacion; pooling=false;",
                txtServidor.Text, txtPuerto.Text, txtUsuario.Text, txtContrasena.Text);
            try
            {
                conexionBD = new SqlConnection(connStr);
                conexionBD.Open();

                //MessageBox.Show("Conexion Satifactoria");
                Thread NuevoHilo = new Thread(new ThreadStart(EjecutarMenu));
                this.Close();
                NuevoHilo.SetApartmentState(System.Threading.ApartmentState.STA);
                NuevoHilo.Start();
                //WorkSpace WorkSpaceForm = new WorkSpace();
                //WorkSpaceForm.Show();
                //this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor de MySQL: " +
                    ex.Message, "Error al conectar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

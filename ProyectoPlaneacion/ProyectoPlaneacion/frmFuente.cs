﻿using System;
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
    public partial class frmFuente : Form
    {
        public string p_fuente = "";
        public int p_contador = 0;
        
        private SqlConnection conexionBD;

        public frmFuente(SqlConnection conexionBD)
        {
            InitializeComponent();
            this.conexionBD = conexionBD;
        }

        private void frmFuente_Load(object sender, EventArgs e)
        {
            CargarFuentes();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmFuenteMas frm = new frmFuenteMas(conexionBD);
            frm.ShowDialog(this);
            CargarFuentes();
        }
        private void CargarFuentes()
        {
            try
            {
                DataTable dt = new DataTable();
                //conexionBD.Open();
                string ls = @"select *from Fuente";
                SqlCommand cargar = new SqlCommand(ls, conexionBD);
                SqlDataAdapter llenar = new SqlDataAdapter(cargar);
                llenar.Fill(dt);

                dataGridView1.DataSource = dt;
                //conexionBD.Close();
            }
            catch(Exception ex)
            {

            }
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string fuente = "";

            if (dataGridView1.RowCount > 0)
            {
                fuente = dataGridView1.CurrentRow.Cells["n_id"].Value.ToString();

                frmFuenteMas frm = new frmFuenteMas(conexionBD);
                frm.fuente = fuente;
                frm.ShowDialog(this);
                CargarFuentes();
            }
        }

        private void EliminarRegistro()
        {
            try 
            {
                string ls = "";
                ls = @"delete from Fuente where idFuente = @Fuente";
                string fila = dataGridView1.CurrentRow.Cells["n_id"].Value.ToString();

                SqlCommand borrar = new SqlCommand(ls, conexionBD);
                borrar.Parameters.AddWithValue("@Fuente", fila);
                borrar.ExecuteNonQuery();
                //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                CargarFuentes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }
    }
}

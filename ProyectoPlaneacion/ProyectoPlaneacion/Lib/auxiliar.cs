using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlaneacion
{
    public static class auxiliar
    {
        public static ConexionSQL c = new ConexionSQL();

        public static void MsgError(string ps_mensaje)
        {
            if (ps_mensaje.Contains("connection"))
            {
                ps_mensaje = "Hubo un problema de conexion a la base de datos";
            }


            MessageBox.Show(ps_mensaje, "Error");
        }
    }
}
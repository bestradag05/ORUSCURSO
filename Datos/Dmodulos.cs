using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ORUSCURSO.Datos
{
    public  class Dmodulos
    {

        public void mostrar_modulos(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("select * from Modulos", CONEXIONMAESTRA.conectar);
                da.Fill(dt);


            }
            catch (Exception ex) {
                MessageBox.Show(ex.StackTrace);
            }
            finally {
                CONEXIONMAESTRA.cerrar();
            }
            
        }
    }
}

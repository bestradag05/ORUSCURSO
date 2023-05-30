using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ORUSCURSO.Logica;

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

        public bool Insertar_Modulos(Lmodulos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Modulos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Modulo", parametros.Modulo);
                cmd.ExecuteNonQuery();
                return true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace); 
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar() ;  
            }
            

        }
    }
}

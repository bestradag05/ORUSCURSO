using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion
{
    public partial class copiasBD : UserControl
    {
        public copiasBD()
        {
            InitializeComponent();
        }
        string ruta;
        string txtsoftware = "Orus369";
        string base_de_datos = "ORUS369";
        private Thread Hilo;
        private bool acaba = false;

        private void copiasBD_Load(object sender, EventArgs e)
        {
            mostrarRuta();

        } 

        private void mostrarRuta()
        {
            Dcopiasbd funcion = new Dcopiasbd(); 
            funcion.MostrarRuta(ref ruta);
            txtRuta.Text = ruta;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarCopia();
        }

        private void  GenerarCopia()
        {
            if(!string.IsNullOrEmpty(txtRuta.Text))
            {
                Hilo = new Thread(new ThreadStart(ejecucion));
                Hilo.Start();
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Selecciona una ruta donde guardar las copias de seguridad");
                txtRuta.Focus();
            }
        }

        private void ejecucion()
        {
            string miCarpeta = "copias_de_seguridad_de_" + txtsoftware;
            if(System.IO.Directory.Exists(txtRuta.Text + miCarpeta))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(txtRuta.Text + miCarpeta);
            }
            string ruta_completa = txtRuta.Text + @"\" + miCarpeta;
            string SubCarpeta = ruta_completa + @"\Respaldo_al_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute;
            try
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(ruta_completa, SubCarpeta));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                
            }

            try
            {
                string v_nombre_respaldo = base_de_datos + ".bak";
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("BACKUP DATABASE " + base_de_datos + " TO DISK = '" + SubCarpeta + @"\" + v_nombre_respaldo + "'", CONEXIONMAESTRA.conectar);
                cmd.ExecuteNonQuery();
                acaba = true;
            }
            catch (Exception ex)
            {
                acaba= false;
                MessageBox.Show(ex.StackTrace);
                
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            ObtenerRuta();
        }

        private void ObtenerRuta()
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ObtenerRuta();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(acaba==true)
            {
                timer1.Stop();
                editarRespaldos();
            }
        }

        private void editarRespaldos()
        {
            Lcopiasbd parametros = new Lcopiasbd();
            Dcopiasbd funcion = new Dcopiasbd();

            parametros.Ruta = txtRuta.Text;
          if(  funcion.EditarCopiasBd(parametros) == true)
            {
                MessageBox.Show("Copias de seguridad generadas");
            }
        }
    }
}

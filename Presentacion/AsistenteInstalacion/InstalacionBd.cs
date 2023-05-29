using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion.AsistenteInstalacion
{
    public partial class InstalacionBd : Form
    {
        public InstalacionBd()
        {
            InitializeComponent();
        }
        string nombre_del_equipo_usuario;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InstalacionBd_Load(object sender, EventArgs e)
        {
            centrarPaneles();
            Reemplazar();
        }

        private void centrarPaneles()
        {
            panelInstalacion.Location = new Point((Width - panelInstalacion.Width) / 2, (Height - panelInstalacion.Height) / 2);
            nombre_del_equipo_usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Cursor = Cursors.WaitCursor;
            panel3.Visible = false;
            panel3.Dock = DockStyle.None;

           
        }

        private void Reemplazar()
        {
            //Solo modificar este campo
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text.Replace("ORUS369", TXTbasededatos.Text);

            //************************

            txtEliminarBase.Text = txtEliminarBase.Text.Replace("BASEADACURSO", TXTbasededatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("ada369", txtusuario.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("BASEADA", TXTbasededatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("softwarereal", lblcontraseña.Text);
            // Adjuntando al texbox que contiene los procedimientos almacenados
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text + Environment.NewLine + txtCrearUsuarioDb.Text;
        }

        private void comprobar_si_ya_hay_servidor_instalado_SQL_EXPRESS()
        {
            txtservidor.Text = @".\" + lblnombredeservicio.Text;
            
        }

        private void ejecutar_scryt_ELIMINARBASE_comprobacion_de_inicio()
        {
            string str;
            SqlConnection myConn = new SqlConnection("Data source =" + txtservidor.Text + ";Initial catalog=master;Integrated Security=True");
            str = txtEliminarBase.Text;
            SqlCommand myComand = new SqlCommand(str, myConn);

            try
            {
                myConn.Open();
                myComand.ExecuteNonQuery();

            }catch (Exception)
            {

            }
            finally
            {
                if(myConn.State == ConnectionState.Open)
                {
                    myConn.Close();

                }
            }
        }

        private void ejecutar_scryt_crearBase_comprobacion_de_inicio()
        {
            SqlConnection cnn = new SqlConnection("Server=" + txtservidor.Text + " ; " + "database=master; integrated security=yes");
            string s = "CREATE DATABASE" + TXTbasededatos.Text;
            SqlCommand cmd = new SqlCommand(s, cnn);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();

            }catch (Exception)
            {

            }
        }
    }
}

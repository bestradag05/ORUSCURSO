using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        public int Idusuarios;
        public string LoginV;
        string Base_de_datos = "ORUS369";
        string servidor = @".\SQLEXPRESS";
        string ruta;

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
            validarPermisos();
            lblLogin.Text = LoginV;



        }

        private void validarPermisos()
        {
            DataTable dt = new DataTable();
            Dpermisos funcion = new Dpermisos();
            Lpermisos parametros = new Lpermisos();
            parametros.IdUsuario = Idusuarios;
            funcion.mostrar_Permisos(ref dt, parametros);
            btnConsultas.Enabled = false;
            btnPersonal.Enabled = false;
            btnRegistro.Enabled = false;
            btnUsuarios.Enabled = false;
            btnRestaurar.Enabled = false;
            btnRespaldos.Enabled = false;

            foreach(DataRow rowPermisos in dt.Rows)
            {
                string Modulo = Convert.ToString(rowPermisos["Modulo"]);
                if(Modulo=="PrePlanilla")
                {
                    btnConsultas.Enabled = true;

                }
                if (Modulo == "Usuario")
                {
                    btnUsuarios.Enabled = true;
                    btnRegistro.Enabled = true;

                }
                if (Modulo == "Personal")
                {
                    btnPersonal.Enabled = true;
                   
                }
                if (Modulo == "Respaldo")
                {
                    btnRespaldos.Enabled = true;
                    btnRestaurar.Enabled = true;
                }
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            Preplanilla control = new Preplanilla();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            Personal control = new Personal();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            CtlUsuarios control = new CtlUsuarios();    
            PanelPadre.Controls.Add(control);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Dispose();
            TomarAsistencias frm = new TomarAsistencias();
            frm.ShowDialog();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            RestaurarBdExpress();
        }

        private void RestaurarBdExpress()
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Backup " + Base_de_datos + "|*.back";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador Backup";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ruta = Path.GetFullPath(dlg.FileName);
                DialogResult pregunta = MessageBox.Show("Usted  está a punto  de restaurar la base de datos, asegurese" +
                    "que el archivo .bak sea reciente, de lo contrario podria perder informacion y no podra recuperarla," +
                    "¿Desea continuar?", "Restauracion de base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(pregunta == DialogResult.Yes )
                {

                    SqlConnection cmd = new SqlConnection("Server=" + servidor + ";database=master; integrated security=yes");
                    try
                    {
                        cmd.Open();
                        string Proceso = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + Base_de_datos + "' Use [master] ALTER DATABASE [" + Base_de_datos + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [" + Base_de_datos + "] RESTORE DATABASE " + Base_de_datos + "FROM DISK = N'" + ruta + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                        SqlCommand BorrarRestaurar = new SqlCommand(Proceso, cmd);
                        BorrarRestaurar.ExecuteNonQuery();
                        MessageBox.Show("La base de datos ha sido restaurada satisfactoriamente! Vuelve a iniciar el aplicativo", "Restauracion de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Dispose();
                    }
                    catch (Exception ex)
                    {
                        RestaurarNoExpress();


                    }
                    finally
                    {
                        if(cmd.State == ConnectionState.Open) 
                        {
                            cmd.Close();
                        }
                    }
                }
            }
        }

        private void RestaurarNoExpress()
        {
            servidor = ".";
            SqlConnection cmd = new SqlConnection("Server=" + servidor + ";database=master; integrated security=yes");
            try
            {
                cmd.Open();
                string Proceso = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + Base_de_datos + "' Use [master] ALTER DATABASE [" + Base_de_datos + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE [" + Base_de_datos + "] RESTORE DATABASE " + Base_de_datos + "FROM DISK = N'" + ruta + "' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                SqlCommand BorrarRestaurar = new SqlCommand(Proceso, cmd);
                BorrarRestaurar.ExecuteNonQuery();
                MessageBox.Show("La base de datos ha sido restaurada satisfactoriamente! Vuelve a iniciar el aplicativo", "Restauracion de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dispose();
            }
            catch (Exception ex)
            {


            }

        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            copiasBD control = new copiasBD();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
        }
    }
}

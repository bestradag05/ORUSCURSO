using ORUSCURSO.Datos;
using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO.Presentacion.AsistenteInstalacion
{
    public partial class UsuariosPrincipal : Form
    {
        public UsuariosPrincipal()
        {
            InitializeComponent();
        }
        int idUsuario;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                if (!string.IsNullOrEmpty(txtcontraseña.Text))
                {
                    if (txtcontraseña.Text == txtconfirmarcontraseña.Text)
                    {
                        insertarUsuarioDefecto();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinsiden", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Falta ingresar la contraseña", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Falta ingresar el Nombre", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertarUsuarioDefecto()
        {
            Lusuario parametros = new Lusuario();
            Dusuario funcion = new Dusuario();

            parametros.Nombre = txtnombre.Text;
            parametros.Login = txtusuario.Text;
            parametros.Password = txtcontraseña.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();

            if (funcion.InsertarUsusarios(parametros) == true)
            {
                InsertarCopiasBd();
                Insertar_Modulos();
                ObtenerIdUsuario();
                insertarPermisos();

            }

        }

        private void InsertarCopiasBd()
        {
            Dcopiasbd funcion=new Dcopiasbd();
            funcion.InsertarCopiasBd();
        }

        private void insertarPermisos()
        {
            DataTable dt = new DataTable(); 
            Dmodulos funcionModulos=new Dmodulos();
            funcionModulos.mostrar_modulos(ref dt);
            foreach(DataRow row in dt.Rows)
            {
                int idModulo = Convert.ToInt32(row["IdModulo"]);
                Lpermisos parametros = new Lpermisos();
                Dpermisos funcion = new Dpermisos();
                
                parametros.IdModulo = idModulo;
                parametros.IdUsuario = idUsuario;
                funcion.Insertar_Permisos(parametros);
                
            }
            MessageBox.Show("!LISTO! RECUERDA que para Iniciar Sesión tu Usuario es: " + txtusuario.Text + " y tu Contraseña es: " + txtcontraseña.Text, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }


        private void ObtenerIdUsuario()
        {
            Dusuario funcion = new Dusuario();

            funcion.ObtenerIdUsuario(ref idUsuario, txtusuario.Text);
        }

        private void Insertar_Modulos ()
        {
            Lmodulos parametros=new Lmodulos();
            Dmodulos funcion=new Dmodulos();

            var Modulos = new List<string> { "Usuario", "Respaldo", "Personal", "PrePlanilla" };
            foreach(var Modulo in Modulos)
            {
                parametros.Modulo = Modulo;
                funcion.Insertar_Modulos(parametros);
            }
        }
    }
}

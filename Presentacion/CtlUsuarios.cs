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

namespace ORUSCURSO.Presentacion
{
    public partial class CtlUsuarios : UserControl
    {
        public CtlUsuarios()
        {
            InitializeComponent();
        }

        int Idusuario;
        string login;
        string estado;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            habilitarPaneles();
            MostrarModulos();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtUsuario.Enabled = true;
            datalistadoModulos.Enabled = true;

        }

        private void habilitarPaneles()
        {
            panelRegistro.Visible = true;
            lblanunciodeicono.Visible = true;
            panelIcono.Visible = false;
            panelRegistro.Dock = DockStyle.Fill;
            panelRegistro.BringToFront();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;



        }

        private void MostrarModulos()
        {
            Dmodulos funcion = new Dmodulos();
             
            DataTable dt = new DataTable();
            funcion.mostrar_modulos(ref dt);
            datalistadoModulos.DataSource = dt;
            datalistadoModulos.Columns[1].Visible = false;
        }

        

        private void panelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {

                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtContraseña.Text))
                    {
                        if (lblanunciodeicono.Visible == false)
                        {
                            insertarUsuario();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un icono");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el usuario");
                }

            }
            else
            {
                MessageBox.Show("Ingrese el nombre");
            }
        }

        private void insertarUsuario()
        {
            Lusuario parametros = new Lusuario();
            Dusuario funcion = new Dusuario();

            parametros.Nombre = txtNombre.Text; 
            parametros.Login  = txtUsuario.Text;
            parametros.Password = txtContraseña.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if(funcion.InsertarUsusarios(parametros))
            {
                ObtenerIdUsuario();
                InsertarPermisos();

            }
        }

        private void MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            Dusuario funcion = new Dusuario();
            funcion.mostrar_Usuarios(ref dt);
            datalistadoUsuarios.DataSource = dt;
            DiseñarDtvUsuarios();


        }

        private void InsertarPermisos()
        {
            foreach (DataGridViewRow row in datalistadoModulos.Rows)
            {
                int IdModulo = Convert.ToInt32(row.Cells["IdModulo"].Value);
                bool marcado = Convert.ToBoolean(row.Cells["Marcar"].Value);
                if (marcado == true)
                {
                    Lpermisos parametros = new Lpermisos();

                    Dpermisos funcion = new Dpermisos();

                    parametros.IdModulo = IdModulo;
                    parametros.IdUsuario = Idusuario;

                    funcion.Insertar_Permisos(parametros);

                        


                    
                }
            }

            MostrarUsuario();
            panelRegistro.Visible = false;
        }

        private void MostrarUsuario()
        {
            DataTable dt = new DataTable();
            Dusuario funcion = new Dusuario();

            funcion.mostrar_Usuarios(ref dt);

            datalistadoUsuarios.DataSource = dt;

            DiseñarDtvUsuarios();

        }

        private void DiseñarDtvUsuarios()
        {
            Bases.DiseñoDtv(ref datalistadoUsuarios);
            Bases.DiseñoDtvEliminar(ref datalistadoUsuarios);
            datalistadoUsuarios.Columns[2].Visible = false;
            datalistadoUsuarios.Columns[5].Visible = false;
            datalistadoUsuarios.Columns[6].Visible = false;
        }

        private void ObtenerIdUsuario()
        {
            Dusuario funcion = new Dusuario();
            funcion.ObtenerIdUsuario(ref Idusuario, txtUsuario.Text);
        }

        private void lblanunciodeicono_Click(object sender, EventArgs e)
        {
            MostrarPanelIcono();
        }

        private void MostrarPanelIcono()
        {
            panelIcono.Visible = true;
            panelIcono.Dock = DockStyle.Fill;
            panelIcono.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox3.Image;
            ocultarPanelIconos();
        }

        private void ocultarPanelIconos()
        {
            panelIcono.Visible=false;
            lblanunciodeicono.Visible=false;
            Icono.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox4.Image;
            ocultarPanelIconos();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox5.Image;
            ocultarPanelIconos();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox6.Image;
            ocultarPanelIconos();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox7.Image;
            ocultarPanelIconos();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox8.Image;
            ocultarPanelIconos();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox9.Image;
            ocultarPanelIconos();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox10.Image;
            ocultarPanelIconos();
        }

       

        private void Icono_Click(object sender, EventArgs e)
        {
            MostrarPanelIcono(); 
        }

        private void agregarIconoPc_Click_1(object sender, EventArgs e)
        {
            dlg.InitialDirectory = ""; //para abrir la carpeta para subir imagen
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Icono.BackgroundImage = null;
                Icono.Image = new Bitmap(dlg.FileName);
                ocultarPanelIconos();
            }
        }

        private void CtlUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuario();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit (e.KeyChar)) {

                e.Handled = false;

            }else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ocultarPanelIconos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtContraseña.Text))
                    {
                        if (lblanunciodeicono.Visible == false)
                        {
                            editarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un Icono");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");


                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario");


                }
            }
            else
            {

                MessageBox.Show("Ingrese el Nombre");
            }
        }

        private void datalistadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadoUsuarios.Columns["Editar"].Index)
            {
                obtenerEstado();
                if (estado == "ELIMINADO")
                {
                    DialogResult resultado = MessageBox.Show("Este Usuario se Elimino. ¿Desea Volver a Habilitarlo?", "Restauracion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        RestaurarUsuario();
                    }
                }
                else
                {
                    ObtenerDatos();
                }

            }
            if (e.ColumnIndex == datalistadoUsuarios.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Realmente desea eliminar este Registro?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    capturarIdUsuario();
                    EliminarUsuarios();
                }

            }
        }

        private void RestaurarUsuario()
        {
            capturarIdUsuario();
            Lusuario parametros = new Lusuario();
            Dusuario funcion = new Dusuario();
            parametros.IdUsuario = Idusuario;
            if (funcion.restaurar_usuario(parametros) == true)
            {
                MostrarUsuarios();
            }
        }
        private void EliminarUsuarios()
        {
            Lusuario parametros = new Lusuario();
            Dusuario funcion = new Dusuario();
            parametros.IdUsuario = Idusuario;
            parametros.Login = login;
            if (funcion.eliminar_Usuarios(parametros) == true)
            {
                MostrarUsuarios();
            }
        }
        private void obtenerEstado()
        {
            estado = datalistadoUsuarios.SelectedCells[7].Value.ToString();
        }
        private void ObtenerDatos()
        {
            capturarIdUsuario();
            txtNombre.Text = datalistadoUsuarios.SelectedCells[3].Value.ToString();
            txtUsuario.Text = datalistadoUsuarios.SelectedCells[4].Value.ToString();
            if (txtUsuario.Text == "admin")
            {
                txtUsuario.Enabled = false;
                datalistadoModulos.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                datalistadoModulos.Enabled = true;
            }
            txtContraseña.Text = datalistadoUsuarios.SelectedCells[5].Value.ToString();

            Icono.BackgroundImage = null;
            byte[] b = (byte[])(datalistadoUsuarios.SelectedCells[6].Value);
            MemoryStream ms = new MemoryStream(b);
            Icono.Image = Image.FromStream(ms);
            panelRegistro.Visible = true;
            panelRegistro.Dock = DockStyle.Fill;
            lblanunciodeicono.Visible = false;
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;
            MostrarModulos();
            mostrarPermisos();
        }


        private void mostrarPermisos()
        {
            DataTable dt = new DataTable();
            Dpermisos funcion = new Dpermisos();
            Lpermisos parametros = new Lpermisos();
            parametros.IdUsuario = Idusuario;
            funcion.mostrar_Permisos(ref dt, parametros);
            foreach (DataRow rowPermisos in dt.Rows)
            {
                int idmoduloPermisos = Convert.ToInt32(rowPermisos["IdModulo"]);
                foreach (DataGridViewRow rowModulos in datalistadoModulos.Rows)
                {
                    int Idmodulo = Convert.ToInt32(rowModulos.Cells["IdModulo"].Value);
                    if (idmoduloPermisos == Idmodulo)
                    {
                        rowModulos.Cells[0].Value = true;
                    }
                }
            }
        }
        private void capturarIdUsuario()
        {
            Idusuario = Convert.ToInt32(datalistadoUsuarios.SelectedCells[2].Value);
            login = datalistadoUsuarios.SelectedCells[4].Value.ToString();


        }


        private void editarUsuarios()
        {
            Lusuario parametros = new Lusuario();
            Dusuario funcion = new Dusuario();
            parametros.IdUsuario = Idusuario;
            parametros.Nombre = txtNombre.Text;
            parametros.Login = txtUsuario.Text;
            parametros.Password = txtContraseña.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.editar_Usuarios(parametros) == true)
            {
                eliminarPermisos();
                InsertarPermisos();
            }
        }
        private void eliminarPermisos()
        {
            Lpermisos parametros = new Lpermisos();
            Dpermisos funcion = new Dpermisos();
            parametros.IdUsuario = Idusuario;
            funcion.eliminar_Permisos(parametros);

        }

        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }
        private void BuscarUsuarios()
        {
            DataTable dt = new DataTable();
            Dusuario funcion = new Dusuario();
            funcion.buscar_Usuarios(ref dt, txtbuscador.Text);
            datalistadoUsuarios.DataSource = dt;
            DiseñarDtvUsuarios();
        }


    }
}

using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;

namespace Annies_Store.Views
{
    public partial class CrudUsuarios : Page
    {
        readonly CN_Usuarios objeto_CN_Usuarios = new CN_Usuarios();
        readonly CE_Usuarios objeto_CE_Usuarios = new CE_Usuarios();
        readonly CN_Privilegio objeto_CN_Privilegios = new CN_Privilegio();


        #region Inicial
        public CrudUsuarios()
        {
            InitializeComponent();
            CargarCB();
        }
        #endregion
        #region Regresar
        private void Regresar(object sender, RoutedEventArgs e)
        {
            Content = new Usuarios();
        }
        #endregion
        #region Cargar Privilegios
        void CargarCB() 
        {
            List<string> privilegios = objeto_CN_Privilegios.ListarPrivilegios();
            for(int i=0; i<privilegios.Count; i++)
            {
                cbPrivilegio.Items.Add(privilegios[i]);
            }
        }
        #endregion
        #region ValidarCamposVacio
        public bool CamposLlenos()
        {
            if (TbNombres.Text == "" || TbApellidos.Text == "" || TbCI.Text == "" || TbNIT.Text == "" || TbCorreo.Text == "" || TbTelefono.Text == "" || TbFechaDeNacimiento.Text == "" || cbPrivilegio.Text == "" || tbUsuario.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
        #region Crud (Create, Read, Update, Delete)

        public int IdUsuario;
        public string Patron = "InfoToolsSV";

        #region Crear
        private void Crear(object sender, RoutedEventArgs e)
        {
            if(CamposLlenos()==true && tbContrasenia.Text !="")
            {

                int privilegio = objeto_CN_Privilegios.IdPrivilegio(cbPrivilegio.Text);

                objeto_CE_Usuarios.Nombre = TbNombres.Text;
                objeto_CE_Usuarios.Apellidos = TbApellidos.Text;
                objeto_CE_Usuarios.CI = int.Parse(TbCI.Text);
                objeto_CE_Usuarios.NIT = int.Parse(TbNIT.Text);
                objeto_CE_Usuarios.Correo = TbCorreo.Text;
                objeto_CE_Usuarios.Telefono = int.Parse(TbTelefono.Text);
                objeto_CE_Usuarios.Fecha_Nac = DateTime.Parse(TbFechaDeNacimiento.Text);
                objeto_CE_Usuarios.Privilegio = privilegio;
                objeto_CE_Usuarios.Img = data;
                objeto_CE_Usuarios.Usuario = tbUsuario.Text;
                objeto_CE_Usuarios.Contrasenia = tbContrasenia.Text;
                objeto_CE_Usuarios.Patron = Patron;

                objeto_CN_Usuarios.Insertar(objeto_CE_Usuarios);

                Content = new Usuarios();
            }
            else
            {
                MessageBox.Show("Los campos no pueden quedar vacíos!");
            }
        }
        #endregion 
        #region Read
        public void Consultar()
        {
            var a = objeto_CN_Usuarios.Consulta(IdUsuario);
            TbNombres.Text = a.Nombre.ToString();
            TbApellidos.Text = a.Apellidos.ToString();
            TbCI.Text = a.CI.ToString();
            TbNIT.Text = a.NIT.ToString();
            TbCorreo.Text = a.Correo.ToString();
            TbTelefono.Text = a.Telefono.ToString();
            TbFechaDeNacimiento.Text = a.Fecha_Nac.ToString();
            

            var b = objeto_CN_Privilegios.NombrePrivilegio(a.Privilegio);
            cbPrivilegio.Text = b.NombrePrivilegio;

            ImageSourceConverter imgs = new ImageSourceConverter();
            imagen.Source = (ImageSource)imgs.ConvertFrom(a.Img);
            tbUsuario.Text = a.Usuario.ToString();
        }
        #endregion
        #region Update
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            if(CamposLlenos()==true)
            {
                int privilegio = objeto_CN_Privilegios.IdPrivilegio(cbPrivilegio.Text);

                objeto_CE_Usuarios.IdUsuario = IdUsuario;
                objeto_CE_Usuarios.Nombre = TbNombres.Text;
                objeto_CE_Usuarios.Apellidos = TbApellidos.Text;
                objeto_CE_Usuarios.CI = int.Parse(TbCI.Text);
                objeto_CE_Usuarios.NIT = int.Parse(TbNIT.Text);
                objeto_CE_Usuarios.Correo = TbCorreo.Text;
                objeto_CE_Usuarios.Telefono = int.Parse(TbTelefono.Text);
                objeto_CE_Usuarios.Fecha_Nac = DateTime.Parse(TbFechaDeNacimiento.Text);
                objeto_CE_Usuarios.Privilegio = privilegio;
                objeto_CE_Usuarios.Usuario = tbUsuario.Text;

                objeto_CN_Usuarios.ActualizarDatos(objeto_CE_Usuarios);

                Content = new Usuarios();

            }
            else
            {
                MessageBox.Show("Los campos no pueden quedar vacíos!");
            }

            if(tbContrasenia.Text != "")
            {
                objeto_CE_Usuarios.IdUsuario = IdUsuario;
                objeto_CE_Usuarios.Contrasenia = tbContrasenia.Text;
                objeto_CE_Usuarios.Patron = Patron;

                objeto_CN_Usuarios.ActualizarPass(objeto_CE_Usuarios);
                Content = new Usuarios();
            }

            if(imagensubida==true)
            {
                objeto_CE_Usuarios.IdUsuario = IdUsuario;
                objeto_CE_Usuarios.Img = data;

                objeto_CN_Usuarios.ActualizarIMG(objeto_CE_Usuarios);
                Content = new Usuarios();
            }
        }
        #endregion
        #region Delete
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            objeto_CE_Usuarios.IdUsuario = IdUsuario;

            objeto_CN_Usuarios.Eliminar(objeto_CE_Usuarios);

            Content = new Usuarios();
        }
        #endregion

        #endregion
        #region Imagen
        byte[] data;
        private bool imagensubida = false;

        private void Subir(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                data = new byte[fs.Length];
                fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                ImageSourceConverter imgs = new ImageSourceConverter();
                imagen.SetValue(Image.SourceProperty, imgs.ConvertFromString(ofd.FileName.ToString()));                
            }
            imagensubida = true;
        }
        #endregion
    }
}

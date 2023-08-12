using System.Windows;
using System.Windows.Controls;
using Capa_Negocio;

namespace Annies_Store.Views
{
    public partial class Usuarios : UserControl
    {
        readonly CN_Usuarios objeto_CN_Usuarios = new CN_Usuarios();

        #region Inicial
        public Usuarios()
        {
            InitializeComponent();
            Buscar(""); 
        }
        #endregion

        #region Agregar
        private void Agregar(object sender, RoutedEventArgs e)
        {
            CrudUsuarios ventana = new CrudUsuarios();
            FrameUsuarios.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }
        #endregion

        #region Consultar
        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudUsuarios ventana = new CrudUsuarios();
            ventana.IdUsuario = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.Titulo.Text = "Consulta de Usuario";
            ventana.TbNombres.IsEnabled = false;
            ventana.TbApellidos.IsEnabled = false;
            ventana.TbCI.IsEnabled = false;
            ventana.TbNIT.IsEnabled = false;
            ventana.TbCorreo.IsEnabled = false;
            ventana.TbTelefono.IsEnabled = false;
            ventana.TbFechaDeNacimiento.IsEnabled = false;
            ventana.cbPrivilegio.IsEnabled = false;
            ventana.tbUsuario.IsEnabled = false;
            ventana.tbContrasenia.IsEnabled = false;
            ventana.BtnSubir.IsEnabled = false;
        }
        #endregion

        #region Actualizar
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudUsuarios ventana = new CrudUsuarios();
            ventana.IdUsuario = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.Titulo.Text = "Actualizar Usuario";
            ventana.TbNombres.IsEnabled = true;
            ventana.TbApellidos.IsEnabled = true;
            ventana.TbCI.IsEnabled = true;
            ventana.TbNIT.IsEnabled = true;
            ventana.TbCorreo.IsEnabled = true;
            ventana.TbTelefono.IsEnabled = true;
            ventana.TbFechaDeNacimiento.IsEnabled = true;
            ventana.cbPrivilegio.IsEnabled = true;
            ventana.tbUsuario.IsEnabled = true;
            ventana.tbContrasenia.IsEnabled = true;
            ventana.BtnSubir.IsEnabled = true;
            ventana.BtnActualizar.Visibility = Visibility.Visible;
        }
        #endregion

        #region Eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudUsuarios ventana = new CrudUsuarios();
            ventana.IdUsuario = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.Titulo.Text = "Eliminar Usuario";
            ventana.TbNombres.IsEnabled = false;
            ventana.TbApellidos.IsEnabled = false;
            ventana.TbCI.IsEnabled = false;
            ventana.TbNIT.IsEnabled = false;
            ventana.TbCorreo.IsEnabled = false;
            ventana.TbTelefono.IsEnabled = false;
            ventana.TbFechaDeNacimiento.IsEnabled = false;
            ventana.cbPrivilegio.IsEnabled = false;
            ventana.tbUsuario.IsEnabled = false;
            ventana.tbContrasenia.IsEnabled = false;
            ventana.BtnSubir.IsEnabled = false;
            ventana.BtnEliminar.Visibility = Visibility.Visible;
        }
        #endregion

        #region Buscando

        public void Buscar(string buscar)
        {
            GridDatos.ItemsSource = objeto_CN_Usuarios.Buscar(buscar).DefaultView;
        }

        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);   
        }
        #endregion
    }
}

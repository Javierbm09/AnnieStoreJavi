using System.Windows;
using System.Windows.Controls;
using Capa_Negocio;

namespace Annies_Store.Views
{
    
    public partial class Productos : UserControl
    {
        #region Inicial
        public Productos()
        {
            InitializeComponent();
            Buscar("");
        }
        #endregion
        readonly CN_Productos obj_CN_Productos = new CN_Productos();

        #region Buscar

        public void Buscar(string buscar)
        {
            GridDatos.ItemsSource = obj_CN_Productos.BuscarProducto(buscar).DefaultView;
        }

        #endregion

        #region Buscando
        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);
        }
        #endregion

        #region Crud

        #region Create
        private void Agregar_Producto(object sender, RoutedEventArgs e)
        {
            CrudProductos ventana = new CrudProductos();
            FrameProductos.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }

        #endregion        

        #region Read
        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudProductos ventana = new CrudProductos();
            FrameProductos.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.IdProducto = id;
            ventana.Consultar();
            ventana.Titulo.Text = "Consulta de Productos";
            ventana.TbNombre.IsEnabled = false;
            ventana.tbCodigo.IsEnabled = false;
            ventana.tbCantidad.IsEnabled = false;
            ventana.tbActivo.IsEnabled = false;
            ventana.tbPrecio.IsEnabled = false;
            ventana.tbUnidadMedida.IsEnabled = false;
            ventana.tbDescripcion.IsEnabled = false;
            ventana.BtnSubir.IsEnabled = false;
        }
        #endregion

        #region Update
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudProductos ventana = new CrudProductos();
            FrameProductos.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.IdProducto = id;
            ventana.Consultar();
            ventana.Titulo.Text = "Actualizar Productos";
            ventana.TbNombre.IsEnabled = true;
            ventana.tbCodigo.IsEnabled = true;
            ventana.tbCantidad.IsEnabled = true;
            ventana.tbActivo.IsEnabled = true;
            ventana.tbPrecio.IsEnabled = true;
            ventana.tbUnidadMedida.IsEnabled = true;
            ventana.tbDescripcion.IsEnabled = true;
            ventana.BtnSubir.IsEnabled = true;
            ventana.BtnActualizar.Visibility = Visibility.Visible;
        }
        #endregion

        #region Delete
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudProductos ventana = new CrudProductos();
            FrameProductos.Content = ventana;
            Contenido.Visibility = Visibility.Hidden;
            ventana.IdProducto = id;
            ventana.Consultar();
            ventana.Titulo.Text = "Eliminar Productos";
            ventana.TbNombre.IsEnabled = false;
            ventana.tbCodigo.IsEnabled = false;
            ventana.tbCantidad.IsEnabled = false;
            ventana.tbActivo.IsEnabled = false;
            ventana.tbPrecio.IsEnabled = false;
            ventana.tbUnidadMedida.IsEnabled = false;
            ventana.tbDescripcion.IsEnabled = false;
            ventana.BtnSubir.IsEnabled = false;
            ventana.BtnEliminar.Visibility = Visibility.Visible;
        }
        #endregion
        #endregion
    }

}

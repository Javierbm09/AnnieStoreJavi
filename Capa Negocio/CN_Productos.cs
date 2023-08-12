using Capa_de_datos;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Productos
    {
        readonly CD_Productos objProductos = new CD_Productos();

        //Vista Productos
        #region Buscar
        public DataTable BuscarProducto(string buscar)
        {
            return objProductos.Buscar(buscar);
        }
        #endregion

        //vista CrudProductos
        #region Crud

        #region Consultar
        public CE_Productos Consulta(int IdArticulos)
        {
            return objProductos.Consulta(IdArticulos);
        }

        #endregion

        #region Insertar
        public void Insertar(CE_Productos productos)
        {
            objProductos.CD_Insertar(productos);
        }
        #endregion

        #region Eliminar
        public void Eliminar(CE_Productos cE_Productos)
        {
            objProductos.CD_Eliminar(cE_Productos);
        }

        #endregion

        #region ActualizarDatos

        public void ActualizarDatos(CE_Productos productos)
        {
            objProductos.CD_Actualizar(productos);
        }

        #endregion

        #region ActualizarDatos

        public void ActualizarIMG(CE_Productos productos)
        {
            objProductos.CD_ActualizarIMG(productos);
        }

        #endregion


        #endregion
    }

}

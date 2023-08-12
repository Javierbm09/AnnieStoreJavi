using Capa_de_datos;
using Capa_Entidad;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        private readonly CD_Usuarios objDatos = new CD_Usuarios();

        //Crud Usuarios
        #region Consulta
        public CE_Usuarios Consulta(int IdUsuarios)
        {
            return objDatos.CD_Consulta(IdUsuarios);
        }
        #endregion

        #region Insertar

        public void Insertar(CE_Usuarios Usuarios)
        {
            objDatos.CD_Insertar(Usuarios);
        }
        #endregion

        #region Eliminar

        public void Eliminar(CE_Usuarios Usuarios)
        {
            objDatos.CD_Eliminar(Usuarios);
        }
        #endregion

        #region Actualizar Datos

        public void ActualizarDatos(CE_Usuarios Usuarios)
        {
            objDatos.CD_ActualizarDatos(Usuarios);
        }
        #endregion

        #region Actualizar Pass

        public void ActualizarPass(CE_Usuarios Usuarios)
        {
            objDatos.CD_ActualizarPass(Usuarios);
        }
        #endregion

        #region Actualizar Imagen

        public void ActualizarIMG(CE_Usuarios Usuarios)
        {
            objDatos.CD_ActualizarIMG(Usuarios);
        }
        #endregion

        //Vista Usuarios

        #region Buscar Usuarios
        public DataTable Buscar(string buscar)
        {
            return objDatos.Buscar(buscar);
        }
        #endregion

    }
}

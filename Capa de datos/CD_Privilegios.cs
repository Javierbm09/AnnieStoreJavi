using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;


namespace Capa_de_datos
{
    public class CD_Privilegios
    {
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_Privilegios ce = new CE_Privilegios();

        #region Privilegio
        public int IdPrivilegio(string NombrePrivilegio)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_IdPrivilegio",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@NombrePrivilegio", NombrePrivilegio);
            object valor = com.ExecuteScalar();
            int idPrivilegio = (int)valor;
            con.CerrarConexion();

            return idPrivilegio;
        }
        #endregion

        #region NombrePrivilegio
        public CE_Privilegios NombrePrivilegio(int IdPrivilegio)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_NombrePrivilegio", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdPrivilegio", SqlDbType.Int).Value = IdPrivilegio;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.NombrePrivilegio = Convert.ToString(row[0]);

            return ce;
        }
        #endregion

        #region Listar Privilegios

        public List<string> ObtenerPrivilegios()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_CargarPrivilegios",
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while(reader.Read())
            {
                lista.Add(Convert.ToString(reader["NombrePrivilegio"]));
            }
            con.CerrarConexion();

            return lista;
        }

        #endregion
    }
}

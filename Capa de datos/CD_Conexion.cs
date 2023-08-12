using System.Data.SqlClient;
using System.Data;

namespace Capa_de_datos
{
    public class CD_Conexion
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=AtissGD08;initial catalog=AnniesStore; User id=sa;Password=javierbm.930209;");

        public SqlConnection AbrirConexion()
        {
            if(con.State==ConnectionState.Closed)
            
                con.Open();          
            return con;
        }
        public SqlConnection CerrarConexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}

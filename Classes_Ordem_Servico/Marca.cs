using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Ordem_Servico
{
    public class Marca
    {
        // Atributos
        public int idMarca { get; set; }
        public static string marca { get; set; }

        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");
        
        // Método Buscar
        public DataTable Buscar()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from marca", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
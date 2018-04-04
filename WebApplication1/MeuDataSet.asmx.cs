using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for MeuDataSet
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MeuDataSet : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        
        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Buscar
        [WebMethod]
        public DataSet Buscar()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from aluno order by idaluno desc", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Buscando da Procedure com Like no Nome do Aluno
        [WebMethod]
        public DataSet buscaNomeAluno(string nome)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("buscanomealuno", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            //caso tenha novos parâmetros só adiciona-los aqui.
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }
    }
}

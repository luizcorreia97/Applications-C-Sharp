using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Imobiliaria
{
    public class Imovel
    {
        // Atributos
        public int idImovel { get; set; }
        public string nome { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string dataCadastro { get; set; }
        public string dataLocacao { get; set; }
        public string observacao { get; set; }
        public string status { get; set; }
        
        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Buscar
        public DataSet Buscar()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from imoveis", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }
        
        // Método Salvar
        public void Salvar()
        {
            string comando_sql = "insert into imoveis values ('" + this.nome + "', '" + this.cep + "', '" + this.logradouro + "', '" + this.bairro + "', '" + this.cidade + "', '" + this.uf + "', '" + this.dataCadastro + "', '" + this.dataLocacao + "', '" + this.observacao + "', '" + this.status + "')";
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Alterar
        public void Alterar()
        {
            string comando_sql = "update imoveis set nome = '" + this.nome + "', cep = '" + this.cep + "', logradouro = '" + this.logradouro + "', bairro = '" + this.bairro + "', cidade = '" + this.cidade + "', uf = '" + this.uf + "', datacadastro = '" + this.dataCadastro + "', datalocacao = '" + this.dataLocacao + "', observacao = '" + this.observacao + "', status = '" + this.status + "' where id = " + this.idImovel;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Deletar
        public void Deletar()
        {
            string comando_sql = "delete from imoveis where id = " + idImovel;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Buscando Imóvel por parte do nome do Bairro
        public DataSet buscaImovelPorBairro(string status, string bairro)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("buscaImovelPorBairro", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Buscando Imóvel por Status
        public DataSet buscaImovelPorStatus(string status)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("buscaImovelPorStatus", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }
    }
}

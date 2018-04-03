using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    public class Aluno
    {
        // Atributos
        public int idAluno { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }

        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Salvar
        public void Salvar()
        {
            string comando_sql = "insert into aluno values ('" + this.nome + "', " + this.idade + ", '" + this.sexo + "')";
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Alterar
        public void Alterar()
        {
            string comando_sql = "update aluno set nome = '" + this.nome + "', idade = " + this.idade + ", sexo = '" + this.sexo + "' where idaluno = " + this.idAluno;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Deletar
        public void Deletar()
        {
            string comando_sql = "delete from aluno where idaluno = " + this.idAluno;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Buscar
        public DataSet Buscar()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from aluno order by idaluno desc", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Totalizador
        public int totalAluno()
        {
            SqlCommand comando = new SqlCommand("select count(*) from aluno", con);
            con.Open();
            int qtd = (int)comando.ExecuteScalar();
            return qtd;
        }

        // Método Buscando da Procedure
        public DataSet buscaAluno()
        {

            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("busca_aluno", con);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Buscando da Procedure com Like no Nome do Aluno
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
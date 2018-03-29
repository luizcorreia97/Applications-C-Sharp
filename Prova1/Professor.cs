using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhas_Classes
{
    public class Professor
    {
        // Atributos
        public int idProfessor { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }

        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Salvar
        public void Salvar()
        {
            string comando_sql = "insert into professor values ('" + this.nome + "', " + this.idade + ", '" + this.sexo + "')";
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Alterar
        public void Alterar()
        {
            string comando_sql = "update professor set nome = '" + this.nome + "', idade = " + this.idade + ", sexo = '" + this.sexo + "' where idprofessor = " + this.idProfessor;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Deletar
        public void Deletar()
        {
            string comando_sql = "delete from professor where idprofessor = " + this.idProfessor;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Buscar
        public DataSet Buscar()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from professor", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Totalizador
        public int totalProfessor()
        {
            SqlCommand comando = new SqlCommand("select count(*) from professor", con);
            con.Open();
            int qtd = (int)comando.ExecuteScalar();
            return qtd;
        }

        // Método Mostrar Sequence ID
        public int mostraID()
        {
            SqlCommand comando = new SqlCommand("select max(idprofessor)+1 from professor", con);
            con.Open();
            int qtd = (int)comando.ExecuteScalar();
            return qtd;
        }

        // Método Buscando da Procedure
        public DataSet buscaProfessor()
        {

            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("busca_professor", con);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Buscando da Procedure com Like no Nome do Professor
        public DataSet buscaNomeProfessor(string nome)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("buscanomeprofessor", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            //caso tenha novos parâmetros só adiciona-los aqui.
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhas_Classes
{
    public class Aluno
    {
        // Atributos
        public int idAluno { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }
        public int idMateria { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }

        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Salvar
        public void Salvar()
        {
            string comando_sql = "insert into aluno values ('" + this.nome + "', " + this.idade + ", '" + this.sexo + "')";
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
        }

        // Método Busca Máximo ID
        public int BuscaIdAluno()
        {
            SqlCommand comando = new SqlCommand("select max(idaluno) from aluno", con);
            con.Open();
            int id = (int)comando.ExecuteScalar();
            return id;
        }

        // Método Salvar Nota Matéria Aluno
        public void SalvarNotaAluno()
        {
            var comandoSql = "insert into notamateriaaluno values (" + this.idAluno + ", " + this.idMateria + ", " + this.nota1 + ", " + this.nota2 + ")";
            var comando = new SqlCommand(comandoSql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Buscar
        public DataSet BuscarMateria()
        {
            var ds = new DataSet();
            //SqlCommand comando = new SqlCommand("select idmateria, concat(nome,' - ',idmateria) as nome from materia", con);
            var comando = new SqlCommand("select * from materia", con);
            var da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        public HashSet<Aluno> BuscaNotaAluno(int id)
        {
            var dtInput = new DataTable();
            var comando = new SqlCommand("Select nma.idaluno, nma.idmateria, m.nome, nma.nota1, nma.nota2 from aluno a inner join notamateriaaluno nma on (nma.idaluno = a.idaluno) inner join Materia m ON(m.idMateria = nma.idMateria) where nma.idaluno = " + id, con);
            var da = new SqlDataAdapter(comando);
            da.Fill(dtInput);

            // convertendo datatable para hashset (lista) de aluno
            var alunoList = new HashSet<Aluno>();

            foreach (DataRow dr in dtInput.Rows)
            {
                var newObj = new Aluno
                {
                    idAluno = Convert.ToInt32(dr["idAluno"]),
                    idMateria = Convert.ToInt32(dr["idMateria"]),
                    nome = dr["nome"].ToString(),
                    nota1 = Convert.ToDouble(dr["nota1"]),
                    nota2 = Convert.ToDouble(dr["nota2"])
                };

                alunoList.Add(newObj);
            }
            return alunoList;
        }

        public void RemoveAllNotas(int id)
        {
            var comandoSql = "DELETE FROM notamateriaaluno WHERE idaluno = " + id;
            var comando = new SqlCommand(comandoSql, con);
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
            con.Close();
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
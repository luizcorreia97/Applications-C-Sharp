using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    public class Usuario
    {
        // Atributos
        public int idUsuario { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string tipo { get; set; }
        public string sexo { get; set; }
        public string status { get; set; }

        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Verificar Usuário Sistema
        public DataSet verificaUsuario(string login, string senha)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from usuario where login = '" + login + "' and senha = '" + senha + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Salvar
        public void Salvar()
        {
            string comando_sql = "insert into usuario values ('" + this.nome + "','" + this.login + "','" + this.senha + "', '" + this.tipo + "', '" + this.sexo + "', '" + this.status + "')";
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Alterar
        public void Alterar()
        {
            string comando_sql = "update usuario set login = '" + this.login + "', nome = '" + this.nome + "', senha = '" + this.senha + "', tipo = '" + this.tipo + "', sexo = '" + this.sexo + "', status = '" + this.status + "' where idusuario = " + this.idUsuario;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Deletar
        public void Deletar()
        {
            string comando_sql = "delete from usuario where idusuario = " + this.idUsuario;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Buscar
        public DataSet Buscar()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from usuario", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Totalizador
        public int totalUsuario()
        {
            SqlCommand comando = new SqlCommand("select count(*) from usuario", con);
            con.Open();
            int qtd = (int)comando.ExecuteScalar();
            return qtd;
        }

        // Método Buscando da Procedure
        public DataSet buscaUsuario()
        {

            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("buscaUsuario", con);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Buscando da Procedure com Like no Nome do Usuario
        public DataSet buscaUsuarioNome(string nome)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("buscaUsuarioNome", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            //caso tenha novos parâmetros só adiciona-los aqui.
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }
    }
}

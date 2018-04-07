using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    public class Eleicao
    {
        // Atributos
        public string cpf { get; set; }
        public string candidato { get; set; }
        public int numero { get; set; }
        public string partido { get; set; }

        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Salvar
        public void Salvar()
        {
            string comando_sql = "insert into voto (cpfeleitor, idcandidato) values ('" + this.cpf + "', '" + this.numero + "')";
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Listar
        public DataSet Listar()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select row_number() over(order by count(v.idcandidato) desc, nome asc) as ranking, case when c.nome <> 'Branco' and c.nome <> 'Nulo' then concat(c.nome, ' (',c.id,' - ',c.partido,')') else c.nome end as candidato, count(v.idcandidato) as votos from candidato c left join voto v on (v.idcandidato = c.numero) group by c.nome, c.partido, c.id", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Buscar
        public DataSet BuscaCandidato(int busca)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select nome, partido from candidato where numero = " + busca, con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Totalizador de Votos
        public int totalVotos()
        {
            SqlCommand comando = new SqlCommand("select count(*) from voto", con);
            con.Open();
            int qtd = (int)comando.ExecuteScalar();
            return qtd;
        }

        // Método Verificar Eleitor Sistema
        public DataSet verificaEleitor(string cpf)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from voto where cpfeleitor = '" + cpf + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }
    }
}

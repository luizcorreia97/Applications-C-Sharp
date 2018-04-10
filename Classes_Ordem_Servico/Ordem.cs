using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Ordem_Servico
{
    public class Ordem
    {
        // Atributos
        public int idOrdem { get; set; }
        public string nome { get; set; }
        public string dataAbertura { get; set; }
        public string dataFinalizacao { get; set; }
        public string placa { get; set; }
        public int idMarca { get; set; }
        public string descricao { get; set; }
        public int idStatus { get; set; }
        
        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Buscar
        public DataTable Buscar()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select os.id, os.nome, os.placa, m.marca, os.dataabertura, os.datafinalizacao, os.descricao, s.status from ordemservico os inner join marca m on (m.id = os.marca) inner join status s on (s.id = os.status) order by os.id desc", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds.Tables[0];
        }
        
        // Método Salvar
        public void Salvar(Ordem ordem)
        {
            string comando_sql = "insert into ordemservico values ('" + this.placa + "', " + this.idMarca + ", '" + this.nome + "', '" + this.dataAbertura + "', '" + this.dataFinalizacao + "', '" + this.descricao + "', " + this.idStatus + ")";
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Alterar
        public void Alterar(Ordem ordem)
        {
            string comando_sql = "update ordemservico set placa = '" + this.placa + "', marca = " + this.idMarca + ", nome = '" + this.nome + "', dataabertura = '" + this.dataAbertura + "', datafinalizacao = '" + this.dataFinalizacao + "', descricao = '" + this.descricao + "', status = " + this.idStatus + " where id = " + this.idOrdem;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Deletar
        public void Deletar(int idOrdem)
        {
            string comando_sql = "delete from ordemservico where id = " + idOrdem;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}

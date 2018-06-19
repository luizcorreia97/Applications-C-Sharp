using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhas_Classes
{
    public class Lembrete
    {
        // Atributos
        public int idLembrete { get; set; }
        public string dia { get; set; }
        public string hora { get; set; }
        public string descricao { get; set; }
        public string status { get; set; }

        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Buscar
        public DataSet Buscar()
        {
            var ds = new DataSet();
            var comando = new SqlCommand("select * from lembrete order by idlembrete desc", con);
            var da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        public DataSet BuscarPorMes(string mes)
        {
            var ds = new DataSet();
            var comando = new SqlCommand("select * from lembrete where substring(dia,6,2) like '%" + mes + "%' order by idlembrete desc", con);
            var da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Salvar
        public void Salvar()
        {
            string comando_sql = "insert into lembrete values ('" + this.dia + "', '" + this.hora + "', '" + this.descricao + "', '" + this.status + "')";
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Alterar
        public void Alterar()
        {
            string comando_sql = "update lembrete set dia = '" + this.dia + "', horario = '" + this.hora + "', descricao = '" + this.descricao + "', status = '" + this.status + "' where idlembrete = " + this.idLembrete;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Deletar
        public void Deletar()
        {
            string comando_sql = "delete from lembrete where idlembrete = " + this.idLembrete;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
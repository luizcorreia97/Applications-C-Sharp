using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhas_Classes
{
    public class Estacionamento
    {
        // Atributos
        public int idEstacionamento { get; set; }
        public string placa { get; set; }
        public string veiculo { get; set; }
        public string cor { get; set; }
        public string dataEntrada { get; set; }
        public string horaEntrada { get; set; }
        public string dataSaida { get; set; }
        public string horaSaida { get; set; }
        public string valorPago { get; set; }
        public string status { get; set; }

        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Salvar
        public void Salvar()
        {
            string comando_sql = "insert into estacionamento values ('" + this.placa + "', '" + this.veiculo + "', '" + this.cor + "', '" + this.dataEntrada + "', '" + this.horaEntrada + "', '" + this.dataSaida + "', '" + this.horaSaida + "', '" + this.valorPago + "', '" + this.status + "')";
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Alterar
        //public void Alterar()
        //{
        //    string comando_sql = "update professor set nome = '" + this.nome + "', idade = " + this.idade + ", sexo = '" + this.sexo + "' where idprofessor = " + this.idProfessor;
        //    SqlCommand comando = new SqlCommand(comando_sql, con);
        //    con.Open();
        //    comando.ExecuteNonQuery();
        //    con.Close();
        //}

        // Método Deletar
        public void Deletar()
        {
            string comando_sql = "delete from estacionamento where idEstacionamento = " + this.idEstacionamento;
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Buscar
        public DataSet Buscar()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from estacionamento order by idestacionamento desc", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Buscar
        public DataSet BuscarVeiculo()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from veiculo", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Totalizador
        public int totalProfessor()
        {
            SqlCommand comando = new SqlCommand("select count(*) from Estacionamento", con);
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
        
        public DataSet BuscarPorSexo(string sexo)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from professor where sexo in ('" + sexo + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        public DataSet BuscarPorIdade(string idade)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from professor where idade " + idade + "", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        public DataSet BuscarPorStatus(string status)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from professor where status = '" + status + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }
    }
}
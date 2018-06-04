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
        public int idMateria { get; set; }

        // String de conexão com o banco
        private static SqlConnection _con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");
        // private static SqlConnection _con = new SqlConnection(@"Data Source=GRANOLAPPATRICK\SQLEXPRESS;Initial Catalog=Facear2;User ID=sa;Password=patrigongl");

        // Método Salvar
        public void Salvar()
        {
            var comandoSql = "insert into professor values ('" + this.nome + "', " + this.idade + ", '" + this.sexo + "')";
            var comando = new SqlCommand(comandoSql, _con);
            _con.Open();
            comando.ExecuteNonQuery();
            //int id = Convert.ToInt32(comando.ExecuteScalar());
            _con.Close();
        }

        public static int BuscaIdProfessor()
        {
            var comando = new SqlCommand("select max(idprofessor) from professor", _con);
            _con.Open();
            var id = (int)comando.ExecuteScalar();
            _con.Close();
            return id;
        }

        // Método Alterar
        public void Alterar()
        {
            var comandoSql = "update professor set nome = '" + this.nome + "', idade = " + this.idade + ", sexo = '" + this.sexo + "' where idprofessor = " + this.idProfessor;
            var comando = new SqlCommand(comandoSql, _con);
            _con.Open();
            comando.ExecuteNonQuery();
            _con.Close();
        }

        // Método Deletar
        public void Deletar()
        {
            var comandoSql = "delete from professor where idprofessor = " + this.idProfessor;
            var comando = new SqlCommand(comandoSql, _con);
            _con.Open();
            comando.ExecuteNonQuery();
            _con.Close();
        }

        // Método Buscar
        public DataSet Buscar()
        {
            var ds = new DataSet();
            var comando = new SqlCommand("select * from professor order by idprofessor asc", _con);
            var da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Totalizador
        public int TotalProfessor()
        {
            var comando = new SqlCommand("select count(*) from professor", _con);
            _con.Open();
            var qtd = (int)comando.ExecuteScalar();
            _con.Close();
            return qtd;
        }

        // Método Buscando da Procedure
        public DataSet buscaProfessor()
        {

            var ds = new DataSet();
            var comando = new SqlCommand("busca_professor", _con) { CommandType = CommandType.StoredProcedure };
            var da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Buscando da Procedure com Like no Nome do Professor
        public static DataSet BuscaNomeProfessor(string nome)
        {
            var ds = new DataSet();
            var comando = new SqlCommand("buscanomeprofessor", _con) { CommandType = CommandType.StoredProcedure };
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            //caso tenha novos parâmetros só adiciona-los aqui.
            var da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        public DataSet BuscarPorSexo(string sexo)
        {
            var ds = new DataSet();
            var comando = new SqlCommand("select * from professor where sexo in ('" + sexo + "')", _con);
            var da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        public DataSet BuscarPorIdade(string idade)
        {
            var ds = new DataSet();
            var comando = new SqlCommand("select * from professor where idade " + idade + "", _con);
            var da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Buscar
        public DataSet BuscarMateria()
        {
            var ds = new DataSet();
            //SqlCommand comando = new SqlCommand("select idmateria, concat(nome,' - ',idmateria) as nome from materia", con);
            var comando = new SqlCommand("select * from materia", _con);
            var da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Salvar Matéria do Professor
        public void SalvarMateriaProfessor()
        {
            var comandoSql = "insert into materiaProfessor values (" + this.idProfessor + ", " + this.idMateria + ")";
            var comando = new SqlCommand(comandoSql, _con);
            _con.Open();
            comando.ExecuteNonQuery();
            _con.Close();
        }

        public static HashSet<Professor> BuscaMateriaProfessor(int id)
        {
            var dtInput = new DataTable();
            var comando = new SqlCommand(
            "SELECT mp.idProfessor, m.idMateria, m.nome " +
            "FROM professor p " +
            "INNER JOIN MateriaProfessor mp ON (mp.idProfessor = p.idProfessor) " +
            "INNER JOIN Materia m ON (m.idMateria = mp.idMateria) " +
            "WHERE mp.idProfessor = " + id, _con);
            var da = new SqlDataAdapter(comando);
            da.Fill(dtInput);

            // convertendo datatable para hashset (lista) de professor
            var profList = new HashSet<Professor>();

            foreach (DataRow dr in dtInput.Rows)
            {
                var newObj = new Professor
                {
                    idProfessor = Convert.ToInt32(dr["idProfessor"]),
                    idMateria = Convert.ToInt32(dr["idMateria"]),
                    nome = dr["nome"].ToString()
                };

                profList.Add(newObj);
            }
            return profList;
        }

        public void RemoveAllMaterias(int id)
        {
            var comandoSql = "DELETE FROM MateriaProfessor WHERE idProfessor = " + id;
            var comando = new SqlCommand(comandoSql, _con);
            _con.Open();
            comando.ExecuteNonQuery();
            _con.Close();
        }

        //public List<Professor> retorna(int id)
        //{
        //    List<Professor> lista = new List<Professor>();

        //    SqlCommand comando = new SqlCommand(
        //    "select mp.idProfessor, m.idMateria, m.nome " +
        //    "from professor p " +
        //    "inner join MateriaProfessor mp on (mp.idProfessor = p.idProfessor) " +
        //    "inner join materia m on (m.idMateria = mp.idMateria) " +
        //    "where mp.idProfessor = " + id, con);
        //    SqlDataAdapter da = new SqlDataAdapter(comando);
        //    da.Fill(lista);
        //    return lista;
        //}
    }
}
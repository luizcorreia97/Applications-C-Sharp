﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhas_Classes
{
    public class Urna
    {
        // Atributos
        public string cpf { get; set; }
        public int candidato { get; set; }

        // String de conexão com o banco
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facear;Integrated Security=True");

        // Método Salvar
        public void Salvar()
        {
            string comando_sql = "insert into urna values ('" + this.cpf + "', " + this.candidato + "')";
            SqlCommand comando = new SqlCommand(comando_sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        // Método Buscar
        public DataSet Listar()
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select candidato, count(*) as voto from urna group by candidato", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }

        // Método Verificar Eleitor Sistema
        public DataSet verificaEleitor(string cpf)
        {
            DataSet ds = new DataSet();
            SqlCommand comando = new SqlCommand("select * from urna where cpf = '" + cpf + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(ds);
            return ds;
        }
    }
}

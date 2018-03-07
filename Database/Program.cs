using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor prof = new Professor();
            prof.idProfessor = 7;
            prof.nome = "Valdney";
            prof.idade = 41;
            prof.sexo = 'M';

            //prof.Salvar();
            prof.Alterar();
            //prof.Deletar();

            DataSet dados1 = new DataSet();
            DataSet dados2 = new DataSet();

            dados1 = prof.buscaProfessor();
            dados2 = prof.buscaProfessorNome("Ro");

            Console.WriteLine("Lista de Professores\n");
            foreach (DataRow row in dados1.Tables[0].Rows)
            {
                Console.Write(row["idprofessor"] + " ");
                Console.Write(row["nome"] + " ");
                Console.Write(row["idade"] + " ");
                Console.WriteLine(row["sexo"]);
            }

            Console.WriteLine("\n\nProcedure - Busca\n");
            foreach (DataRow row in dados2.Tables[0].Rows)
            {
                Console.Write(row["idprofessor"] + " ");
                Console.Write(row["nome"] + " ");
                Console.Write(row["idade"] + " ");
                Console.WriteLine(row["sexo"]);
            }

            Console.Write("\nQtde registros: " + prof.totalProfessor());
            Console.ReadKey();

        }
    }
}

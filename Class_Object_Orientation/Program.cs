using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Orientacao_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria os objetos
            Pessoa pess = new Pessoa();
            Professor prof = new Professor();

            // Atribui valores
            pess.nome = "Luiz";
            prof.nome = "Rodrigo Jr";
            prof.materia = "Engenharia de Software";

            // Mostra valores dos métodos polimorfismo
            Console.WriteLine("Mostra valores dos métodos polimorfismo");
            Console.WriteLine("Costume Pessoa: " + pess.costume());
            Console.WriteLine("Costume Professor: " + prof.costume());

            // Mostra valor do construtor
            Console.WriteLine("\nMostra valor do construtor: " + prof.graduacao);

            // Métodos sendo cálculados usando datas.
            DateTime dataNascimento = Convert.ToDateTime("09-05-1997");            
            int dias = prof.retornaIdade(dataNascimento, 'M', 1700);
            int anos_vividos = dias / 365;

            // Apresenta no console os cálculos de data.
            Console.WriteLine("\nCálculos com data:");
            Console.WriteLine(pess.nome + " você já viveu " + anos_vividos + " anos ou " + dias + " dias");

            // Trava console - até que teclado seja digitado
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;

            Console.Write("Olá mundo!!!");

            Console.Write("\nQual é seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Qual sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            //media = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nSeu nome é: " + nome);
            Console.WriteLine("Sua idade é: " + idade);

            Console.WriteLine("Tabuada com sua idade:\n");
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(idade + " x " + i + " = " + idade * i);
            }

            Console.WriteLine("Vlw flws");

            Console.ReadKey();

        }
    }
}
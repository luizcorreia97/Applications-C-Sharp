using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Orientacao_Objeto
{
    // Herança -> quando a classe filha herda todos os atributos/métodos da classe pai.
    public class Professor : Pessoa
    {
    public string materia { get; set; }

        public string graduacao { get; set; }

        // Construtor -> define parâmetros inicias antes de criar o objeto.
        public Professor()
        {
            graduacao = "Mestre";
        }

        // Sobrecarga de Métodos -> Quando se tem vários métodos com mesmo nome, porém com parâmetros diferentes
        public int retornaIdade(DateTime dataNascimento, char sexo)
        {
            TimeSpan diferencaData = DateTime.Now - dataNascimento;
            return (int)diferencaData.TotalDays;
        }
        public int retornaIdade(DateTime dataNascimento, char sexo, decimal salario)
        {
            TimeSpan diferencaData = DateTime.Now - dataNascimento;
            return (int)diferencaData.TotalDays;
        }

        // Polimorfismo - Método a qual pode ser alterado em determinado tipo de classe (sendo acessado e alterado com override)
        public override string costume()
        {
            return "Prepara Aula";
        }
    } 
}

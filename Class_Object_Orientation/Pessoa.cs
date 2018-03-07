using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Orientacao_Objeto
{
    public class Pessoa
    {
        // Cria váriaveis e getters e setters
        public int idPessoa { get; set; }
        public string nome { get; set; }
        public decimal salario { get; set; }
        public char sexo { get; set; }
        public bool trabalha { get; set; }
        public DateTime dataNascimento { get; set; }
        
        // Método que recebe um parâmetro
        public int retornaIdade(DateTime dataNascimento)
        {
            TimeSpan diferencaData = DateTime.Now - dataNascimento;
            return (int) diferencaData.TotalDays;
        }

        // Polimorfismo (sendo criado com virtual)
        public virtual string costume() {
            return "Ver TV";
        }
    }
}

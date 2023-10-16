using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_Fundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
            Console.WriteLine("Não abreviar nomes, mesmo o nome da variavel sendo bem grande.");
            Console.WriteLine($"Nunca utilize abreviação, mesmo ficando bem extenso para a legibilidade do seu codigo");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa11.Common.models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos de idade :)");
        }
    }
}
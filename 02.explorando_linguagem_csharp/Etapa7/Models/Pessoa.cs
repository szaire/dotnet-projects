using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa7.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
			Nome = nome;
			Sobrenome = sobrenome;
		}

        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
	}
}
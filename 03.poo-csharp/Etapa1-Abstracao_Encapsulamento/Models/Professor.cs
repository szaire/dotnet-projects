using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa1.Models
{
    public class Professor : Pessoa
    {
        // Assim como Aluno, Professor também irá herdar
        // de Pessoa as propriedades Nome, Sobrenome e
        // Idade.
        public decimal Salario { get; set; }
    }
}
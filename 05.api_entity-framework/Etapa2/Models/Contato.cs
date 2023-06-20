using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// A classe Entidade será responsável por representar os elementos (linhas)
// da tabela no Context atual, onde cada um possui características intrinsecas
// como as propriedades representadas abaixo. Ela será útil para determinar
// as colunas da sua tabela.

// Ela é uma lcasse manipulada na API e, ao mesmo tempo, uma tabela editável
// no banco de dados

namespace Etapa2.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}
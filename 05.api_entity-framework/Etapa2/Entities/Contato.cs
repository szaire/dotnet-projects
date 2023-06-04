using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa2.Entities
{
    // A classe contato servirá como modelo ("molde") para a criação
    // de elementos dentro de uma tabela chamada "contatos" dentro do
    // banco de dados. Essa classe é entendida como uma "entidade",
    // ou seja, uma classe em C# que será uma representação de um 
    // elemento de uma tabela no banco de dados
    public class Contato
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}
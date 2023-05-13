using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Etapa6.Models
{
    public class Produto
    {
        public int Id { get; set; }
        
        [JsonProperty("Nome_Produto")]
        public string? Nome { get; set; }

        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
        public int? Desconto { get; set; }
    }
}
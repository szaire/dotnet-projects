using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Etapa5.Models
{
    public class ProdutoTI
    {
        // Para que a deserialização ocorra corretamente é necessário
        // que tanto o nome em json quanto o nome das propriedades sejam
        // os mesmos
        public int Id { get; set; }

        // Para casos em que o nome no arquivo json difere das convenções do
        // C# (PascalCase e camelCase), é possível utilizar atributos para
        // alterar uma propriedade específica de uma classe e, assim, se adequar
        // ao arquivo JSON. Pode ser considerada, também, uma atribuição de
        // metadados.
        // Exemplo:
        [JsonProperty("Product_Name")]
        public string Name { get; set; }
        
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dio_net_nuget.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [JsonProperty("Titulo_Livro")]
        public string Titulo { get; set; }

        public decimal Preco { get; set; }

        public DateTime DataLancamento { get; set; }
    }
}
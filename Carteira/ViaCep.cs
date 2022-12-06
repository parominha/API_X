using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_X.Carteira
{
    public class ViaCep
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Ibge { get; set; }
        public string Ddd { get; set; }
    }
}

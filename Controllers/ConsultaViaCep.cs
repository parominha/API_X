using API_X.Carteira;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace API_X.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaViaCep : ControllerBase
    {
        [HttpGet]
        public ViaCep Consulta(string p_CEP)
        {
            string oURL = "https://viacep.com.br/ws/" + p_CEP + "/json/";

            HttpClient _httpClient = new HttpClient();
            HttpResponseMessage result = _httpClient.GetAsync(oURL).Result;

            string JsonRetorno = result.Content.ReadAsStringAsync().Result;
            ViaCep oviaCEP = new ViaCep();
            oviaCEP = JsonConvert.DeserializeObject<ViaCep>(JsonRetorno);
            return oviaCEP;
        }
    }
}

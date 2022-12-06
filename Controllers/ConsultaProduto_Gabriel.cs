using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_X.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaProduto_Gabriel : ControllerBase
    {
        [HttpGet]
        public string ConsultarProduto_Gabriel(string p_Nome)
        {
            DataSet oDataSetRetorno = new DataSet();

            string oChave = "Data Source=10.39.45.44;Initial Catalog=Gabriel;User ID=Turma2022;Password=Turma2022@2022";

            SqlConnection Conexao = new SqlConnection(oChave);
            Conexao.Open();
            string wQuery = $"select * From Produtos where NomeProduto like '%{p_Nome}%'";
            SqlDataAdapter Adapter = new SqlDataAdapter(wQuery, Conexao);
            Adapter.Fill(oDataSetRetorno);
            string json = JsonConvert.SerializeObject(oDataSetRetorno, Formatting.Indented);

            return json;
        }
    }
}

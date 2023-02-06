using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FileApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Files : ControllerBase
    {


        [HttpPost]
        [Route("/SaveLife")]
        public async void SaveLifeInsurance([FromBody] List<InsurancesModel> insurances)
        {
            string path = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoFrontend\\wwwroot\\sample-data\\Insurances.json";
            await using FileStream createStream = System.IO.File.Create(path);
            await JsonSerializer.SerializeAsync(createStream, insurances);
        }
    }
}

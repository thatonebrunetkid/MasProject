using ProtegoFrontend.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FilesManager
{
    public static class Manager
    {
       
        public static void SaveLife(InsurancesModel insurances)
        {
            new HttpClient().PostAsJsonAsync<InsurancesModel>("D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoFrontend\\wwwroot\\sample-data\\Insurances.json", insurances);
        }
    }
}

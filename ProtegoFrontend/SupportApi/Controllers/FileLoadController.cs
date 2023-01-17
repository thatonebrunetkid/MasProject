using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System;
using MasProjekt.Backoffice.Models.Customers;

namespace SupportApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileLoadController : Controller
    {
        private static readonly string CustomerFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\Backend\\Data\\Customers.txt";
        private static readonly string VehicleFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Vehicles.txt";
        private static readonly string BrandsFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Brands.txt";
        private static readonly string ModelsFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Models.txt";
        private static readonly string InsurancesFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Insurances.txt";

        [HttpGet]
        [Route("LoadCustomer")]
        public void GetCustomerData()
        {
            using (var reader = new StreamReader(CustomerFileLocation))
            {
                string line;
                while ((line = reader.ReadLine()) is not null)
                {
                    string[] buffer = line.Split(';');
                    if (buffer[3].ToString().Count() > 1)
                    {
                        RetailCustomer TempCustomer = new RetailCustomer(Int32.Parse(buffer[0].ToString()), buffer[1].ToString(), buffer[2].ToString(), buffer[3].ToString(), new MasProjekt.Backoffice.Common.Adress(buffer[6].ToString(), buffer[7].ToString(), buffer[8].ToString(), buffer[9].ToString(), buffer[10].ToString()), buffer[11].ToString(), buffer[12].ToString());
                        Customer.Customers.Add(TempCustomer);
                    }
                    else
                    {
                        CorpoCustomer TempCustomer = new CorpoCustomer(Int32.Parse(buffer[0].ToString()), buffer[4].ToString(), buffer[5].ToString(), new MasProjekt.Backoffice.Common.Adress(buffer[6].ToString(), buffer[7].ToString(), buffer[8].ToString(), buffer[9].ToString(), buffer[10].ToString()), buffer[11].ToString(), buffer[12].ToString());
                        Customer.Customers.Add(TempCustomer);
                    }
                }
                var temp = Customer.Customers;
                reader.Close();
            }
        }
    }
}

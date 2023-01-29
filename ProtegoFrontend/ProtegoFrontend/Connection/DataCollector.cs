using MasProjekt.Backoffice.Models.Brand;
using MasProjekt.Backoffice.Models.Customers;
using MasProjekt.Backoffice.Models.Insurance;
using MasProjekt.Backoffice.Models.Model;
using MasProjekt.Backoffice.Models.Vehicle;
using ProtegoFrontend.Connection;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Connection
{
    public static partial class DataManipulator
    {
        private static readonly string CustomerFileLocation = "localD:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\Backend\\Data\\Customers.txt";
        private static readonly string VehicleFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Vehicles.txt";
        private static readonly string BrandsFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Brands.txt";
        private static readonly string ModelsFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Models.txt";
        private static readonly string InsurancesFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Insurances.txt";


        public static void LoadCustomerData(List<CustomersModel> CustomersList)
        {
            if (Customer.Customers.Count() > 0) Customer.Customers.Clear();
            foreach(CustomersModel TempCustomer in CustomersList)
            {
                if(TempCustomer.Pesel == " ")
                {
                    CorpoCustomer CorpoCustomer = new CorpoCustomer(TempCustomer.CustomerId, TempCustomer.CompanyName, TempCustomer.Nip, new Common.Adress(TempCustomer.City, TempCustomer.PostalCode, TempCustomer.Street, TempCustomer.HouseNumber, TempCustomer.FlatNumber), TempCustomer.PhoneNumber, TempCustomer.Email);
                    Customer.Customers.Add(CorpoCustomer);
                }
                else
                {
                    RetailCustomer RetailCustomer = new RetailCustomer(TempCustomer.CustomerId, TempCustomer.Name, TempCustomer.Surname, TempCustomer.Pesel, new Common.Adress(TempCustomer.City, TempCustomer.PostalCode, TempCustomer.Street, TempCustomer.HouseNumber, TempCustomer.FlatNumber), TempCustomer.PhoneNumber, TempCustomer.Email);
                    Customer.Customers.Add(RetailCustomer);

                }
            }
        }

        public static void LoadBrandsData(List<BrandsModel> BrandsList)
        {
            foreach(BrandsModel TempBrand in BrandsList)
            {
                Brand Brand = new Brand(TempBrand.BrandId, TempBrand.Name);
                Brand.Brands.Add(Brand);
            }
        }

        public static void LoadModelsData(List<ModelsModel> ModelsList)
        {
            foreach(ModelsModel TempModel in ModelsList)
            {
                Model Model = new Model(TempModel.ModelId, TempModel.Name, TempModel.ProductionStartDate, TempModel.ProductionEndDate, TempModel.Generation, TempModel.Equipment, TempModel.EngineCode);
                Model.Brand = Brand.Brands.First(e => e.BrandId == TempModel.BrandId);
                Brand.Brands.First(e => e.BrandId == TempModel.BrandId).Models.Add(Model);
                Model.Models.Add(Model);
            }
        }

        public static void LoadVehiclesData(List<VehiclesModel> VehicleList)
        {
            foreach (VehiclesModel VehicleTemp in VehicleList)
            {
                Customer TempCustomer = Customer.Customers.First(e => e.CustomerId == VehicleTemp.CustomerId);
                if (VehicleTemp.FrameNumber != "")
                {
                    Motorbike Motorbike = new Motorbike(VehicleTemp.VehicleId, VehicleTemp.ProductionDate, VehicleTemp.LicensePlateNumber, VehicleTemp.FrameNumber);
                    Vehicle.Vehicles.Add(Motorbike);
                    TempCustomer.Vehicles.Add(Motorbike);
                    Motorbike.Customer = TempCustomer;
                    Motorbike.CustomerId = TempCustomer.CustomerId;
                    Motorbike.Brand = Brand.Brands.First(e => e.BrandId == VehicleTemp.BrandId);
                    Motorbike.Model = Model.Models.First(e => e.ModelId == VehicleTemp.ModelId);
                }
                else if(VehicleTemp.MaximumAllowableAxleLoad != 0)
                {
                    Truck TempTruck = new Truck(VehicleTemp.VehicleId, VehicleTemp.ProductionDate, VehicleTemp.LicensePlateNumber, VehicleTemp.Vin, VehicleTemp.ImportCountry, VehicleTemp.FirstRegistrationDate, VehicleTemp.MileageCount, VehicleTemp.MaximumAllowableAxleLoad);
                    Vehicle.Vehicles.Add(TempTruck);
                    TempCustomer.Vehicles.Add(TempTruck);
                    TempTruck.Customer = TempCustomer;
                    TempTruck.CustomerId = TempCustomer.CustomerId;
                    TempTruck.Brand = Brand.Brands.First(e => e.BrandId == VehicleTemp.BrandId);
                    TempTruck.Model = Model.Models.First(e => e.ModelId == VehicleTemp.ModelId);
                }
                else
                {
                    PersonalCar TempCar = new PersonalCar(VehicleTemp.VehicleId, VehicleTemp.ProductionDate, VehicleTemp.LicensePlateNumber, VehicleTemp.Vin, VehicleTemp.ImportCountry, VehicleTemp.FirstRegistrationDate, VehicleTemp.MileageCount, VehicleTemp.IsHook, VehicleTemp.IsLpg);
                    Vehicle.Vehicles.Add(TempCar);
                    TempCustomer.Vehicles.Add(TempCar);
                    TempCar.Customer = TempCustomer;
                    TempCar.CustomerId = TempCustomer.CustomerId;
                    TempCar.Brand = Brand.Brands.First(e => e.BrandId == VehicleTemp.BrandId);
                    TempCar.Model = Model.Models.First(e => e.ModelId == VehicleTemp.ModelId);
                }
               
            }
        }

        public static void LoadInsurancesData(List<InsurancesModel> InsurancesList)
        {
            foreach(InsurancesModel insurance in InsurancesList)
            {
                if (insurance.InsuranceNumber.ToCharArray()[0] == 'O')
                {
                    MotorInsurance MotorInsurance = new MotorInsurance(insurance.CustomerId, insurance.Name, insurance.Surname, insurance.Pesel, Double.Parse(insurance.Price.ToString()), insurance.SignDate, insurance.EndDate, insurance.InsuranceNumber, insurance.AutoCasco);
                    MotorInsurance.Customer = Customer.Customers.First(e => e.CustomerId == insurance.CustomerId);
                    Customer.Customers.First(e => e.CustomerId == insurance.CustomerId).Insurances.Add(MotorInsurance);
                    MotorInsurance.VehicleId = insurance.VehicleId;
                    Vehicle.Vehicles.First(e => e.VehicleId == insurance.VehicleId).MotorInsurances.Add(MotorInsurance);
                    Insurance.Insurances.Add(MotorInsurance);
                    MotorInsurance.Vehicle = Vehicle.Vehicles.First(e => e.VehicleId == insurance.VehicleId);
                }
                else
                if (insurance.InsuranceNumber.ToCharArray()[0] == 'H')
                {
                    HouseInsurance houseInsurance = new HouseInsurance(insurance.InsuranceId, insurance.Name, insurance.Surname, insurance.Pesel, Double.Parse(insurance.Price.ToString()), insurance.SignDate, insurance.EndDate, insurance.InsuranceNumber, new Common.Adress(insurance.City, insurance.PostalCode, insurance.Street, insurance.HouseNumber, insurance.FlatNumber));
                    houseInsurance.Customer = Customer.Customers.First(e => e.CustomerId == insurance.CustomerId);
                    Customer.Customers.First(e => e.CustomerId == insurance.CustomerId).Insurances.Add(houseInsurance);
                    Insurance.Insurances.Add(houseInsurance);
                } else
                if (insurance.InsuranceNumber.ToCharArray()[0] == 'L')
                {
                    bool[] Answers = new bool[10];
                    Answers[0] = insurance.Survey1;
                    Answers[1] = insurance.Survey2;
                    Answers[2] = insurance.Survey3;
                    Answers[3] = insurance.Survey4;
                    Answers[4] = insurance.Survey5;
                    Answers[5] = insurance.Survey6;
                    Answers[6] = insurance.Survey7;
                    Answers[7] = insurance.Survey8;
                    Answers[8] = insurance.Survey9;
                    Answers[9] = insurance.Survey10;
                    LifeInsurance lifeInsurance = new LifeInsurance(insurance.InsuranceId, insurance.Name, insurance.Surname, insurance.Pesel, Double.Parse(insurance.Price.ToString()), insurance.SignDate, insurance.EndDate, insurance.InsuranceNumber, insurance.CustomerAge, new Survey(Answers));
                    lifeInsurance.Customer = Customer.Customers.First(e => e.CustomerId == insurance.CustomerId);
                    Customer.Customers.First(e => e.CustomerId == insurance.CustomerId).Insurances.Add(lifeInsurance);
                    Insurance.Insurances.Add(lifeInsurance);
                }
            }
        }

        
    }
}

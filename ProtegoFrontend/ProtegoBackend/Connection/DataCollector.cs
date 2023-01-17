using MasProjekt.Backoffice.Models.Brand;
using MasProjekt.Backoffice.Models.Customers;
using MasProjekt.Backoffice.Models.Insurance;
using MasProjekt.Backoffice.Models.Model;
using MasProjekt.Backoffice.Models.Vehicle;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Connection
{
    public static partial class DataManipulator
    {
        private static readonly string CustomerFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Customers.txt";
        private static readonly string VehicleFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Vehicles.txt";
        private static readonly string BrandsFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Brands.txt";
        private static readonly string ModelsFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Models.txt";
        private static readonly string InsurancesFileLocation = "D:\\Users\\mateu\\source\\repos\\MasProject\\ProtegoFrontend\\ProtegoBackend\\Data\\Insurances.txt";

        public static void LoadData()
        {
            LoadCustomerData();
            LoadBrandsData();
            LoadModelsData();
            LoadVehiclesData();
            LoadInsurancesData();
        }

        private static void LoadCustomerData()
        {
            using(var reader = new StreamReader(CustomerFileLocation))
            {
                string line;
                while((line = reader.ReadLine()) is not null)
                {
                    string[] buffer = line.Split(';');
                    if (buffer[3].ToString().Count() > 1)
                    {
                        RetailCustomer TempCustomer = new RetailCustomer(Int32.Parse(buffer[0].ToString()), buffer[1].ToString(), buffer[2].ToString(), buffer[3].ToString(), new Common.Adress(buffer[6].ToString(), buffer[7].ToString(), buffer[8].ToString(), buffer[9].ToString(), buffer[10].ToString()), buffer[11].ToString(), buffer[12].ToString());
                        Customer.Customers.Add(TempCustomer);
                    }else
                    {
                        CorpoCustomer TempCustomer = new CorpoCustomer(Int32.Parse(buffer[0].ToString()), buffer[4].ToString(), buffer[5].ToString(), new Common.Adress(buffer[6].ToString(), buffer[7].ToString(), buffer[8].ToString(), buffer[9].ToString(), buffer[10].ToString()), buffer[11].ToString(), buffer[12].ToString());
                        Customer.Customers.Add(TempCustomer);
                    }
                }
                var temp = Customer.Customers;
                reader.Close();
            }
        }

        private static void LoadVehiclesData()
        {
            using(var reader = new StreamReader(VehicleFileLocation))
            {
                string line;
                while((line = reader.ReadLine()) is not null)
                {
                    string[] buffer = line.Split(';');
                    Customer TempCustomer = Customer.Customers.First(e => e.CustomerId == Int32.Parse(buffer[11].ToString()));
                    if (buffer[3].ToString().Count() > 1)
                    {
                        Motorbike TempMotorbike = new Motorbike(Int32.Parse(buffer[0].ToString()), DateTime.Parse(buffer[1].ToString()), buffer[2].ToString(), buffer[3].ToString());
                        Vehicle.Vehicles.Add(TempMotorbike);
                        TempCustomer.Vehicles.Add(TempMotorbike);
                        TempMotorbike.Customer = TempCustomer;
                        TempMotorbike.CustomerId = TempCustomer.CustomerId;
                        TempMotorbike.Brand = Brand.Brands.First(e => e.BrandId == Int32.Parse(buffer[12].ToString()));
                        TempMotorbike.Model = Model.Models.First(e => e.ModelId == Int32.Parse(buffer[13].ToString()));
                    } else if (buffer[8].ToString().Count() > 1)
                    {
                        PersonalCar TempCar = new PersonalCar(Int32.Parse(buffer[0].ToString()), DateTime.Parse(buffer[1].ToString()), buffer[2].ToString(), buffer[4].ToString(), buffer[5].ToString(), DateTime.Parse(buffer[6].ToString()), Int32.Parse(buffer[7].ToString()), buffer[8].ToString() == "true" ? true : false, buffer[9].ToString() == "true" ? true : false);
                        Vehicle.Vehicles.Add(TempCar);
                        TempCustomer.Vehicles.Add(TempCar);
                        TempCar.Customer = TempCustomer;
                        TempCar.CustomerId = TempCustomer.CustomerId;
                        TempCar.Brand = Brand.Brands.First(e => e.BrandId == Int32.Parse(buffer[12].ToString()));
                        TempCar.Model = Model.Models.First(e => e.ModelId == Int32.Parse(buffer[13].ToString()));
                    }
                    else
                    {
                        Truck TempTruck = new Truck(Int32.Parse(buffer[0].ToString()), DateTime.Parse(buffer[1].ToString()), buffer[2].ToString(), buffer[4].ToString(), buffer[5].ToString(), DateTime.Parse(buffer[6].ToString()), Int32.Parse(buffer[7].ToString()), double.Parse(buffer[10].ToString()));
                        Vehicle.Vehicles.Add(TempTruck);
                        TempCustomer.Vehicles.Add(TempTruck);
                        TempTruck.Customer = TempCustomer;
                        TempTruck.CustomerId = TempCustomer.CustomerId;
                        TempTruck.Brand = Brand.Brands.First(e => e.BrandId == Int32.Parse(buffer[12].ToString()));
                        TempTruck.Model = Model.Models.First(e => e.ModelId == Int32.Parse(buffer[13].ToString()));
                    }
                }
                reader.Close();
            }
        }

        private static void LoadBrandsData()
        {
            using(var reader = new StreamReader(BrandsFileLocation))
            {
                string line;
                while((line = reader.ReadLine()) is not null)
                {
                    string[] buffer = line.Split(';');
                    Brand Brand = new Brand(Int32.Parse(buffer[0].ToString()), buffer[1].ToString());
                    Brand.Brands.Add(Brand);
                }
                reader.Close();
            }
        }

        private static void LoadModelsData()
        {
            using(var reader = new StreamReader(ModelsFileLocation))
            {
                string line;
                while((line = reader.ReadLine()) is not null)
                {
                    string[] Buffer = line.Split(';');
                    Model Model = new Model(Int32.Parse(Buffer[0].ToString()),Buffer[1].ToString(), DateTime.Parse(Buffer[2].ToString()), DateTime.Parse(Buffer[3].ToString()), Int32.Parse(Buffer[4].ToString()), Buffer[5].ToString(), Buffer[6].ToString());
                    Model.Brand = Brand.Brands.First(e => e.BrandId == Int32.Parse(Buffer[7].ToString()));
                    Brand.Brands.First(e => e.BrandId == Int32.Parse(Buffer[7].ToString())).Models.Add(Model);
                    Model.Models.Add(Model);
                }
                reader.Close();
            }
        }

        public static void LoadInsurancesData()
        {
            using(var reader = new StreamReader(InsurancesFileLocation))
            {
                string line;
                while((line = reader.ReadLine()) is not null)
                {
                    string[] buffer = line.Split(';');
                    if (buffer[7].ToString()[0] == 'O')
                    {
                        MotorInsurance TempInsurance = new MotorInsurance(Int32.Parse(buffer[0].ToString()), buffer[1].ToString(), buffer[2].ToString(), buffer[3].ToString(), double.Parse(buffer[4].ToString()), DateTime.Parse(buffer[5].ToString()), DateTime.Parse(buffer[6].ToString()), buffer[7].ToString(), buffer[8].ToString() == "true" ? true : false);
                        TempInsurance.Customer = Customer.Customers.First(e => e.CustomerId == Int32.Parse(buffer[26].ToString()));
                        Customer.Customers.First(e => e.CustomerId == Int32.Parse(buffer[26].ToString())).Insurances.Add(TempInsurance);
                        TempInsurance.VehicleId = Int32.Parse(buffer[9].ToString());
                        Vehicle.Vehicles.First(e => e.VehicleId == Int32.Parse(buffer[9].ToString())).MotorInsurances.Add(TempInsurance);
                        Insurance.Insurances.Add(TempInsurance);
                        TempInsurance.Vehicle = Vehicle.Vehicles.First(e => e.VehicleId == Int32.Parse(buffer[9].ToString()));
                    }
                    else if (buffer[7].ToString()[0] == 'H')
                    {
                        HouseInsurance houseInsurance = new HouseInsurance(Int32.Parse(buffer[0].ToString()), buffer[1].ToString(), buffer[2].ToString(), buffer[3].ToString(), double.Parse(buffer[4].ToString()), DateTime.Parse(buffer[5].ToString()), DateTime.Parse(buffer[6].ToString()), buffer[7].ToString(), new Common.Adress(buffer[21].ToString(), buffer[22].ToString(), buffer[23].ToString(), buffer[24].ToString(), buffer[25].ToString()));
                        houseInsurance.Customer = Customer.Customers.First(e => e.CustomerId == Int32.Parse(buffer[26].ToString()));
                        Customer.Customers.First(e => e.CustomerId == Int32.Parse(buffer[26].ToString())).Insurances.Add(houseInsurance);
                        Insurance.Insurances.Add(houseInsurance);
                    } else if (buffer[7].ToString()[0] == 'L')
                    {
                        bool[] Answers = new bool[10];
                        int initialValue = 10;
                        for(int j = 0; j < Answers.Length; j++)
                        {
                            Answers[j] = buffer[initialValue].ToString() == "true" ? true : false;
                        }

                        LifeInsurance LifeInsurance = new LifeInsurance(Int32.Parse(buffer[0].ToString()), buffer[1].ToString(), buffer[2].ToString(), buffer[3].ToString(), double.Parse(buffer[4].ToString()), DateTime.Parse(buffer[5].ToString()), DateTime.Parse(buffer[6].ToString()), buffer[7].ToString(), Int32.Parse(buffer[10].ToString()), new Survey(Answers));
                        LifeInsurance.Customer = Customer.Customers.First(e => e.CustomerId == Int32.Parse(buffer[26].ToString()));
                        Customer.Customers.First(e => e.CustomerId == Int32.Parse(buffer[26].ToString())).Insurances.Add(LifeInsurance);
                        Insurance.Insurances.Add(LifeInsurance);
                    }
                }
                reader.Close();
            }
        }
    }
}

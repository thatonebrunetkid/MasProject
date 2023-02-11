//using System.IO;
//using MasProjekt.Backoffice.Models.Brand;
//using MasProjekt.Backoffice.Models.Customers;
//using MasProjekt.Backoffice.Models.Model;
//using MasProjekt.Backoffice.Models.Vehicle;
//using System;
//using System.Collections.Generic;
//using System.Data.OleDb;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MasProjekt.Backoffice.Models.Insurance;

//namespace MasProjekt.Backoffice.Connection
//{
//    public static partial class DataManipulator
//    {
//        public static void SaveData()
//        {
//            SaveCustomerData();
//            SaveVehicleData();
//            SaveBrandsData();
//            SaveInsuranceData();
//            SaveModelsData();
//        }

//        private static void SaveCustomerData()
//        {
//            File.WriteAllText(CustomerFileLocation, "");
//            using(StreamWriter writer = new StreamWriter(CustomerFileLocation))
//            {
//                foreach(var customer in Customer.Customers)
//                {
//                    if (customer.GetCustomerData().Contains("Pesel: "))
//                        writer.WriteLine(((RetailCustomer)customer).PrepareCustomerToSave());
//                    else
//                        writer.WriteLine(((CorpoCustomer)customer).PrepareCustomerToSave());
//                }
//                writer.Flush();
//            }
//        }

//        private static void SaveVehicleData()
//        {
//            File.WriteAllText(VehicleFileLocation, "");
//            using(StreamWriter writer = new StreamWriter(VehicleFileLocation))
//            {
//                foreach(var vehicle in Vehicle.Vehicles)
//                {
//                    if (vehicle.GetVehicleData().Contains("Frame Number: "))
//                        writer.WriteLine(((Motorbike)vehicle).PrepareMotorbikeToSave() + ";" + vehicle.CustomerId + ";" + vehicle.Brand.BrandId + ";" + vehicle.Model.ModelId);
//                    else if (vehicle.GetVehicleData().Contains("Is Hook: "))
//                        writer.WriteLine(((PersonalCar)vehicle).PreparePersonalCarToSave() + ";" + vehicle.CustomerId + ";" + vehicle.Brand.BrandId + ";" + vehicle.Model.ModelId);
//                    else
//                        writer.WriteLine(((Truck)vehicle).PrepareTruckToSave() + ";" + vehicle.CustomerId + ";" + vehicle.Brand.BrandId + ";" + vehicle.Model.ModelId);
//                }
//                writer.Flush();
//            }
//        }

//        private static void SaveBrandsData()
//        {
//            File.WriteAllText(BrandsFileLocation, "");
//            using(StreamWriter writer = new StreamWriter(BrandsFileLocation))
//            {
//                foreach(var Brand in Brand.Brands)
//                    writer.WriteLine($"{Brand.BrandId};{Brand.Name}");
//                writer.Flush();
//            }
            
//        }

//        private static void SaveModelsData()
//        {
//            File.WriteAllText(ModelsFileLocation, "");
//            using(StreamWriter writer = new StreamWriter(ModelsFileLocation))
//            {
//                foreach (var Model in Model.Models)
//                    writer.WriteLine(Model.PrepareModelToSave());
//                writer.Flush();
//            }
//        }

//        private static void SaveInsuranceData()
//        {
//            File.WriteAllText(InsurancesFileLocation, "");
//            using(StreamWriter writer = new StreamWriter(InsurancesFileLocation))
//            {
//                foreach(var insurance in Insurance.Insurances)
//                {
//                    if (insurance.InsuranceNumber[0] == 'O')
//                        writer.WriteLine(((MotorInsurance)insurance).PrepareToSave());
//                    else if (insurance.InsuranceNumber[0] == 'H')
//                        writer.WriteLine(((HouseInsurance)insurance).PrepareToSave());
//                    else if (insurance.InsuranceNumber[0] == 'L')
//                        writer.WriteLine(((LifeInsurance)insurance).PrepareToSave());
//                }
//                writer.Flush();
//            }
//        }
//    }
//}

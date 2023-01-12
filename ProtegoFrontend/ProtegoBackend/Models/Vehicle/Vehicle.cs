using MasProjekt.Backoffice.Models.Brand;
using MasProjekt.Backoffice.Models.Customers;
using MasProjekt.Backoffice.Models.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Vehicle
{
    public abstract class Vehicle
    {
        public int VehicleId { get; set; }
        public DateTime ProductionDate { get; set; }
        public string LicencePlatesNumber { get; set; }
        public int CustomerId { get; set; }
        public Model.Model Model { get; set; }

        public static List<Vehicle> Vehicles = new List<Vehicle>();
        public Customer Customer;
        public List<MotorInsurance> MotorInsurances = new List<MotorInsurance>();
        public Brand.Brand Brand { get; set; }

        public Vehicle(int VehicleId, DateTime ProductionDate, string LicencePlatesNumber)
        {
            this.VehicleId = VehicleId;
            this.ProductionDate = ProductionDate;
            this.LicencePlatesNumber = LicencePlatesNumber;
        }

        public string GetVehicleData()
        {
            return this.ToString();
        }

        public static void AddNewVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void DeleteParticularVehicle()
        {
            Vehicles.Remove(this);
        }
    }
}

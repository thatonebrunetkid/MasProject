using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Vehicle
{
    public class Truck : Car
    {
        public double MaximulAllowableAxleLoad { get; set; }

        public Truck(int VehicleId, DateTime ProductionDate, string LicencePlatesNumber, string VIN, string ImportCountry, DateTime FirstRegistrationDate, int MileageCount, double MaximulAllowableAxleLoad) : base(VehicleId, ProductionDate, LicencePlatesNumber, VIN, ImportCountry, FirstRegistrationDate, MileageCount)
        {
            this.MaximulAllowableAxleLoad = MaximulAllowableAxleLoad;
        }

        public void ConvertToPersonalCar(bool IsHook, bool IsLGP)
        {
            PersonalCar TempCar = new PersonalCar(VehicleId, ProductionDate, LicencePlatesNumber, VIN, ImportCountry, FirstRegistrationDate, MileageCount, IsHook, IsLGP);
            this.DeleteParticularVehicle();
            Vehicle.AddNewVehicle(TempCar);
        }

        public override string ToString()
        {
            return $"Production Date: {ProductionDate} License Plates Number: {LicencePlatesNumber} VIN: {VIN} Import Country: {ImportCountry} First Registration Date: {FirstRegistrationDate} Mileage Count: {MileageCount} Maximum Allowable Axle Load: {MaximulAllowableAxleLoad}";
        }

        public string PrepareTruckToSave()
        {
            return $"{VehicleId};{ProductionDate};{LicencePlatesNumber}; ;{VIN};{ImportCountry};{FirstRegistrationDate};{MileageCount}; ; ;{MaximulAllowableAxleLoad}";
        }
    }
}

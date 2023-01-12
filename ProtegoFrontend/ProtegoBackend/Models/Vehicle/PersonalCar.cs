using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Vehicle
{
    public class PersonalCar : Car
    {
        public bool IsHook { get; set; }
        public bool IsLPG { get; set; }

        public PersonalCar(int VehicleId, DateTime ProductionDate, string LicencePlatesNumber, string VIN, string ImportCountry, DateTime FirstRegistrationDate, int MileageCount, bool IsHook, bool IsLPG) : base(VehicleId, ProductionDate, LicencePlatesNumber, VIN, ImportCountry, FirstRegistrationDate, MileageCount)
        {
            this.IsHook = IsHook;
            this.IsLPG = IsLPG;
        }

        public void ConvertToTruck(double MaximulAllowableAxleLoad)
        {
            Truck TempTruck = new Truck(VehicleId, ProductionDate, LicencePlatesNumber, VIN, ImportCountry, FirstRegistrationDate, MileageCount, MaximulAllowableAxleLoad);
            this.DeleteParticularVehicle();
            Vehicle.AddNewVehicle(TempTruck);
        }

        public override string ToString()
        {
            return $"Production Date: {ProductionDate} LicensePlatesNumber: {LicencePlatesNumber} VIN: {VIN} Import Country: {ImportCountry} First Registration Date: {FirstRegistrationDate} MileageCount: {MileageCount} Is Hook: {(IsHook == true ? "Yes" : "No")} Is LPG: {(IsLPG == true ? "Yes" : "No")}";
        }

        public string PreparePersonalCarToSave()
        {
            return $"{VehicleId};{ProductionDate};{LicencePlatesNumber}; ;{VIN};{ImportCountry};{FirstRegistrationDate};{MileageCount};{(IsHook == true ? "true" : "false")};{(IsLPG == true ? "true" : "false")}; ";
        }

    }
}

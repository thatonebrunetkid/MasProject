using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Vehicle
{
    public abstract class Car : Vehicle
    {
        public string VIN { get; set; }
        public string ImportCountry { get; set; }
        public DateTime FirstRegistrationDate { get; set; }
        public int MileageCount { get; set; }

        public Car(int VehicleId, DateTime ProductionDate, string LicencePlatesNumber, string VIN, string ImportCountry, DateTime FirstRegistrationDate, int MileageCount) : base(VehicleId, ProductionDate, LicencePlatesNumber)
        {
            this.VIN = VIN;
            this.ImportCountry = ImportCountry;
            this.FirstRegistrationDate = FirstRegistrationDate;
            this.MileageCount = MileageCount;
        }

        public override string ToString()
        {
            return this.ToString();
        }
    }
}

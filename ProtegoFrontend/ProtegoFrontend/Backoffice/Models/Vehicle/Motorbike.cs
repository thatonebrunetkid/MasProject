using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Vehicle
{
    public class Motorbike : Vehicle
    {
        public string FrameNumber { get; set; }

        public Motorbike(int VehicleId, DateTime ProductionDate, string LicencePlatesNumber, string FrameNumber) : base(VehicleId,ProductionDate, LicencePlatesNumber)
        {
            this.FrameNumber = FrameNumber;
        }

        public override string ToString()
        {
            return $"{ProductionDate} | {LicencePlatesNumber} | {FrameNumber}";
        }

        public string PrepareMotorbikeToSave()
        {
            return $"{VehicleId};{ProductionDate};{LicencePlatesNumber};{FrameNumber}; ; ; ; ; ; ; ";
        }

    }
}

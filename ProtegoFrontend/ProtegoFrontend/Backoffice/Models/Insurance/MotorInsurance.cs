using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Insurance
{
    public class MotorInsurance : Insurance
    {
        public bool AutoCasco { get; set; }
        public int VehicleId { get; set; }
        public Vehicle.Vehicle Vehicle { get; set; }

        public MotorInsurance(int InsuranceId, string Name, string Surname, string PESEL, double Price, DateTime SignDate, DateTime EndDate, string InsuranceNumber, bool AutoCasco) : base(InsuranceId, Name, Surname, PESEL, Price, SignDate, EndDate, InsuranceNumber)
        {
            this.AutoCasco = AutoCasco;
        }

        public override string ToString()
        {
            return $"{Name}|{Surname}|{PESEL}|{Price}|{SignDate}|{EndDate}|{InsuranceNumber}|{(AutoCasco == true ? "Yes" : "No")}";
        }

        public string PrepareToSave()
        {
            return $"{InsuranceId};{Name};{Surname};{PESEL};{Price};{SignDate};{EndDate};{InsuranceNumber};{(AutoCasco == true ? "true" : "false")};{VehicleId}; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;{Customer.CustomerId}";
        }
    }
}

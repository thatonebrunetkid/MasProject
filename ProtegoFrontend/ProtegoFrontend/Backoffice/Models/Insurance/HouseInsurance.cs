using MasProjekt.Backoffice.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Insurance
{
    public class HouseInsurance : Insurance
    {
        public Adress Adress { get; set; }

        public HouseInsurance(int InsuranceId, string Name, string Surname, string PESEL, double Price, DateTime SignDate, DateTime EndDate, string InsuranceNumber, Adress Adress) : base(InsuranceId, Name, Surname, PESEL, Price, SignDate, EndDate, InsuranceNumber)
        {
            this.Adress = Adress;
        }

        public override string ToString()
        {
            return $"{Name}|{Surname}|{PESEL}|{Price}|{SignDate}|{EndDate}|{InsuranceNumber}|{Adress.ToString()}";
        }

        public string PrepareToSave()
        {
            return $"{InsuranceId};{Name};{Surname};{PESEL};{Price};{SignDate};{EndDate};{InsuranceNumber}; ; ; ; ; ; ; ; ; ; ; ; ; ;{Adress.PrepareAdress()};{Customer.CustomerId}";
        }
    }
}

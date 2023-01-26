using MasProjekt.Backoffice.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Insurance
{
    public abstract class Insurance
    {
        public int InsuranceId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PESEL { get; set; }
        public double Price { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InsuranceNumber { get; set; }

        public static List<Insurance> Insurances = new List<Insurance>();
        public Customer Customer { get; set; }

        public Insurance(int InsuranceId, string Name, string Surname, string PESEL, double Price, DateTime SignDate, DateTime EndDate, string InsuranceNumber)
        {
            this.InsuranceId = InsuranceId;
            this.Name = Name;
            this.Surname = Surname;
            this.PESEL = PESEL;
            this.Price = Price;
            this.SignDate = SignDate;
            this.EndDate = EndDate;
            this.InsuranceNumber = InsuranceNumber;
        }

        public string GetInsuranceData()
        {
            return this.ToString();
        }

        public string GetInsuranceBasicInformation()
        {
            string insuranceType;
            if (InsuranceNumber.ToCharArray()[0] == 'O')
                insuranceType = "Car Policy";
            else if (InsuranceNumber.ToCharArray()[0] == 'H')
                insuranceType = "House insurance";
            else
                insuranceType = "Life insurance";

            return $"{insuranceType} | {this.InsuranceNumber} | {this.SignDate}";
        }

        public void AddNewInsurance(Insurance insurance)
        {
            Insurances.Add(insurance);
        }

        public void DeleteParticularInsurance()
        {
            Insurances.Remove(this);
        }
    }
}

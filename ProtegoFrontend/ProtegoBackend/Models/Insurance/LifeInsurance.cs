using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Insurance
{
    public class LifeInsurance : Insurance
    {
        public int CustomerAge { get; set; }
        public Survey Survey { get; set; }

        public LifeInsurance(int InsuranceId, string Name, string Surname, string PESEL, double Price, DateTime SignDate, DateTime EndDate, string InsuranceNumber, int CustomerAge, Survey Survey) : base(InsuranceId, Name, Surname, PESEL, Price, SignDate, EndDate, InsuranceNumber)
        {
            this.CustomerAge = CustomerAge;
            this.Survey = Survey;
        }

        public override string ToString()
        {
            return $"Name: {Name} Surname: {Surname} PESEL: {PESEL} Price: {Price} Sign Date: {SignDate} End Date: {EndDate} Insurance Number: {InsuranceNumber} Customer Age: {CustomerAge} Survey Answers: {Survey.GetSurveyData()}";
        }

        public string PrepareToSave()
        {
            return $"{InsuranceId};{Name};{Surname};{PESEL};{Price};{SignDate};{EndDate};{InsuranceNumber}; ; ;{CustomerAge};{Survey.PrepareToSave()} ; ; ; ; ;{Customer.CustomerId}";
        }
    }
}

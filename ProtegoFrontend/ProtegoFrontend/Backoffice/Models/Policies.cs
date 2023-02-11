using System;

namespace ProtegoFrontend.Backoffice.Models
{
    public class Policies
    {
        public int PolicyId { get; set; }
        public double Price { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PolicyNumber { get; set; }
        public bool AutoCasco { get; set; }
        public int? CustomerAge { get; set; }
        public string? MedicalSurvey { get; set; }
        public string? Adres { get; set; }
        public int ClientId { get; set; }
        public string? Client { get; set; }
        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }
    }
}

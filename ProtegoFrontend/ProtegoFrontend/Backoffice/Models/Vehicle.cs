using System;

namespace ProtegoFrontend.Backoffice.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public DateTime ProductionDate { get; set; }
        public string? LicensePlatesNumber { get; set; }
        public string? Frame { get; set; }
        public string? Vin { get; set; }
        public string? ImportCountry { get; set; }
        public DateTime? FirstRegistrationDate { get; set; }
        public int? MileageCount { get; set; }
        public bool? IsHook { get; set; }
        public bool? IsLpg { get; set; }
        public int? MaximumAllowableAxleLoad { get; set; }
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int? ModelId { get; set; }
        public string? Model { get; set; }
        public int? PolicyId { get; set; }
        public string? Policies { get; set; }
    }
}

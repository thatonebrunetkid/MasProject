using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FileApi.Models
{
    [Table("Vehicle2")]
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public DateTime? ProductionDate { get; set; }
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
        [ForeignKey(nameof(BrandId))]
        public virtual Brand Brand { get; set; }
        public int? ModelId { get; set; }
        [ForeignKey(nameof(ModelId))]
        public virtual Model2 Model { get; set; }
        public int PolicyId { get; set; }
        [ForeignKey(nameof(PolicyId))]
        public virtual Policies Policies { get; set; }
    }
}

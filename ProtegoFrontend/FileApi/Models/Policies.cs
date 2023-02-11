using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FileApi.Models
{
    [Table("Policy2")]
    public class Policies
    {
        [Key]
        public int PolicyId { get; set; }
        public double Price { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PolicyNumber { get; set; }
        public bool? AutoCasco { get; set; }
        public int? CustomerAge { get; set; }
        public string? MedicalSurvey { get; set; }
        public string? Adres { get; set; }
        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}

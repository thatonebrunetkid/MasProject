using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FileApi.Models
{
    [Table("Model2")]
    public class Model2
    {
        [Key]
        public int ModelId { get; set; }
        public string Name { get; set; }
        public DateTime ProductionStartDate { get; set; }
        public DateTime ProductionEndDate { get; set; }
        public int Generation { get; set; }
        public string Equipment { get; set; }
        public string EngineCode { get; set; }
        public int BrandId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}

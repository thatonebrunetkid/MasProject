using System;
using System.Collections.Generic;


namespace ProtegoBackend.Models.Model
{
    public class Model
    {
        public int ModelId { get; set; }
        public string Name { get; set; }
        public DateTime ProductionStartDate { get; set; }
        public DateTime ProductionEndDate { get; set; }
        public int Generation { get; set; }
        public string Equipment { get; set; }
        public string EngineCode { get; set; }


        public static List<Model> Models = new List<Model>();
        public Brand Brand { get; set; }

        public Model(int ModelId, string Name, DateTime ProductionStartDate, DateTime ProductionEndDate, int Generation, string Equipment, string EngineCode)
        {
            this.ModelId = ModelId;
            this.Name = Name;
            this.ProductionStartDate = ProductionStartDate;
            this.ProductionEndDate = ProductionEndDate;
            this.Generation = Generation;
            this.Equipment = Equipment;
            this.EngineCode = EngineCode;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Production Start Date: {ProductionStartDate}, Production End Date: {ProductionEndDate}, Generation: {Generation}, Equipment Version: {Equipment}, Engine Code: {EngineCode}";
        }

        public string PrepareToSave()
        {
            return $"{ModelId};{Name};{ProductionStartDate};{ProductionEndDate};{Generation};{Equipment};{EngineCode};{Brand.BrandId}";
        }

    }
}

using System;
namespace ProtegoFrontend.Connection
{
	public class ModelsModel
	{
		public int ModelId { get; set; }
		public string Name { get; set; }
		public DateTime ProductionStartDate { get; set; }
		public DateTime ProductionEndDate { get; set; }
		public int Generation { get; set; }
		public string Equipment { get; set; }
		public string EngineCode { get; set; }
		public int BrandId { get; set; }
	}
}


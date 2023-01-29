using System;
namespace ProtegoFrontend.Connection
{
	public class VehiclesModel
	{
		public int VehicleId { get; set; }
		public DateTime ProductionDate { get; set; }
		public string LicensePlateNumber { get; set; }
		public string? FrameNumber { get; set; }
		public string? Vin { get; set; }
		public string? ImportCountry { get; set; }
		public DateTime FirstRegistrationDate { get; set; }
		public int MileageCount { get; set; }
		public bool IsHook { get; set; }
		public bool IsLpg { get; set; }
		public double MaximumAllowableAxleLoad { get; set; }
		public int CustomerId { get; set; }
		public int BrandId { get; set; }
		public int ModelId { get; set; }
    }
}


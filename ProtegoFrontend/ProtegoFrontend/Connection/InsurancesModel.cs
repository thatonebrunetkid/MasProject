using System;
namespace ProtegoFrontend.Connection
{
	public class InsurancesModel
	{
		public int InsuranceId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Pesel { get; set; }
		public Double Price { get; set; }
		public DateTime SignDate { get; set; }
		public DateTime EndDate { get; set; }
		public string InsuranceNumber { get; set; }
		public bool AutoCasco { get; set; }
		public int VehicleId { get; set; }
		public int CustomerAge { get; set; }
		public bool Survey1 { get; set; }
        public bool Survey2 { get; set; }
        public bool Survey3 { get; set; }
        public bool Survey4 { get; set; }
        public bool Survey5 { get; set; }
        public bool Survey6 { get; set; }
        public bool Survey7 { get; set; }
        public bool Survey8 { get; set; }
        public bool Survey9 { get; set; }
        public bool Survey10 { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
		public string Street { get; set; }
		public string HouseNumber { get; set; }
		public string FlatNumber { get; set; }
		public int CustomerId { get; set; }
    }
}


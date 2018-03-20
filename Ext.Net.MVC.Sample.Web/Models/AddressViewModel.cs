namespace Ext.Net.MVC.Sample.Web.Models
{
	public class AddressViewModel
	{
		public int StreetNumber { get; set; }
		[ModelField(Name = "AddressStreetName")]
		public string StreetName { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		
	}
}
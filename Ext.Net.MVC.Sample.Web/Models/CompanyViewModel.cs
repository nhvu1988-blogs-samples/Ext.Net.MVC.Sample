namespace Ext.Net.MVC.Sample.Web.Models
{
	public class CompanyViewModel
	{
		public string Name { get; set; }

		[ModelField(Type = ModelFieldType.Object)]
		public AddressViewModel Address { get; set; }
	}
}
using System;

namespace Ext.Net.MVC.Sample.Domain
{
    public class User
    {
		public Guid Id { get; set; }
		public string Fullname { get; set; }
		public int Age { get; set; }
		public bool IsActive { get; set; }
		public DateTime Birthday { get; set; }
		public Gender Gender { get; set; }
		public string PhoneNumber { get; set; }
	}

	public enum Gender
	{
		Male,
		Female,
		NotDefined
	}
}

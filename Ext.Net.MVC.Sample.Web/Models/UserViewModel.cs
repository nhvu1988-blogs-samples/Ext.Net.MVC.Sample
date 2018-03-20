using Ext.Net;
using System;
using System.Collections.Generic;

namespace Ext.Net.MVC.Sample.Web.Models
{
	public class UserViewModel
	{
		[ModelField(IDProperty = true)]
		[Column(Order = 1)]
		public Guid Id { get; set; }

		[Column(Order = 2)]
		public string Fullname { get; set; }

		[Column(Order = 4)]
		public int Age { get; set; }

		[Column(Order = 6)]
		public bool IsActive { get; set; }

		[Column(Order = 3)]
		public DateTime Birthday { get; set; }

		[Column(Order = 5)]
		public GenderViewModel Gender { get; set; }

		[Column(Order = 7)]
		public string PhoneNumber { get; set; }
	}
}
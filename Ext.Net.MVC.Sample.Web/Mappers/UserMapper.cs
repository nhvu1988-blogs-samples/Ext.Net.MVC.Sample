using AutoMapper;
using Ext.Net.MVC.Sample.Domain;
using Ext.Net.MVC.Sample.Web.Models;

namespace Ext.Net.MVC.Sample.Web.Mappers
{
	public class UserMapper : Profile
	{
		public UserMapper()
		{
			CreateMap<User, UserViewModel>();
			CreateMap<Company, CompanyViewModel>();
			CreateMap<Address, AddressViewModel>();
		}
	}
}
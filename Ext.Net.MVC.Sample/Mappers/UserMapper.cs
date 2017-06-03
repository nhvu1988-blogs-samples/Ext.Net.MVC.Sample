using AutoMapper;
using Ext.Net.MVC.Sample.Domain;
using Ext.Net.MVC.Sample.Models.User;

namespace Ext.Net.MVC.Sample.Mappers
{
	public class UserMapper : Profile
	{
		public UserMapper()
		{
			CreateMap<User, UserListViewModel>();
		}
	}
}
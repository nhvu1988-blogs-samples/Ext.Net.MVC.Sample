using System;
using System.Collections.Generic;
using System.Linq;
using Ext.Net.MVC.Sample.Domain;
using FizzWare.NBuilder;

namespace Ext.Net.MVC.Sample.Services
{
    public static class UserService
    {
	    private static int BUILD_USER_COUNT = 100;
		private static IList<User> _users;
		private static IList<User> Users
	    {
			get
			{
				return _users ?? (_users = Builder<User>.CreateListOfSize(BUILD_USER_COUNT)
					       .All()
						   .With(u => u.Id = Guid.NewGuid())
					       .With(u => u.Fullname = Faker.NameFaker.Name())
					       .With(u => u.Birthday = Faker.DateTimeFaker.BirthDay())
					       .With(u => u.Age = Faker.NumberFaker.Number(20, 50))
					       .With(u => u.IsActive = Faker.BooleanFaker.Boolean())
					       .With(u => u.Gender = Faker.EnumFaker.SelectFrom<Gender>())
					       .With(u => u.PhoneNumber = Faker.PhoneFaker.Phone())
						   .Build());
			}
	    }

	    public static IList<User> GetAllUsers(int start = 0, int limit = 100)
	    {
		    return Users.Skip(start).Take(limit).ToList();
	    }

	    public static User GetUser(int index)
	    {
		    return Users[index];
	    }
    }
}

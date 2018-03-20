using System;
using System.Collections.Generic;
using System.Linq;
using Ext.Net.MVC.Sample.Domain;
using FizzWare.NBuilder;

namespace Ext.Net.MVC.Sample.Services
{
    public static class UserService
    {
	    private const int MAX_USER_COUNT = 100;
	    private const int MIN_USER_AGE = 1;
	    private const int MAX_USER_AGE = 80;

	    private static IList<User> _users;
		private static IList<User> Users
	    {
			get
			{
				return _users ?? (_users = Builder<User>.CreateListOfSize(MAX_USER_COUNT).All()
						   .With(u => u.Id = Guid.NewGuid())
					       .With(u => u.Fullname = Faker.NameFaker.Name())
					       .With(u => u.Birthday = Faker.DateTimeFaker.BirthDay(MIN_USER_AGE, MAX_USER_AGE))
					       .With(u => u.Age = Faker.NumberFaker.Number(MIN_USER_AGE, MAX_USER_AGE))
					       .With(u => u.IsActive = Faker.BooleanFaker.Boolean())
					       .With(u => u.Gender = Faker.EnumFaker.SelectFrom<Gender>())
					       .With(u => u.PhoneNumber = Faker.PhoneFaker.Phone())
						   .With(u => u.Address = RandomAddress())
						   .With(u => u.WorkingCompany = Builder<Company>.CreateNew()
								.With(c => c.Address = RandomAddress())
								.Build())
						   .Build());
			}
	    }

	    private static Address RandomAddress()
	    {
		    return Builder<Address>.CreateNew()
			    .With(a => a.City = Faker.LocationFaker.City())
				.With(a => a.Country = Faker.LocationFaker.Country())
				.With(a => a.StreetNumber = Faker.LocationFaker.StreetNumber())
				.With(a => a.StreetName = Faker.LocationFaker.StreetName())
				.Build();

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

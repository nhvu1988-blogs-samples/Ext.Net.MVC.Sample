using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Ext.Net.MVC.Sample.Services;
using Ext.Net.MVC.Sample.Web.Models;

namespace Ext.Net.MVC.Sample.Web.Controllers
{
	public class StoreController : Controller
	{
		public ActionResult StoreFor()
		{
			return View(UserService.GetAllUsers().Select(Mapper.Map<UserViewModel>).ToList());
		}
	}
}
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Ext.Net.MVC.Sample.Models.User;
using Ext.Net.MVC.Sample.Services;

namespace Ext.Net.MVC.Sample.Controllers
{
    public class UserController : Controller
    {
        public ActionResult GridPanelFor()
        {
            return View(UserService.GetAllUsers().Select(Mapper.Map<UserListViewModel>).ToList());
        }

	    public ActionResult FormPanelFor()
	    {
		    return View(Mapper.Map<UserListViewModel>(UserService.GetUser(0)));
	    }
    }
}
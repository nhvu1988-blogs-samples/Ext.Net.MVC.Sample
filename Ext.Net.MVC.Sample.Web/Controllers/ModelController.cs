using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Ext.Net.MVC.Sample.Services;
using Ext.Net.MVC.Sample.Web.Models;

namespace Ext.Net.MVC.Sample.Web.Controllers
{
    public class ModelController : Controller
    {
        public ActionResult GridPanelFor()
        {
            return View(UserService.GetAllUsers().Select(Mapper.Map<UserListViewModel>).ToList());
        }

	    public ActionResult FormPanelFor()
	    {
		    return View(Mapper.Map<UserListViewModel>(UserService.GetUser(0)));
	    }

	    public ActionResult ColumnModel()
	    {
			return View(Mapper.Map<UserListViewModel>(UserService.GetUser(0)));
		}
	}
}
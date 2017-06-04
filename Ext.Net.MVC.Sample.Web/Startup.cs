using Ext.Net.MVC.Sample.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace Ext.Net.MVC.Sample.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
		}
    }
}

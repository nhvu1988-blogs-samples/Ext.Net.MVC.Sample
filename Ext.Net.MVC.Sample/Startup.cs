using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ext.Net.MVC.Sample.Startup))]
namespace Ext.Net.MVC.Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

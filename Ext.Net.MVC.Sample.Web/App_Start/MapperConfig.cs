using System;
using System.IO;
using System.Linq;
using System.Reflection;
using AutoMapper;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Ext.Net.MVC.Sample.Web.MapperConfig), "RegisterMapper")]
namespace Ext.Net.MVC.Sample.Web
{
	public static class MapperConfig
	{
		public static void RegisterMapper()
		{
			Mapper.Initialize(cfg =>
			{
				var allDlls = Directory.GetFiles(AppDomain.CurrentDomain.RelativeSearchPath, "Ext.Net.MVC.Sample.*.dll");
				var dlls = allDlls.Select(Assembly.LoadFrom);
				cfg.AddProfiles(dlls);
			});
		}
	}
}
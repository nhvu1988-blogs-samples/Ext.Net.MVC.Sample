using System;
using System.IO;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace Ext.Net.MVC.Sample.Web
{
	public class MapperConfig
	{
		public static void RegisterMapper()
		{
			Mapper.Initialize(cfg =>
			{
				var allDlls = Directory.GetFiles(AppDomain.CurrentDomain.RelativeSearchPath, "Ext.Net.MVC.*.dll");
				var dlls = allDlls.Select(Assembly.LoadFrom).ToList();
				cfg.AddProfiles(dlls);
			});
		}
	}
}
using System;
using CCFC_Cricket.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(ConfigAccess))]
namespace CCFC_Cricket.iOS
{
	public class ConfigAccess : IConfigDummyResp
	{
		public string ReadJsonFromLocalFile()
		{
			return System.IO.File.ReadAllText("calendar2017.json");
		}
	}
}

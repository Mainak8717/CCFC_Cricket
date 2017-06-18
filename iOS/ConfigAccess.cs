using System;
using CCFC_Cricket.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(ConfigAccess))]
namespace CCFC_Cricket.iOS
{
	public class ConfigAccess : IConfigDummyResp
	{
		public string ReadJsonCalendarDetailsLocalFile()
		{
			return System.IO.File.ReadAllText("calendar2017.json");
		}

		public string ReadJsonPlayerListLocalFile()
		{
			return System.IO.File.ReadAllText("PlayerList.json");
		}

		public string ReadJsonContactsLocalFile()
		{
			return System.IO.File.ReadAllText("Contacts.json");
		}
		public string ReadJsonResultsLocalFile()
		{
			return System.IO.File.ReadAllText("Results.json");
		}

		public string ReadJsonPastCaptainsLocalFile()
		{
			return System.IO.File.ReadAllText("PastCaptains.json");
		}
	}
}

using System;
using System.IO;
using Android.App;
using Android.Content.Res;
using CCFC_Cricket.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(ConfigAccess))]

namespace CCFC_Cricket.Droid
{
	public class ConfigAccess : IConfigDummyResp
	{
		public string ReadJsonCalendarDetailsLocalFile()
		{
			const string lfn = "calendar2017.json";
			string reponse = string.Empty;

			using (var input = Application.Context.Assets.Open(lfn))
			using (StreamReader sr = new System.IO.StreamReader(input))
			{
			    reponse = sr.ReadToEnd();
			}
			return reponse;
		}

		public string ReadJsonPlayerListLocalFile()
		{
			const string lfn = "PlayerList.json";
			string reponse = string.Empty;

			using (var input = Application.Context.Assets.Open(lfn))
			using (StreamReader sr = new System.IO.StreamReader(input))
			{
			    reponse = sr.ReadToEnd();
			}

			return reponse;
		}	

		public string ReadJsonResultsLocalFile()
		{
			const string lfn = "Results.json";
			string reponse = string.Empty;

			using (var input = Application.Context.Assets.Open(lfn))
			using (StreamReader sr = new System.IO.StreamReader(input))
			{
				reponse = sr.ReadToEnd();
			}

			return reponse;
		}
		public string ReadJsonContactsLocalFile()
		{
			const string lfn = "Contacts.json";
			string reponse = string.Empty;

			using (var input = Application.Context.Assets.Open(lfn))
			using (StreamReader sr = new System.IO.StreamReader(input))
			{
				reponse = sr.ReadToEnd();
			}

			return reponse;
		}

		public string ReadJsonPastCaptainsLocalFile()
		{
const string lfn = "PastCaptains.json";
string reponse = string.Empty;

			using (var input = Application.Context.Assets.Open(lfn))
				using (StreamReader sr = new System.IO.StreamReader(input))
				{
					reponse = sr.ReadToEnd();
				}
		return reponse;
		}

		public string ReadJsonGalleryLocalFile()
		{
			const string lfn = "Gallery.json";
			string reponse = string.Empty;

			using (var input = Application.Context.Assets.Open(lfn))
				using (StreamReader sr = new System.IO.StreamReader(input))
				{
					reponse = sr.ReadToEnd();
				}
		return reponse;
		}
	}
}

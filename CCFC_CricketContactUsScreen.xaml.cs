using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketContactUsScreen : ContentPage
	{
		public ContactModelClass.Contact contactDetails { get; set; }

public string Website { get; set; }
public string ClubTele { get; set; }
public string Fax { get; set; }
public string CeoEmailId { get; set; }
public string SecyDetails { get; set; }
public string Captain { get; set; }
public string CapMobile { get; set; }
public string ViceCaptain { get; set; }
public string ViceCapMobile { get; set; }
public string CricSecy1 { get; set; }
public string CricSecy1Mobile { get; set; }

		public CCFC_CricketContactUsScreen()
		{
			InitializeComponent();
			CCFC_Cricket.IConfigDummyResp json = DependencyService.Get<IConfigDummyResp>();
			string response = json.ReadJsonContactsLocalFile();
			ContactModelClass.Contacts items = JsonConvert.DeserializeObject<ContactModelClass.Contacts>(response);
			contactDetails = new ContactModelClass.Contact();
			foreach (ContactModelClass.Contact contact in items.contactDetails)
			{
				Captain = contact.Captain;
				CapMobile = contact.CapMobile;

				ViceCaptain = contact.ViceCaptain;
				ViceCapMobile = contact.ViceCapMobile;

				Website = contact.Website;
				ClubTele = contact.ClubTele;

				Fax = contact.Fax;
				CeoEmailId = contact.CeoEmailId;
				SecyDetails = contact.SecyDetails;

				CricSecy1 = contact.CricSecy1;
				CricSecy1Mobile = contact.CricSecy1Mobile;
			}
		}
	}
}

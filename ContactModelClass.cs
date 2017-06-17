using System;
using System.Collections.Generic;

namespace CCFC_Cricket
{
	public class ContactModelClass
	{
		public class Contact
		{
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
		}

		public class Contacts
		{
			public List<Contact> contactDetails { get; set; }
		}
	}
}

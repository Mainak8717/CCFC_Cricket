using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketPastCaptainsScreen : ContentPage
	{
		public CCFC_CricketPastCaptainsScreen()
		{
			InitializeComponent();
			CCFC_Cricket.IConfigDummyResp json = DependencyService.Get<IConfigDummyResp>();
			string response = json.ReadJsonPastCaptainsLocalFile();
			PastCaptainsModelClass.PastCaptains items = JsonConvert.DeserializeObject<PastCaptainsModelClass.PastCaptains>(response);
			TeamMembersListView.ItemsSource = items.Captains;
		}
	}
}

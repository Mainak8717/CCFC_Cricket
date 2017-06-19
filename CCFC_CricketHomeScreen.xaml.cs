using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Xamarin.Forms;

using System.Net;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketHomeScreen : ContentPage
	{
		public CCFC_CricketHomeScreen()
		{
			InitializeComponent();
			ObservableCollection<CommitteeMembers> membersList = new ObservableCollection<CommitteeMembers>();
			membersList.Add(new CommitteeMembers() { imageSource = "arunlal.jpg", designation = "President", displayName = "Mr. Arun Lal"});
			membersList.Add(new CommitteeMembers() { imageSource = "nvm.jpg", designation = "Sports Co-ordinator", displayName = "Mr. Navendu Mathur"});
			membersList.Add(new CommitteeMembers() { imageSource = "irfan.jpg", designation = "Captain", displayName = "Mr. Irfan Ahmed"});
			membersList.Add(new CommitteeMembers() { imageSource = "wazim.png", designation = "Vice Captain", displayName = "Mr. Wasim Aziz"});
			membersList.Add(new CommitteeMembers() { imageSource = "mainak.jpg", designation = "Joint Secy", displayName = "Mr. Mainak Choudhury"});
			membersList.Add(new CommitteeMembers() { imageSource = "Zaffy.jpg", designation = "Joint Secy", displayName = "Mr. Zafar Aziz Khan"});


			ObservableCollection<CommitteMemberWrapper> membersListWrapper = new ObservableCollection<CommitteMemberWrapper>();
			for (int i = 0; i < membersList.Count; i++)
			{
				if (membersList.Count % 2 >= 1 )
				{
					if (i == membersList.Count - 1)
						membersListWrapper.Add(new CommitteMemberWrapper() { memberOne = membersList[i] });
					else
					{
						membersListWrapper.Add(new CommitteMemberWrapper() { memberOne = membersList[i], memberTwo = membersList[i + 1] });
						i = i + 1;
					}
				}
				else
				{
					membersListWrapper.Add(new CommitteMemberWrapper() { memberOne = membersList[i], memberTwo = membersList[i + 1] });
					i = i + 1;
				}
			}
			myList.ItemsSource = membersListWrapper;


			//getWebService();


		}

		public async void getWebService()
		{



//			JObject o1 = JObject.Parse(File.ReadAllText(@"c:\videogames.json"));

//StreamReader strm = new StreamReader(Assets.Open("form.json"));

//			using (StreamReader r = System.IO..OpenText("file.json"))
//			 {
//			        string json = r.ReadToEnd();
//					List<CalendarGamesModel> items = JsonConvert.DeserializeObject<List<CalendarGamesModel>>(json);
//			 }

			//CalendarGamesModel course = Newtonsoft.Json.JsonConvert.DeserializeObject<CalendarGamesModel>(System.IO.File.ReadAllText("YOUR_FILE_PATH\file.json")); 


			//var client = new System.Net.Http.HttpClient();

			//client.BaseAddress = new Uri("http://api.geonames.org/");

			//var response = await client.GetAsync("earthquakesJSON?north=44.1&south=-9.9&east=-22.4&west=55.2&username=bertt");

			//var earthquakesJson = response.Content.ReadAsStringAsync().Result;

			//var rootobject = JsonConvert.DeserializeObject<CommitteeMembers>(earthquakesJson);
		}
	
	
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			((ListView)sender).SelectedItem = null;
		}
	}
}

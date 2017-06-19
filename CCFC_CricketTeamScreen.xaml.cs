using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Newtonsoft.Json;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketTeamScreen : ContentPage
	{
		ObservableCollection<string> Team_A_MembersList;
		ObservableCollection<string> Team_B_MembersList;
		ObservableCollection<string> Team_C_MembersList;
		ObservableCollection<string> Team_Pro_MembersList;

		public CCFC_CricketTeamScreen()
		{
			InitializeComponent();

			A_Line.IsVisible = true;
			B_Line.IsVisible = false;
			C_Line.IsVisible = false;

			CCFC_Cricket.IConfigDummyResp json = DependencyService.Get<IConfigDummyResp>();
			string response = json.ReadJsonPlayerListLocalFile();
			PlayerModelClass.TeamInfos items = JsonConvert.DeserializeObject<PlayerModelClass.TeamInfos>(response);
			foreach (PlayerModelClass.Team team in items.Teams)
			{
				if (team.Title.Equals("Team A"))
				{
					Team_A_MembersList = new ObservableCollection<string>();
					foreach (PlayerModelClass.Player player in team.Players)
						Team_A_MembersList.Add(player.Name);
				}
				else if (team.Title.Equals("Team B"))
				{
					Team_B_MembersList = new ObservableCollection<string>();
					foreach (PlayerModelClass.Player player in team.Players)
						Team_B_MembersList.Add(player.Name);
				}
				else if (team.Title.Equals("Team C"))
				{
					Team_C_MembersList = new ObservableCollection<string>();
					foreach (PlayerModelClass.Player player in team.Players)
						Team_C_MembersList.Add(player.Name);
				}
			}

			TeamMembersListView.ItemsSource = Team_A_MembersList;

		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			((ListView)sender).SelectedItem = null;
		}

		void Handle_TeamButton_Clicked(object sender, System.EventArgs e)
		{

			switch ((sender as Button).Text)
			{
				case "A Team":
					A_Line.IsVisible = true;
					B_Line.IsVisible = false;
					C_Line.IsVisible = false;
					TeamMembersListView.ItemsSource = Team_A_MembersList;
					break;
				case "B Team":
					{
						A_Line.IsVisible = false;
						B_Line.IsVisible = true;
						C_Line.IsVisible = false;
						TeamMembersListView.ItemsSource = Team_B_MembersList;
					}
					break;
				case "C Team":
					{
						A_Line.IsVisible = false;
						B_Line.IsVisible = false;
						C_Line.IsVisible = true;
						TeamMembersListView.ItemsSource = Team_C_MembersList;
					}
					break;
				case "Pro Team":
					{
						//Button_A.BackgroundColor = Color.White;
						//Button_B.BackgroundColor = Color.White;
						//Button_C.BackgroundColor = Color.White;	
						//Button_Pro.BackgroundColor = Color.Gray;	
						TeamMembersListView.ItemsSource = Team_Pro_MembersList;
					}
					break;
				default:
					break;
			}
		}
	}
}

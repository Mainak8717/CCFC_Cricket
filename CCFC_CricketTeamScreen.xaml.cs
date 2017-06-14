using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketTeamScreen : ContentPage
	{
		ObservableCollection<TeamMembers> Team_A_MembersList;
		ObservableCollection<TeamMembers> Team_B_MembersList;
		ObservableCollection<TeamMembers> Team_C_MembersList;
		ObservableCollection<TeamMembers> Team_Pro_MembersList;

		public CCFC_CricketTeamScreen()
		{
			InitializeComponent();
			Team_A_MembersList = new ObservableCollection<TeamMembers>();
			Team_A_MembersList.Add(new TeamMembers() {displayName = "Mr. Irfan Ahmed"});
			Team_A_MembersList.Add(new TeamMembers() {displayName = "Mr. Wasim Aziz"});
			Team_A_MembersList.Add(new TeamMembers() {displayName = "Mr. Mainak Choudhury"});
			Team_A_MembersList.Add(new TeamMembers() {displayName = "Mr. Zafar Aziz Khan"});

			TeamMembersListView.ItemsSource = Team_A_MembersList;

			Team_B_MembersList = new ObservableCollection<TeamMembers>();
			Team_B_MembersList.Add(new TeamMembers() { displayName = "Mr. A"});
			Team_B_MembersList.Add(new TeamMembers() { displayName = "Mr. B"});
			Team_B_MembersList.Add(new TeamMembers() { displayName = "Mr. C"});
			Team_B_MembersList.Add(new TeamMembers() { displayName = "Mr. D"});

			Team_C_MembersList = new ObservableCollection<TeamMembers>();
			Team_C_MembersList.Add(new TeamMembers() { displayName = "Mr. X"});
			Team_C_MembersList.Add(new TeamMembers() { displayName = "Mr. Y"});
			Team_C_MembersList.Add(new TeamMembers() { displayName = "Mr. Z"});
			Team_C_MembersList.Add(new TeamMembers() { displayName = "Mr. L"});

			Team_Pro_MembersList = new ObservableCollection<TeamMembers>();
			Team_Pro_MembersList.Add(new TeamMembers() { displayName = "Mr. P"});
			Team_Pro_MembersList.Add(new TeamMembers() { displayName = "Mr. Q"});
			Team_Pro_MembersList.Add(new TeamMembers() { displayName = "Mr. R"});
			Team_Pro_MembersList.Add(new TeamMembers() { displayName = "Mr. S"});


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

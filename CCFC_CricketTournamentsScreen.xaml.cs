using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CCFC_Cricket
{
public partial class CCFC_CricketTournamentsScreen : ContentPage
	{
		public ObservableCollection<string> tournaments { get; set;}

		public CCFC_CricketTournamentsScreen()
		{
			InitializeComponent();
			Domestic_Line.IsVisible = true;
			InternationaLine.IsVisible = false;
			tournaments = new ObservableCollection<string>();
			tournaments.Add("Inter Club 6's Tournament - 2017");
			tournaments.Add("International 6's - 2017");
			tournaments.Add("CPL - 2017");

			TeamMembersListView.ItemsSource = tournaments;
		}
		void Handle_Button_Clicked(object sender, System.EventArgs e)
		{
			
		}

	}
}

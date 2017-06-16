using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketTournamentsScreen : ContentPage
	{
		public ObservableCollection<string> domesticTournaments { get; set; }
		public ObservableCollection<string> internationalTournaments { get; set; }

		public CCFC_CricketTournamentsScreen()
		{
			InitializeComponent();
			Domestic_Line.IsVisible = true;
			InternationaLine.IsVisible = false;
			domesticTournaments = new ObservableCollection<string>();
			domesticTournaments.Add("Inter Club 6's Tournament - 2017");
			domesticTournaments.Add("International 6's - 2017");
			domesticTournaments.Add("CPL - 2017");

			internationalTournaments = new ObservableCollection<string>();
			internationalTournaments.Add("Bangkok 6's Tournament - 2017");
			internationalTournaments.Add("Phuket 8's - 2017");
			internationalTournaments.Add("Dhaka Premier League - 2017");

			TeamMembersListView.ItemsSource = domesticTournaments;
			InternationaLine.IsVisible = false;
		}
		void Handle_Button_Clicked(object sender, System.EventArgs e)
		{
			switch ((sender as Button).Text)
			{
				case "Domestic":
					{
						InternationaLine.IsVisible = false;
						Domestic_Line.IsVisible = true;
						TeamMembersListView.ItemsSource = domesticTournaments;

					}
					break;
				case "International":
					{
						InternationaLine.IsVisible = true;
						Domestic_Line.IsVisible = false;
						TeamMembersListView.ItemsSource = internationalTournaments;
					}
					break;
			}
		}
	
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e){
			((ListView)sender).SelectedItem = null;	}
		}
}


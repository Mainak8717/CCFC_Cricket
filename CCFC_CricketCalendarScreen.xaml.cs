using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketCalendarScreen : ContentPage
	{
		public ObservableCollection<GroupedCalendarGames> grouped { get; set; }

		public CCFC_CricketCalendarScreen()
		{
			InitializeComponent();
			grouped = new ObservableCollection<GroupedCalendarGames>();
			var grroup1 = new GroupedCalendarGames() { LongName = "21st April, 2017", ShortName = "v" };
			grroup1.Add(new CalendarGamesModel() { teamName_One = "CCFC A" , teamName_Two = "BENGAL MASTERS" , gameTime ="TIME - 10:00 am", gameVenue = "Venue - CCFC Grounds"});
			grroup1.Add(new CalendarGamesModel() { teamName_One = "CCFC C" , teamName_Two = "ARMY GENERAL" , gameTime = "TIME - 10:00 am", gameVenue = "Venue - CCFC Grounds"});
			//grroup1.Add(new WeekendFootballGames { TeamOne = "CCFC A", TeamTwo = "CCFC - B", gameTime = DateTime.Now, result = "CCFC - A Won", TeamOneScore = "2", TeamTwoScore = "1" });
			grouped.Add(grroup1);

			lstView.ItemsSource = grouped;


		}
		public class GroupedCalendarGames : ObservableCollection<CalendarGamesModel>
		{
			public string LongName { get; set; }
			public string ShortName { get; set; }
		}
	}
}

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json;
using Xamarin.Forms;


namespace CCFC_Cricket
{
	public partial class CCFC_CricketCalendarScreen : ContentPage
	{
		public ObservableCollection<GroupedCalendarGames> groupedByDate { get; set; }

		public CCFC_CricketCalendarScreen()
		{
			InitializeComponent();
			lstView.BackgroundColor = Color.Transparent;

			CCFC_Cricket.IConfigDummyResp json = DependencyService.Get<IConfigDummyResp>();
			string response = json.ReadJsonCalendarDetailsLocalFile();
			List<CalendarGamesModel> items = JsonConvert.DeserializeObject<List<CalendarGamesModel>>(response);

			var matchesGroupByDate = items.GroupBy(u => u.gameDate);
			groupedByDate = new ObservableCollection<GroupedCalendarGames>();

			foreach (var matches in matchesGroupByDate)
			{
				var matchDate = matches.Key;
				var groupMatches = new GroupedCalendarGames() { LongName = matches.Key};

				foreach (CalendarGamesModel match in matches)
				{
					match.matchDescription = string.Format("{0} vs {1}", match.teamName_One, match.teamName_Two);
					match.result = string.Format("Result: {0}", match.result);
					groupMatches.Add(match);
				}
				groupedByDate.Add(groupMatches);

			}
			lstView.ItemsSource = groupedByDate;
		}
		public class GroupedCalendarGames : ObservableCollection<CalendarGamesModel>
		{
			public string LongName { get; set; }
		}
	}
}

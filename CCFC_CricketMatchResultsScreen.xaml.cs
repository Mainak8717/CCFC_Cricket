using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketMatchResultsScreen : ContentPage,System.ComponentModel.INotifyPropertyChanged
	{
		public string team1 { get; set;}
		public string team1Score { get; set;}

		public string team2 { get; set;}
		public string team2Score { get; set;}

		public ObservableCollection<ResultWrapper> resultWrapper { get; set; }
		public CCFC_CricketMatchResultsScreen( string matchId)
		{
			InitializeComponent();
			BindingContext = this;

			CCFC_Cricket.IConfigDummyResp json = DependencyService.Get<IConfigDummyResp>();
			string response = json.ReadJsonResultsLocalFile();
			ResultsModalClass.ResultList items = JsonConvert.DeserializeObject<ResultsModalClass.ResultList>(response);

			foreach (ResultsModalClass.Result result in items.Results) 			{
				team1 = result.match.FirstIninngsBattingTeam; 				team1Score = String.Format("{0}/{1} ({2} overs)", result.match.FirstIninngsBattingTeamScore, 															result.match.FirstIninngsWickets,
											   result.match.FirstIninngsOversPlayed);

				team2 = result.match.SecondIninngsBattingTeam; 				team2Score = String.Format("{0}/{1} ({2} overs)", result.match.SecondIninngsBattingScore,
											  result.match.SecondIninngsWickets,
										   result.match.FirstIninngsOversPlayed);
			}



			var tgr = new TapGestureRecognizer ();
			tgr.Tapped += (object sender, EventArgs e) => {
				this.Navigation.PushAsync(new CCFC_CricketResultDetailsScreen());
			};
			TeamOne.GestureRecognizers.Add(tgr);
		}

	}
}

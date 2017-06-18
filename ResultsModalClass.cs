using System;
using System.Collections.Generic;

namespace CCFC_Cricket
{
	public class ResultsModalClass
	{
		public class Match
		{
			public string FirstIninngsBattingTeam { get; set; }
			public int? FirstIninngsBattingTeamScore { get; set; }
			public int? FirstIninngsWickets { get; set; }
			public int? FirstIninngsOversPlayed { get; set; }
			public string FirstIninngsBatsman1 { get; set; }
			public string FirstIninngsBatsman2 { get; set; }
			public string FirstIninngsBatsman3 { get; set; }
			public string FirstIninngsBowler1 { get; set; }
			public string FirstIninngsBowler2 { get; set; }
			public string SecondIninngsBattingTeam { get; set; }
			public int? SecondIninngsBattingScore { get; set; }
			public string SecondIninngsWickets { get; set; }
			public string result { get; set; }
		}

		public class Result
		{
			public Match match { get; set; }
			public string matchID { get; set; }
		}
		public class ResultList
		{
			public IList<Result> Results { get; set; }
		}
	}
}

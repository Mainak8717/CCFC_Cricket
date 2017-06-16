using System;
using System.Collections.Generic;

namespace CCFC_Cricket
{
	public class PlayerModelClass
	{
		public class Player
		{
			public string Name { get; set; }
		}

		public class Team
		{
			public IList<Player> Players { get; set; }
			public string Title { get; set; }
		}

		public class TeamInfos
		{
			public IList<Team> Teams { get; set; }
		}
	}
}

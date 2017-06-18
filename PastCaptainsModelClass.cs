using System;
using System.Collections.Generic;

namespace CCFC_Cricket
{
	public class PastCaptainsModelClass
	{
		public class Captain
		{
			public string name { get; set; }
		}

		public class PastCaptains
		{
			public IList<Captain> Captains { get; set; }
		}
	}
}

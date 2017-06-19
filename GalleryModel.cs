using System;
using System.Collections.Generic;

namespace CCFC_Cricket
{
	public class GalleryModel
	{
		public class Gallery
		{
			public string imgSrc { get; set; }
		}

		public class GalleryList
		{
			public IList<Gallery> Gallery { get; set; }
		}
	}
}

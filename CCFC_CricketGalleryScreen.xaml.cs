using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketGalleryScreen : ContentPage
	{
		public CCFC_CricketGalleryScreen()
		{
			InitializeComponent();


			ObservableCollection<GalleryModel.Gallery> membersList = new ObservableCollection<GalleryModel.Gallery>();

			CCFC_Cricket.IConfigDummyResp json = DependencyService.Get<IConfigDummyResp>();
			string response = json.ReadJsonGalleryLocalFile();
			GalleryModel.GalleryList items = JsonConvert.DeserializeObject<GalleryModel.GalleryList>(response);

			foreach (GalleryModel.Gallery gallery in items.Gallery)
			{
				membersList.Add(gallery);
			}


			ObservableCollection<GalleryWrapper> galleryListWrapper = new ObservableCollection<GalleryWrapper>();
			for (int i = 0; i< membersList.Count; i++)
			{
				if (membersList.Count % 2 >= 1 )
				{
					if (i == membersList.Count - 1)
						galleryListWrapper.Add(new GalleryWrapper() { img1 = membersList[i] });
					else
					{
						galleryListWrapper.Add(new GalleryWrapper() { img1 = membersList[i], img2 = membersList[i + 1] });
						i = i + 1;
					}
				}
				else
				{
					galleryListWrapper.Add(new GalleryWrapper() { img1 = membersList[i], img2 = membersList[i + 1] });
					i = i + 1;
				}
			}
			myList.ItemsSource = galleryListWrapper;

		}

		public void imageClicked(object sender, EventArgs e)
		{
			var img = (Image)sender as Image;
			var source = img.Source as FileImageSource;
			Debug.WriteLine(source.File);
		}
	}
}

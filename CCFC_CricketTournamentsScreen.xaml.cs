using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketTournamentsScreen : ContentPage
	{
		public CCFC_CricketTournamentsScreen()
		{
			InitializeComponent();
			Domestic_Line.IsVisible = true;
			InternationaLine.IsVisible = false;
		}
		void Handle_Button_Clicked(object sender, System.EventArgs e)
		{
			
		}

	}
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketCalendarScreen : ContentPage
	{
		public ObservableCollection<string> grouped { get; set; }

		public CCFC_CricketCalendarScreen()
		{
			InitializeComponent();
			grouped = new ObservableCollection<string>();
			grouped.Add("5th Mat, Wednesday");


		}
	}
}

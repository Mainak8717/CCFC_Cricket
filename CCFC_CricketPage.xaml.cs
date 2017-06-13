using Xamarin.Forms;
using System.Collections.Generic;
using System;

namespace CCFC_Cricket
{
	public partial class CCFC_CricketPage : MasterDetailPage
	{
		public List<SideMenuItem> menuList { get; set; }

		public CCFC_CricketPage()
		{
            InitializeComponent(); 
			NavigationPage.SetHasNavigationBar(this, false);
			menuList = new List<SideMenuItem>();

		// Creating our pages for menu navigation
		// icon on the left side, and page that you want to open after selection
			var page1 = new SideMenuItem() { Title = "Home", Icon = "Home_Icon.png"};
			var page2 = new SideMenuItem() { Title = "Teams", Icon = "team_icon.png"};
			var page3 = new SideMenuItem() { Title = "Games", Icon = "Games_Icon.png"};
			var page4 = new SideMenuItem() { Title = "Tournaments", Icon = "Tournament_Icon.png"};
			var page5 = new SideMenuItem() { Title = "Merchants Cup", Icon = "MerchantsCup_Icon.png"};
			var page6 = new SideMenuItem() { Title = "Gallery", Icon = "Gallery_Icon.png"};
			var page7 = new SideMenuItem() { Title = "CCFC Pro Team", Icon = "ProTeam_Icon.png" };


		// Adding menu items to menuList
			menuList.Add(page1);
			menuList.Add(page2);
			menuList.Add(page3);
			menuList.Add(page4);
			menuList.Add(page5);
			menuList.Add(page6);
			menuList.Add(page7);

			navigationDrawerList.ItemsSource = menuList;
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(CCFC_CricketHomeScreen))) { 
				BarBackgroundColor = Color.Red
			};

	 	}
		private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
		{

			var item = (SideMenuItem)e.SelectedItem;
			Type page = item.TargetType;

			Detail = new NavigationPage((Page)Activator.CreateInstance(page));
			IsPresented = false;
		}
	}
}

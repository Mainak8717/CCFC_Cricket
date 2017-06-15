using Xamarin.Forms;

namespace CCFC_Cricket
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();


			var nav = new NavigationPage
			{
				Title = "Detail"
			};
			nav.PushAsync(new CCFC_CricketPage() { Title = "Home" });
			MainPage = nav;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace CCFC_Cricket.Droid
{
	[Activity(Label = "LaunchScreenActivity", Theme = "@style/MyTheme.Splash",MainLauncher = true)]
	public class LaunchScreenActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.LaunchScreenLayout);
			DelayActionAsync();
			 
		}
		private  async Task DelayActionAsync()
		{
			await Task.Delay(5000);
			Intent mainAct = new Intent(this, typeof(MainActivity));
			StartActivity(mainAct);
			Finish(); 

			//Task startUpWork = new Task(() =>
			//{
			//	Task.Delay(50000);
			//});

			//startUpWork.ContinueWith((arg) =>
			//{
			//	Intent mainAct = new Intent(Application.ApplicationContext, typeof(MainActivity));
			//	StartActivity(mainAct);
			//	//Finish(); 
			//}, TaskScheduler.FromCurrentSynchronizationContext());

			//startUpWork.Start();

		}
	}
}

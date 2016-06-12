using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Majestasaurus.Portable;
using CarouselView.FormsPlugin.Android;

namespace Majestasaurus.Droid
{
	[Activity (Label = "CarouselPageNavigation.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
            CarouselViewRenderer.Init();

            LoadApplication (new App ());
		}
	}
}


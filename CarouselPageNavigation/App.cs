using Majestasaurus.Portable.Services;
using Ninject;
using Xamarin.Forms;

namespace Majestasaurus.Portable
{
	public class App : Application
    {
        public static StandardKernel Container { get; set; }

        public App ()
		{
			MainPage = new SplashScreen ();

            App.Container = new StandardKernel();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
            // Handle when your app sleeps
            Container.Get<IAudioService>().StopSound();
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

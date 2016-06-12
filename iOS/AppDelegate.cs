using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Majestasaurus.Portable;
using CarouselView.FormsPlugin.iOS;
using Majestasaurus.Portable.Services;
using Majestasaurus.iOS.Services;
using Ninject;

namespace Majestasaurus.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();
            CarouselViewRenderer.Init();

            // Service Binding has to occur after the app is initialized.
            var formsApp = new App();
            App.Container.Bind<IAudioService>().To<AudioServiceIOS>();

            LoadApplication (formsApp);

			return base.FinishedLaunching (app, options);
		}

        public override void DidEnterBackground(UIApplication uiApplication)
        {
            App.Container.Get<IAudioService>().SuspendBackgroundMusic();
            base.DidEnterBackground(uiApplication);
        }

        public override void WillEnterForeground(UIApplication application)
        {
            App.Container.Get<IAudioService>().RestartBackgroundMusic();
            base.WillEnterForeground(application);
        }
    }
}


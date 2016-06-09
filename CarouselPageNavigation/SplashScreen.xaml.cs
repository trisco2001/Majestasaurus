using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Majestasaurus.Portable
{
    public partial class SplashScreen : ContentPage
    {
        private SplashScreenModel splashScreenModel;

        public SplashScreen()
        {
            InitializeComponent();

            splashScreenModel = new SplashScreenModel();
            BindingContext = splashScreenModel;

            Task t = AsyncCall();

            Image i = new Image();
        }

        private async Task AsyncCall()
        {
            int max = 50;
            for (int i = 0; i < max; i++)
            {
                await Task.Delay(300/max);
                splashScreenModel.MainText = "Loading " + (i * 100 / max) + "%";
                splashScreenModel.Progress += 1.0 / max;
            }
            await Navigation.PushModalAsync(new HomePage());
        }
    }
}

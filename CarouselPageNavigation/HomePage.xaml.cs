using Majestasaurus.Portable.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Majestasaurus.Portable
{
    public partial class HomePage : ContentPage
    {
        private IAudioService audioService;

        public HomePage()
        {
            InitializeComponent();

            audioService = App.Container.Get<IAudioService>();
            this.Appearing += HomePage_Appearing;
        }

        private void HomePage_Appearing(object sender, EventArgs e)
        {
            audioService.PlayBackgroundMusic("windy-cricket-meadow.mp3");
        }

        public void ReadClicked(object sender, EventArgs e)
        {
            audioService.StopBackgroundMusic();
            Navigation.PushModalAsync(new MainPage());
        }

        public void SkipClicked(object sender, EventArgs e)
        {
            audioService.StopBackgroundMusic();
            Navigation.PushModalAsync(new SkipPage());
        }

        public void TeamClicked(object sender, EventArgs e)
        {
            audioService.StopBackgroundMusic();
            Navigation.PushModalAsync(new TeamPage());
        }
    }
}

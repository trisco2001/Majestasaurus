using Majestasaurus.Portable.Services;
using Ninject;
using System;
using System.Collections;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Majestasaurus.Portable
{
	public partial class MainPage : ContentPage
	{
        private IList items;
        private int position;
        private IAudioService audioService;

        public bool EnableReading { get; set; }

        public MainPage (int position = 0)
		{
			InitializeComponent ();
            audioService = App.Container.Get<IAudioService>();

            items = (IList)BooksDataModel.All;
            this.position = position;
            Carousel.ItemsSource = items;
            Carousel.PropertyChanged += Carousel_PropertyChanged;
            Carousel.Position = position;

            this.Appearing += MainPage_Appearing;
        }

        private async void MainPage_Appearing(object sender, EventArgs e)
        {
            audioService.PlayBackgroundMusic("welcome-home.mp3");
            HideMenuAfter(delay: 2000);

            if (EnableReading)
            {
                await PlayVoiceTracksAsync();
            }

        }

        private async void HideMenuAfter(int delay)
        {
            await Task.Delay(delay);
            if (MainMenu.IsEnabled)
            {
                ToggleMenu();
            }
        }

        private async void Carousel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Position")
            {
                audioService.StopVoiceTrack();
                position = Carousel.Position;

                if (EnableReading)
                {
                    await PlayVoiceTracksAsync();
                }
            }
        }

        private async Task PlayVoiceTracksAsync()
        {
            int loopThroughPage = position;
            foreach (var label in BooksDataModel.All[loopThroughPage].LabelsInOrder)
            {
                if (loopThroughPage != position)
                    break;

                if (label.VoiceClip != null)
                {
                    label.VoiceClip.IsPlaying = true;
                    audioService.PlayVoiceTrack(label.VoiceClip);
                    await Task.Run(() => { while (label.VoiceClip.IsPlaying); });
                }
            }
        }

        public void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
            audioService.StopBackgroundMusic();
        }

        public void PrevClicked(object sender, EventArgs e)
        {
            if (position != 0)
            {
                position--;
                Carousel.SetCurrentPage(position);
            }
        }

        public void NextClicked(object sender, EventArgs e)
        {
            if (position != items.Count - 1)
            {
                position++;
                Carousel.SetCurrentPage(position);
            }
        }

        public void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            ToggleMenu();
        }

        private void ToggleMenu()
        {
            MainMenu.IsEnabled = !MainMenu.IsEnabled;
            MainMenu.FadeTo(MainMenu.Opacity == 0 ? 1 : 0);
        }
    }
}


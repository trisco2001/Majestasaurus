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

        public MainPage (int position = 0)
		{
			InitializeComponent ();
            items = (IList)BooksDataModel.All;
            this.position = position;
            Carousel.ItemsSource = items;
            Carousel.PropertyChanged += Carousel_PropertyChanged;
            Carousel.Position = position;

            audioService = App.Container.Get<IAudioService>();
            this.Appearing += MainPage_Appearing;
        }

        private void MainPage_Appearing(object sender, EventArgs e)
        {
            audioService.PlayBackgroundMusic("welcome-home.mp3");
        }

        private async void Carousel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Position")
            {
                position = Carousel.Position;

                await PlayVoiceTracksAsync();
            }
        }

        private async Task PlayVoiceTracksAsync()
        {
            foreach (var label in BooksDataModel.All[position].LabelsInOrder)
            {
                if (label.VoiceClip != null)
                {
                    audioService.PlayVoiceTrack(label.VoiceClip);
                    await Task.Run(() => { while (label.VoiceClip.IsPlaying) Task.Delay(100); });
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
            MainMenu.IsEnabled = !MainMenu.IsEnabled;
            MainMenu.FadeTo(MainMenu.Opacity == 0 ? 1 : 0);
        }
    }
}


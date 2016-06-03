using System;
using System.Collections;
using System.Diagnostics;
using Xamarin.Forms;

namespace Majestasaurus.Portable
{
	public partial class MainPage : ContentPage
	{
        private IList items;
        private int position;

        public MainPage ()
		{
			InitializeComponent ();
            items = (IList)BooksDataModel.All;
            position = 0;
            Carousel.ItemsSource = items;
            Carousel.PropertyChanged += Carousel_PropertyChanged;
        }

        private void Carousel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            position = Carousel.Position;
        }

        public void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
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
            MainMenu.IsVisible = !MainMenu.IsVisible;
        }
    }
}


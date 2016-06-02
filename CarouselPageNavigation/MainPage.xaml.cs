using System;
using System.Collections;
using Xamarin.Forms;

namespace Majestasaurus.Portable
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            var items = (IList)ColorsDataModel.All;
            Carousel.ItemsSource = items;
        }

        public void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        public void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            BackButton.IsVisible = !BackButton.IsVisible;
        }
    }
}


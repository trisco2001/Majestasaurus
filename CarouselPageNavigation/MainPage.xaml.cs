using System;
using Xamarin.Forms;

namespace Majestasaurus.Portable
{
	public partial class MainPage : CarouselPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			ItemsSource = ColorsDataModel.All;
        }

        public void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}


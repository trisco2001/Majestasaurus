using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Majestasaurus.Portable
{
    public partial class SkipPage : ContentPage
    {
        public SkipPage()
        {
            InitializeComponent();

            MyListView.ItemsSource = BooksDataModel.All;
            ViewCell cell = new ViewCell();
        }

        public void CellTapped(object sender, EventArgs e)
        {
            int position = BooksDataModel.All.IndexOf(((BooksDataModel)((ViewCell)sender).BindingContext));
            Navigation.PopModalAsync(false);
            Navigation.PushModalAsync(new MainPage(position));
        }

        public void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}

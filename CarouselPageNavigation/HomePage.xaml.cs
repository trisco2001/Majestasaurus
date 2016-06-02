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
        public HomePage()
        {
            InitializeComponent();
        }

        public void ReadClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        public void SkipClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SkipPage());
        }

        public void TeamClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TeamPage());
        }
    }
}

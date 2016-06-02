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
        }

        public void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Majestasaurus.Portable
{
    public partial class TeamPage : ContentPage
    {
        public TeamPage()
        {
            InitializeComponent();

            var teamPageModel = new
            {
                TeamDescription = "In general I know the weird al parody of a song much better than the original. I really like pop tarts but they're so bad for you.\n\nOh right, so I'm supposed to be talking about the team. Amanda has been studying art for thousands of years. This is my first Xamarin project, so bear with me. Xander has been testing video games for seven years. Aliera did not put the phone in her mouth."
            };
            this.BindingContext = teamPageModel;

        }

        public void BackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Majestasaurus.Portable
{
	public class BooksDataModel
    {
        public string PageText { get; set; }

        public string ImageName { get; set; }

        public Color Color { get; set; }

		public static IList<BooksDataModel> All { get; set; }

		static BooksDataModel ()
		{
			All = new ObservableCollection<BooksDataModel> {
				new BooksDataModel {
					PageText = "Titania the Tyrannosaurus wanted to be queen of the forest.",
                    ImageName = "01-page.png",
					Color = Color.Blue
				},
				new BooksDataModel {
					PageText = "One day she met a handsome man tyrannosarus.",
                    ImageName = "01-page.png",
                    Color = Color.Green
				},
				new BooksDataModel {
					PageText = "She killed him and ate him.",
                    ImageName = "01-page.png",
                    Color = Color.Red
				}
			};
		}
	}
}

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Majestasaurus.Portable
{
	public class BooksDataModel
    {

        public string ImageName { get; set; }

        public Color Color { get; set; }

        public TextLabel TopLeftLabel { get; set; }
 
        public TextLabel TopCenterLabel { get; set; }

        public TextLabel TopRightLabel { get; set; }

        public TextLabel MiddleLeftLabel { get; set; }
                         
        public TextLabel MiddleCenterLabel { get; set; }
                         
        public TextLabel MiddleRightLabel { get; set; }

        public TextLabel BottomLeftLabel { get; set; }

        public TextLabel BottomCenterLabel { get; set; }

        public TextLabel BottomRightLabel { get; set; }

        public static IList<BooksDataModel> All { get; set; }

		static BooksDataModel ()
		{
            All = new ObservableCollection<BooksDataModel> {
                new BooksDataModel {
                    ImageName = "01-page.png",
                    Color = Color.Blue,
                    BottomLeftLabel = new TextLabel {
                        Text = "Titania the Tyrannosaurus wanted to be queen of the forest.",
                        Color = Color.White
                    },
                    BottomRightLabel = new TextLabel {
                        Text = "My Test",
                        Color = Color.White
                    }
                },
                new BooksDataModel {
                    ImageName = "00-splash.jpg",
                    Color = Color.Green,
                    TopRightLabel = new TextLabel {
                        Text = "One day she met a handsome man tyrannosarus.",
                        Color = Color.White,
                        VerticalAlignment = TextAlignment.Start,
                        HorizontalAlignment = TextAlignment.End
                    },
                    TopLeftLabel = new TextLabel {
                        Text = "Wowzers",
                        Color = Color.White
                    }
                },
				new BooksDataModel {
                    ImageName = "01-page.png",
                    Color = Color.Red,
                    TopLeftLabel = new TextLabel {
                        Text = "She killed him and ate him.",
                        Color = Color.White
                    },
                    BottomCenterLabel = new TextLabel {
                        Text = "My Test",
                        Color = Color.White
                    }
                },
                new BooksDataModel {
                    ImageName = "XX-nonexistent.jpg",
                    Color = Color.Silver,
                    TopLeftLabel = new TextLabel {Text = "A", VerticalAlignment = TextAlignment.Start},
                    TopCenterLabel = new TextLabel {Text = "B", VerticalAlignment = TextAlignment.Start, HorizontalAlignment = TextAlignment.Center},
                    TopRightLabel = new TextLabel {Text = "C", VerticalAlignment = TextAlignment.Start, HorizontalAlignment = TextAlignment.End},
                    MiddleLeftLabel = new TextLabel {Text = "The quick brown fox jumps over the lazy dog.", VerticalAlignment = TextAlignment.Center},
                    MiddleCenterLabel = new TextLabel {Text = "E", VerticalAlignment = TextAlignment.Center, HorizontalAlignment = TextAlignment.Center},
                    MiddleRightLabel = new TextLabel {Text = "F", VerticalAlignment = TextAlignment.Center, HorizontalAlignment = TextAlignment.End},
                    BottomLeftLabel = new TextLabel {Text = "G", VerticalAlignment = TextAlignment.End},
                    BottomCenterLabel = new TextLabel {Text = "H", VerticalAlignment = TextAlignment.End, HorizontalAlignment = TextAlignment.Center},
                    BottomRightLabel = new TextLabel {Text = "I", VerticalAlignment = TextAlignment.End, HorizontalAlignment = TextAlignment.End},
                },
            };
		}
	}
}

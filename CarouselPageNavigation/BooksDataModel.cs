using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Majestasaurus.Portable
{
	public class BooksDataModel
    {

        public string ImageName { get; set; }

        public Color Color { get; set; }

        public string Title { get; set; }

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
                    Title = "Titania Prepares for the Day",
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
                    ImageName = "02-page.png",
                    Color = Color.Green,
                    Title = "Queen of the Forest",
                    BottomCenterLabel = new TextLabel {
                        Text = "One day she met a handsome man tyrannosarus.",
                        Color = Color.White,
                        ColumnSpan = 2,
                        VerticalAlignment = TextAlignment.Center,
                        HorizontalAlignment = TextAlignment.End
                    }
                },
                new BooksDataModel {
                    ImageName = "03-page.png",
                    Color = Color.Red,
                    Title = "A Mother's Warning",
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
                    ImageName = "04-page.jpg",
                    Color = Color.Fuchsia,
                    Title = "Titania Meets a Princess",
                    TopLeftLabel = new TextLabel {
                        Text = "Of course I shall journey with you,",
                        Color = Color.White
                    },
                    BottomCenterLabel = new TextLabel {
                        Text = "But I shall NOT be a dinosaur!",
                        Color = Color.White
                    }
                },
                new BooksDataModel {
                    ImageName = "XX-nonexistent.jpg",
                    Color = Color.Silver,
                    Title = "A Testing Page",
                    TopLeftLabel = new TextLabel {Text = "A", VerticalAlignment = TextAlignment.Start, Color = Color.Red},
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

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Majestasaurus.Portable
{
	public class BooksDataModel
    {
        public const int TopLeftLabelPosition = 1;

        public const int TopCenterLabelPosition = 2;
        public const int TopRightLabelPosition = 3;
        public const int MiddleLeftLabelPosition = 4;
        public const int MiddleCenterLabelPosition = 5;
        public const int MiddleRightLabelPosition = 6;
        public const int BottomLeftLabelPosition = 7;
        public const int BottomCenterLabelPosition = 8;
        public const int BottomRightLabelPosition = 9;

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
        public IEnumerable<TextLabel> LabelsInOrder
        {
            get
            {
                return new []{
                    TopLeftLabel,
                    TopCenterLabel,
                    TopRightLabel,
                    MiddleLeftLabel,
                    MiddleCenterLabel,
                    MiddleRightLabel,
                    BottomLeftLabel,
                    BottomCenterLabel,
                    BottomRightLabel
                }.Where(n => n != null);
            }
        }

        static BooksDataModel ()
		{
            All = new ObservableCollection<BooksDataModel> {
                new BooksDataModel {
                    ImageName = "01-page.png",
                    Color = Color.Blue,
                    Title = "Titania Prepares for the Day",
                    BottomLeftLabel = new TextLabel {
                        Text = "Titania the Tyrannosaurus wanted to be queen of the forest.",
                        Color = Color.White,
                        VoiceClip = new VoiceClip {ClipName = "01-queen-forest.mp3" },
                        ColumnSpan = 2
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
                        HorizontalAlignment = TextAlignment.End,
                        VoiceClip = new VoiceClip {ClipName = "02-man-tyranno.mp3" }
                    }
                },
                new BooksDataModel {
                    ImageName = "03-page.png",
                    Color = Color.Red,
                    Title = "A Mother's Warning",
                    TopLeftLabel = new TextLabel {
                        Text = "She killed him and ate him.",
                        Color = Color.White,
                        VoiceClip = new VoiceClip {ClipName = "03-killed.mp3" }
                    },
                    MiddleRightLabel = new TextLabel {
                        Text = "Then she visited her friend's house to invite her on an adventure.",
                        Color = Color.White,
                        VoiceClip = new VoiceClip {ClipName = "03-2-adventure.mp3" },
                        RowSpan = 2
                    }
                },
                new BooksDataModel {
                    ImageName = "04-page.jpg",
                    Color = Color.Fuchsia,
                    Title = "Titania Meets a Princess",
                    TopLeftLabel = new TextLabel {
                        Text = "Of course I shall journey with you,",
                        VoiceClip = new VoiceClip {ClipName = "04-of-course.mp3" },
                        Color = Color.White
                    },
                    BottomCenterLabel = new TextLabel {
                        Text = "But I shall NOT be a dinosaur!",
                        VoiceClip = new VoiceClip {ClipName = "04-2-not-dino.mp3" },
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

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
                    TopLeftLabel = new TextLabel {
                        Text = "Titania readied herself for the day while setting her summer goals.",
                        RowSpan = 2,
                        Color = Color.White,
                        VerticalAlignment = TextAlignment.Start,
                        VoiceClip = new VoiceClip {ClipName = "01-queen-forest.mp3" },
                    },
                    BottomLeftLabel = new TextLabel {
                        Text = "First and most importantly, she must be a Tyrannosaurus as always.",
                        Color = Color.White,
                        ColumnSpan = 2,
                        VoiceClip = new VoiceClip {ClipName = "01-queen-forest.mp3" },
                    }
                },
                new BooksDataModel {
                    ImageName = "02-page.png",
                    Color = Color.Green,
                    Title = "Queen of the Forest",
                    TopLeftLabel = new TextLabel {
                        Text = "But that was not enough. The night before, her mother had read her a bedtime story about a fairy queen in an enchanted forest.",
                        Color = Color.White,
                        ColumnSpan = 3,
                        VerticalAlignment = TextAlignment.Start,
                        HorizontalAlignment = TextAlignment.Start,
                        VoiceClip = new VoiceClip {ClipName = "02-man-tyranno.mp3" }
                    },
                    BottomCenterLabel = new TextLabel {
                        Text = "Titania thought being Queen of the Forest also would be delightful.",
                        Color = Color.White,
                        ColumnSpan = 2,
                        VerticalAlignment = TextAlignment.End,
                        HorizontalAlignment = TextAlignment.End,
                        VoiceClip = new VoiceClip {ClipName = "02-man-tyranno.mp3" }
                    },
                },
                new BooksDataModel {
                    ImageName = "03-page.png",
                    Color = Color.Red,
                    Title = "A Mother's Warning",
                    TopLeftLabel = new TextLabel {
                        Text = "As she left her house to find her friends and share her idea, her mother said:",
                        Color = Color.White,
                        ColumnSpan = 2,
                        VerticalAlignment = TextAlignment.Start,
                        HorizontalAlignment = TextAlignment.Start,
                        VoiceClip = new VoiceClip {ClipName = "03-killed.mp3" }
                    },
                    TopRightLabel = new TextLabel {
                        Text = "'Titania, remember your friends have games they want to play too. Compromise and you'll have a good time!'",
                        Color = Color.White,
                        RowSpan = 2,
                        VerticalAlignment = TextAlignment.Start,
                        HorizontalAlignment = TextAlignment.End,
                        VoiceClip = new VoiceClip {ClipName = "03-killed.mp3" }
                    },
                    BottomRightLabel = new TextLabel {
                        Text = "'Okay! Bye Mom,' said Titania.",
                        Color = Color.White,
                        VerticalAlignment = TextAlignment.End,
                        HorizontalAlignment = TextAlignment.End,
                        VoiceClip = new VoiceClip {ClipName = "03-2-adventure.mp3" },
                    }
                },
                new BooksDataModel {
                    ImageName = "04-page.jpg",
                    Color = Color.Fuchsia,
                    Title = "Titania Meets a Princess",
                    TopCenterLabel = new TextLabel {
                        Text = "Titania arrived at her first friend’s house. 'Come play! Will you help me be Queen of the Forest?'",
                        HorizontalAlignment = TextAlignment.End,
                        VerticalAlignment = TextAlignment.Start,
                        ColumnSpan = 2
                    },
                    MiddleLeftLabel = new TextLabel {
                        Text = "'I will not be a dinosaur,' her friend said. 'But I want to help. I am a Princess!'",
                        HorizontalAlignment = TextAlignment.Start,
                        VerticalAlignment = TextAlignment.Center,
                        ColumnSpan = 2
                    },
                    BottomRightLabel = new TextLabel {
                        Text = "'Of course!' Titania replied.",
                        HorizontalAlignment = TextAlignment.End,
                        VerticalAlignment = TextAlignment.End
                    }
                },
                new BooksDataModel {
                    ImageName = "05-page.jpg",
                    Color = Color.FromHex("AA9900"),
                    Title = "The Fairy Princess' Blessing",
                    TopLeftLabel = new TextLabel {
                        Text = "The Princess thought what Titania needed most was a crown.",
                        HorizontalAlignment = TextAlignment.Start,
                        VerticalAlignment = TextAlignment.Start,
                        RowSpan = 2
                    },
                    TopCenterLabel = new TextLabel {
                        Text = "But because all fairytale things must come in threes, she thought Titania also needed fairy wings, and a royal feast.",
                        HorizontalAlignment = TextAlignment.End,
                        VerticalAlignment = TextAlignment.Start,
                        ColumnSpan = 2
                    },
                    BottomLeftLabel = new TextLabel {
                        Text = "With three magical items in place, the girls were on their way.",
                        HorizontalAlignment = TextAlignment.Center,
                        VerticalAlignment = TextAlignment.End,
                        ColumnSpan = 3
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

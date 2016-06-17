using Xamarin.Forms;

namespace Majestasaurus.Portable
{
    public class TextLabel
    {
        public string Text { get; set; }

        public Color Color { get; set; }

        public VoiceClip VoiceClip { get; set; }

        public int ColumnSpan { get; set; }

        public int RowSpan { get; set; }

        public TextAlignment VerticalAlignment { get; set; }

        public TextAlignment HorizontalAlignment { get; set; }

        public FontAttributes FontAttributes { get; set; }

        public TextLabel()
        {
            ColumnSpan = 1;
            RowSpan = 1;
            VerticalAlignment = TextAlignment.End;
            HorizontalAlignment = TextAlignment.Start;
            FontAttributes = FontAttributes.Bold;
        }
    }
}
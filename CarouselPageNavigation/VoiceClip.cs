using System.ComponentModel;

namespace Majestasaurus.Portable
{
    public class VoiceClip : INotifyPropertyChanged
    {
        private bool isPlaying;
        private int durationMilliseconds;
        private string clipName;

        public int DurationMilliseconds { get { return durationMilliseconds; } set { durationMilliseconds = value; OnPropertyChanged("DurationMilliseconds"); } }

        public string ClipName { get { return clipName; } set { clipName = value; OnPropertyChanged("ClipName"); } }

        public bool IsPlaying { get { return isPlaying; } set { isPlaying = value; OnPropertyChanged("IsPlaying"); } }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
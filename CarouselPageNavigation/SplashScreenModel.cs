using System.ComponentModel;

namespace Majestasaurus.Portable
{
    internal class SplashScreenModel : INotifyPropertyChanged
    {
        private string mainText;
        private double progress;
        public string MainText { get { return mainText; } set { mainText = value; OnPropertyChanged("MainText"); } }
        public double Progress { get { return progress; } set { progress = value; OnPropertyChanged("Progress"); } }
        public SplashScreenModel()
        {
            mainText = "";
            progress = 0;
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
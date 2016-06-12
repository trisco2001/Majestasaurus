using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Majestasaurus.Portable.Services;

namespace Majestasaurus.Droid.Services
{
    class AudioServiceAndroid : IAudioService
    {
        public bool EffectsOn { get;set; }

        public float EffectsVolume { get; set; }

        public bool MusicOn { get; set; }

        public float MusicVolume { get; set; }

        public void PlayBackgroundMusic(string filename)
        {
            
        }

        public void PlaySound(string fileName)
        {
            
        }

        public void RestartBackgroundMusic()
        {
            
        }

        public void StopBackgroundMusic()
        {
            
        }

        public void StopSound()
        {
            
        }

        public void SuspendBackgroundMusic()
        {
            
        }
    }
}
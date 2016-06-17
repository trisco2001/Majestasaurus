using AVFoundation;
using Foundation;
using Majestasaurus.Portable;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Majestasaurus.iOS.Services
{
    class VoiceClipPlayer
    {
        private VoiceClip voiceClip;
        private AVAudioPlayer voiceTrack;

        public VoiceClipPlayer(VoiceClip voiceClip)
        {
            this.voiceClip = voiceClip;
        }

        public async void Play(float effectsVolume)
        {
            if (voiceTrack != null)
            {
                await FadeOut();
            }

            NSUrl songURL = new NSUrl("Sounds/" + voiceClip.ClipName);
            NSError err;
            voiceTrack = new AVAudioPlayer(songURL, "wav", out err);
            voiceTrack.Volume = effectsVolume;
            voiceTrack.NumberOfLoops = 0;
            voiceTrack.Play();
            voiceTrack.FinishedPlaying += VoiceTrack_FinishedPlaying;
            voiceClip.IsPlaying = true;
        }

        private void VoiceTrack_FinishedPlaying(object sender, AVStatusEventArgs e)
        {
            voiceClip.IsPlaying = false;
        }

        public async Task FadeOut()
        {
            if (voiceTrack.Volume > 0.1f)
            {
                voiceTrack.Volume -= 0.1f;
                await Task.Delay(100);
                await FadeOut();
            }
            else
            {
                voiceClip.IsPlaying = false;
                voiceTrack.Dispose();
            }
        }
    }
}

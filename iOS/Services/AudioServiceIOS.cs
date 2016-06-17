using System;
using System.Collections.Generic;
using System.Text;

using Majestasaurus.Portable.Services;
using Foundation;
using AVFoundation;
using System.Threading.Tasks;
using System.Diagnostics;
using Majestasaurus.Portable;

namespace Majestasaurus.iOS.Services
{
    class AudioServiceIOS : IAudioService
    {

        #region Private Variables
        private static AVAudioPlayer backgroundMusic;
        private AVAudioPlayer soundEffect;
        private static string backgroundSong = "";
        private static VoiceClipPlayer voiceClipPlayer;
        #endregion

        public AudioServiceIOS()
        {
            EffectsOn = true;
            EffectsVolume = 1;
        }

        public bool EffectsOn { get; set; }

        public float EffectsVolume { get; set; }

        #region Computed Properties
        public float BackgroundMusicVolume
        {
            get { return backgroundMusic.Volume; }
            set { backgroundMusic.Volume = value; }
        }
        #endregion

        public bool MusicOn { get; set; } = true;
        public float MusicVolume { get; set; } = 0.5f;


        public void PlayBackgroundMusic(string filename)
        {
            NSUrl songURL;

            // Music enabled?
            if (!MusicOn) return;

            // Any existing background music?
            if (backgroundMusic != null)
            {
                //Stop and dispose of any background music
                backgroundMusic.Stop();
                backgroundMusic.Dispose();
            }

            // Initialize background music
            songURL = new NSUrl("Sounds/" + filename);
            NSError err;
            backgroundMusic = new AVAudioPlayer(songURL, "wav", out err);
            backgroundMusic.Volume = MusicVolume;
            backgroundMusic.NumberOfLoops = -1;
            backgroundMusic.Play();
            backgroundSong = filename;

        }

        public async void StopBackgroundMusic()
        {

            // If any background music is playing, stop it
            backgroundSong = "";
            if (backgroundMusic != null)
            {
                await FadeOutSound(backgroundMusic);
            }
        }

        public void SuspendBackgroundMusic()
        {

            // If any background music is playing, stop it
            if (backgroundMusic != null)
            {
                backgroundMusic.Stop();
                backgroundMusic.Dispose();
            }
        }

        public void RestartBackgroundMusic()
        {

            // Music enabled?
            if (!MusicOn) return;

            // Was a song previously playing?
            if (backgroundSong == "") return;

            // Restart song to fix issue with wonky music after sleep
            PlayBackgroundMusic(backgroundSong);
        }

        public void PlaySound(string fileName)
        {
            NSUrl songURL;

            // Music enabled?
            if (!EffectsOn) return;

            // Any existing sound effect?
            if (soundEffect != null)
            {
                //Stop and dispose of any sound effect
                soundEffect.Stop();
                soundEffect.Dispose();
            }

            // Initialize effect
            songURL = new NSUrl("Sounds/" + fileName);
            NSError err;
            soundEffect = new AVAudioPlayer(songURL, "wav", out err);
            soundEffect.Volume = EffectsVolume;
            soundEffect.FinishedPlaying += delegate {
                soundEffect = null;
            };
            soundEffect.NumberOfLoops = 0;
            soundEffect.Play();
        }

        public async void StopSound()
        {
            if (soundEffect != null)
            {
                await FadeOutSound(soundEffect);
            }
        }

        private async Task FadeOutSound(AVAudioPlayer player)
        {
            if (player.Volume > 0.1f)
            {
                Debug.WriteLine(player.Volume);
                player.Volume -= 0.1f;
                await Task.Delay(100);
                await FadeOutSound(player);
            }
            else
            {
                player.Dispose();
            }
        }

        public async void StopVoiceTrack()
        {
            if (voiceClipPlayer != null)
            {
                await voiceClipPlayer.FadeOut();
            }
        }

        public void PlayVoiceTrack(VoiceClip voiceClip)
        {
            voiceClip.IsPlaying = true;
            StopVoiceTrack();

            voiceClipPlayer = new VoiceClipPlayer(voiceClip);
            voiceClipPlayer.Play(EffectsVolume);
        }
    }
}

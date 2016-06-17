using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majestasaurus.Portable.Services
{
    public interface IAudioService
    {
        bool EffectsOn { get; set; }

        bool MusicOn { get; set; }

        float MusicVolume { get; set; }

        float EffectsVolume { get; set; }

        void PlaySound(string fileName);

        void PlayVoiceTrack(VoiceClip voiceClip);

        void StopSound();

        void RestartBackgroundMusic();

        void SuspendBackgroundMusic();

        void StopBackgroundMusic();

        void StopVoiceTrack();

        void PlayBackgroundMusic(string filename);
    }
}

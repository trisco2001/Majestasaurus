namespace Majestasaurus.Portable.Services
{
    public interface IVoiceClipWatcher
    {
        void NotifyVoiceTrackStopped(VoiceClip voiceClip);
    }
}
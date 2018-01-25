namespace ServicesFactory.Interfaces
{
    public interface IAudioService
    {
        void Play(string path);
        void Stop();
        AudioFileInfo GetAudioFileInfo(string path);

    }
}

using System;
using System.IO;
using NAudio.Wave;
using ServicesFactory.Interfaces;

namespace ServicesFactory.Services
{
    internal class AudioService : IAudioService
    {
        private static readonly Lazy<AudioService> Instance = new Lazy<AudioService>(() => new AudioService(), true);
        private readonly WaveOut _waveOut;
        private Mp3FileReader _reader;

        private AudioService()
        {
            _waveOut = new WaveOut();
        }

        public static AudioService GetInstance()
        {
            return Instance.Value;
        }

        public void Play(string path)
        {
            _waveOut.Init(_reader);
            _waveOut.Play();
        }

        public void Stop()
        {
            _waveOut.Stop();
        }

        public AudioFileInfo GetAudioFileInfo(string path)
        {
            _reader = new Mp3FileReader(path);
            var fileInfo = new FileInfo(path);

            var result = new AudioFileInfo
            {
                Name = fileInfo.Name,
                Duration = _reader.TotalTime,
                FileSize = Math.Round((double)fileInfo.Length / 1000000, 2)
            };

            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace ServicesFactory
{
    public class AudioService
    {
        private static readonly Lazy<AudioService> Instance = new Lazy<AudioService>(() => new AudioService(), true);
        private readonly WaveOut _waveOut = new WaveOut();
        private Mp3FileReader _reader;

        private AudioService()
        {
        }

        public static AudioService GetInstance()
        {
            return Instance.Value;
        }
        
        public void Play(string path)
        {
            _reader = new Mp3FileReader(path);
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

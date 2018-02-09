using ServicesFactory.Interfaces;
using ServicesFactory.Services;

namespace ServicesFactory
{
    public class ServiceFactory
    {
        public IAudioService GetAudioService()
        {
            return AudioService.GetInstance();
        }

        public IMessageBoxService GetMessageBoxService()
        {
            return MessageBoxService.GetInstance();
        }

        public IFileService GetFileService()
        {
            return FileService.GetInstance();
        }


    }
}

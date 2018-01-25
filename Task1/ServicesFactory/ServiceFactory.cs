namespace ServicesFactory
{
    public class ServiceFactory
    {
        public AudioService GetAudioService()
        {
            return AudioService.GetInstance();
        }

        public MessageBoxService GetMessageBoxService()
        {
            return MessageBoxService.GetInstance();
        }

        public FileService GetFileService()
        {
            return FileService.GetInstance();
        }


    }
}

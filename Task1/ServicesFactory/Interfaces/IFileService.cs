namespace ServicesFactory.Interfaces
{
    public interface IFileService
    {
        string ReadFile(string path);
        void WriteFile(string sourcePath, string destPath);
        void DeleteFile(string path);
        void MoveFile(string sourceFile, string destinationFile);
    }
}

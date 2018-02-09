using System;
using System.IO;
using ServicesFactory.Interfaces;

namespace ServicesFactory.Services
{
    internal class FileService : IFileService
    {
        private static readonly Lazy<FileService> Instance = new Lazy<FileService>(() => new FileService(), true);
        public static FileService GetInstance()
        {
            return Instance.Value;
        }

        private FileService()
        {
        }

        public string ReadFile(string path)
        {
            try
            {
                var info = new FileInfo(path);
                if (info.Extension.Equals("txt"))
                    return File.ReadAllText(path);
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void WriteFile(string sourcePath, string destPath)
        {
            try
            {
                using (var streamSource = new FileStream(sourcePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var streamDestination = new FileStream(destPath, FileMode.Create, FileAccess.Write, FileShare.Write))
                {
                    for (int i = 0; i < streamSource.Length - 1; i++)
                    {
                        streamDestination.WriteByte((byte)streamSource.ReadByte());
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void MoveFile(string sourceFile, string destinationFile)
        {
            try
            {
                File.Move(sourceFile, destinationFile);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

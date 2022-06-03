using FileLoader.Models;
using System.Collections.Generic;

namespace FileLoader.Repositories
{
    public interface IFileRepository
    {
        void UpdateLink(FileModel file);
        void AddAllFiles(List<FileModel> files);
        FileModel GetFile(string link);
        IEnumerable<FileModel> GetAllFiles();
    }
}

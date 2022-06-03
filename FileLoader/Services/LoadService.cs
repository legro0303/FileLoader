using FileLoader.Models;
using FileLoader.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileLoader.Services
{
    public class LoadService
    {
        private readonly string fileStorage = "C:\\storage\\";
        private readonly string fullLinkKey = "generatedLink";
        private readonly string partLinkKey = "generatedPartOfLink";
        private readonly FileRepository fileRepository;

        public LoadService(FileRepository fileRepository)
        {
            this.fileRepository = fileRepository;
        }

        public string PutFileToTheStorage(IFormFile file, string newName)
        {
            string path = createPath(newName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            return path;
        }
        public List<FileModel> GetListOfFilesEntities(List<IFormFile> files, string host)
        {
            List<FileModel> listOfFiles = new List<FileModel>(files.Count);
            foreach (IFormFile formFile in files)
            {
                FileModel file = new FileModel();//ПРИДУМАТЬ КАК СОЗДАВАТЬ СУЩНОСТЬ ПО УМНЕЕ
                file.OriginalName = formFile.FileName;
                file.StorageName = generateStorageName(file.OriginalName, Path.GetExtension(formFile.FileName));
                file.Path = PutFileToTheStorage(formFile, file.StorageName);
                Dictionary<string, string> map = createLink(host);
                file.FullLink = map["generatedLink"];
                file.GeneratedPartOfLink = map["generatedPartOfLink"];
                listOfFiles.Add(file);
            }
            return listOfFiles;
        }
        public void AddToDb(List<FileModel> files)
        {
            fileRepository.AddAllFiles(files);
        }
        public void ChangeLink(string link)
        {
            FileModel file = fileRepository.GetFile(link);
            if (file != null)
            {
                string host = file.FullLink.Remove(file.FullLink.IndexOf("/Download"));
                Dictionary<string, string> map = createLink(host);
                file.FullLink = map[fullLinkKey];
                file.GeneratedPartOfLink = map[partLinkKey];
                fileRepository.UpdateLink(file);
            }
        }
        
        private string generateStorageName(string originalName, string extension)
        {
            return generateRandomString() + extension;
        }

        private string createPath(String newName)
        {
            createDirectory();
            string path = fileStorage + newName;
            return path;
        }
        private void createDirectory()
        {
            if (!Directory.Exists(fileStorage))
            {
                Directory.CreateDirectory(fileStorage);
            }
        }
        private Dictionary<string, string> createLink(string host)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            string generatedPartOfLink = generateRandomString();
            map.Add(partLinkKey, generatedPartOfLink);
            string generatedLink = host + "/Download/Index/" + generatedPartOfLink;
            map.Add(fullLinkKey, generatedLink);
            return map;
        }
        private string generateRandomString()
        {
            return Math.Abs(Guid.NewGuid().GetHashCode()).ToString();
        }
    }
}

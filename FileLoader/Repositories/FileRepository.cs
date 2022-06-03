using FileLoader.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FileLoader.Repositories
{
    public class FileRepository:IFileRepository
    {
        private readonly Context context;
        public FileRepository(Context context)
        {
            this.context = context;
        }
        public IEnumerable<FileModel> GetAllFiles()
        {
            List<FileModel> files = new List<FileModel>();
            files = context.Files.OrderBy(p => p.Id).ToList();
            return files;
        }

        public void AddAllFiles(List<FileModel> files)
        {
            context.AddRange(files);
            context.SaveChanges();
        }

        public FileModel GetFile(string link)
        {
            try {
                return context.Files.Single(x => x.GeneratedPartOfLink==link);
            } catch(InvalidOperationException ex) {
                return null;
            }

        }
        public void UpdateLink(FileModel file)
        {
            //context.Update(file);
            context.Entry(file).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}

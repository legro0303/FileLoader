using FileLoader.Repositories;
using Microsoft.AspNetCore.Mvc;
using MimeTypes;
using FileLoader.Services;
using FileLoader.Models;
using System.Net;

namespace FileLoader.Controllers
{
    public class DownloadController : Controller
    {
        private readonly FileRepository fileRepository;
        private readonly LoadService loadService;

        public DownloadController(FileRepository fileRepository, LoadService loadService)
        {
            this.loadService = loadService;
            this.fileRepository = fileRepository;
        }
        public IActionResult ChangeLink(string link)
        {
            loadService.ChangeLink(link);
            return RedirectToAction("Index", "ListOfFiles");
        }
        public IActionResult Index(string link)
        {
            FileModel file = fileRepository.GetFile(link);
            if (file != null)
            {
                byte[] content = System.IO.File.ReadAllBytes(file.Path); 
                string contentType = MimeTypeMap.GetMimeType(file.OriginalName);
                loadService.ChangeLink(link);
                return File(content, contentType, file.OriginalName);
            }
            else return NotFound(new string("Ссылка больше не является действительной"));
        }
    }
}

using FileLoader.DTO;
using FileLoader.Repositories;
using FileLoader.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FileLoader.Controllers
{
    public class UploadController : Controller
    {
        private readonly FileRepository fileRepository;
        private readonly LoadService loadService;

        public UploadController(FileRepository fileRepository, LoadService loadService)
        {
            this.fileRepository = fileRepository;
            this.loadService = loadService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFiles(List<IFormFile> files)
        {
            string host = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
            loadService.AddToDb(loadService.GetListOfFilesEntities(files, host));
            List<UploadedFileDTO> filesList = new List<UploadedFileDTO>();
            foreach (IFormFile formFile in files) {
                if (files != null) {
                    filesList.Add(new UploadedFileDTO(formFile.FileName, true));
                }
                else
                {
                    filesList.Add(new UploadedFileDTO(formFile.FileName, false));
                }
            }
            return new JsonResult(filesList);
        }
    }
}

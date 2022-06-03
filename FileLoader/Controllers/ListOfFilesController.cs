using FileLoader.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FileLoader.Controllers
{
    public class ListOfFilesController : Controller
    {
        private readonly FileRepository fileRepository;
        public ListOfFilesController(FileRepository fileRepository)
        {
            this.fileRepository = fileRepository;
        }
        public IActionResult Index()
        {
            return View(fileRepository.GetAllFiles());
        }
    }
}

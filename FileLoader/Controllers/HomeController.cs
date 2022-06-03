using FileLoader.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebApplication1.Models;

namespace FileLoader.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FileRepository fileRepository;
        private readonly Context context;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(FileRepository fileRepository, Context context) { 
        this.fileRepository = fileRepository;
        this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upload()
        {
            return RedirectToAction("Index", "Upload");
        }

        public IActionResult ListOfFiles()
        {
            return RedirectToAction("Index", "ListOfFiles");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

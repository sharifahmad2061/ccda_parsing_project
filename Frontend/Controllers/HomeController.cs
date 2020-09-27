using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using System;
using MessageHandler.Services;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICreateMessage _taskHandler;

        public HomeController(ILogger<HomeController> logger, ICreateMessage taskHandler)
        {
            _logger = logger;
            _taskHandler = taskHandler;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CcdaParser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CcdaParser(MessageHandler.TaskModel DataModel)
        {
            Console.WriteLine(DataModel.PracticeCode);
            Console.WriteLine(DataModel.DataStorePath);
            Console.WriteLine(DataModel.EmailOnCompletion);
            _taskHandler.QueueTask(DataModel);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

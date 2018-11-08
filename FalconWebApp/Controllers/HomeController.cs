using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FalconWebApp.Models;
using FalconLib.Abstract;
using FalconLib.Concrete.Model;

namespace FalconWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<RemoteFeedElement> _repo;

        public HomeController(IRepository<RemoteFeedElement> repo){
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            _repo.GetAll();
            return View();
        }

        public IActionResult GetAll(){
            return Json(_repo.GetAll());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Age=2, Name="Sif"};

            return View(doggo);
        }

        public IActionResult Hello()
        {
            DogViewModel doggo = new DogViewModel() { Age = 4, Name = "Lesse" };

            return View(doggo);
        }
    }
}
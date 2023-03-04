using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel dog = new DogViewModel() { Age=2, Name="Sif"};

            return View(dog);
        }

        public IActionResult Create()
        {
            var dogViewModel = new DogViewModel();

            return View(dogViewModel);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            return View();
        }

        public IActionResult Hello()
        {
            DogViewModel dog = new DogViewModel() { Age = 4, Name = "Lesse" };

            return View(dog);
        }
    }
}
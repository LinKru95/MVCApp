using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            DogViewModel dogViewModel = new DogViewModel();

            return View(dogViewModel);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);

            return RedirectToAction("Index");
        }

        public IActionResult Hello()
        {
            DogViewModel dog = new DogViewModel() { Age = 4, Name = "Lesse" };

            return View(dog);
        }
    }
}
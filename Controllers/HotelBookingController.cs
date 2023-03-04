using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HotelBookingController : Controller
    {
        private static List<HotelBookingModel> hotelBookings = new List<HotelBookingModel>();

        public IActionResult Index()
        {
            return View(hotelBookings);
        }

        public IActionResult Create()
        {
            HotelBookingModel hotelBookingModel = new HotelBookingModel();

            return View(hotelBookingModel);
        }

        public IActionResult CreateHotelBooking(HotelBookingModel hotelBookingModel)
        {
            hotelBookings.Add(hotelBookingModel);

            return RedirectToAction("Index");
        }
    }
}

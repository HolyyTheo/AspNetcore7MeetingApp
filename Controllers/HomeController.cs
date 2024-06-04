using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            // ViewBag.Selam = saat > 12 ? "İyi Günler" : "Günaydın";
            // ViewBag.Username = "OĞUZHAN";
             ViewData["Selam"] = saat > 12 ? "İyi Günler" : "Günaydın";
          //   ViewData["Username"] = "OĞUZHAN";
            var meetingInfo = new MeetingInfo() 
            { 
                Id = 1,
                Location = "Adana, Nazım Hikmet Kültür Merkezi",
                Date = new DateTime(2024,06,06,20,0,0),
                NumberOfPeople = 100
            };
            return View(meetingInfo);
        }
    }
}
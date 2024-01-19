using CURDusingEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace CURDusingEF.Controllers
{
    public class BookingController : Controller
    {

        public readonly DatabaseContext _context;
        public BookingController(DatabaseContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult roombook()
        {

            return View();
        }
        [HttpPost]
        public IActionResult roombook(BookingModel obj)
        {
            if (obj == null)
            {

            }
            else
            {
                if(ModelState.IsValid)
                {
                    _context.Add(obj);
                    int x = _context.SaveChanges(); 
                    if (x > 0)
                    {
                        return RedirectToAction("Home", "Account");
                    }

                }
            }
            return View();
        }
    }
}

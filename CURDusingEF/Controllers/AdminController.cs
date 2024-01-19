using CURDusingEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace CURDusingEF.Controllers
{
    public class AdminController : Controller
    {
        public readonly DatabaseContext _context;
        public AdminController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Admin()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddRoom()
        {

            return View();
        }


        [HttpPost]
        public IActionResult AddRoom(AccountModel obj)
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
                        return RedirectToAction("Index", "Room");
                    }
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int? RoomId)
        {
            var res = _context.AccountModel.Find(RoomId);

            return View(res);
        }
        [HttpPost]
        public IActionResult Edit(AccountModel obj, int? RoomId)
        {
            if (obj == null)
            {

            }
            else
            {
                if (ModelState.IsValid)
                {
                    _context.Update(obj);
                    int x = _context.SaveChanges();
                    if (x > 0)
                    {
                        return RedirectToAction("ViewRoom", "Admin");
                    }
                }
            }
            return View();
        }

        public IActionResult ViewRoom() 
        {
            var res = from s in _context.AccountModel select s;
            return View(res.ToList());
        }

        public  new IActionResult Request()
        {
            var res = from s in _context.BookingModel select s;
            return View(res.ToList());
            
        }

    }
}

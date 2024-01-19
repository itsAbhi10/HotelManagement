
using CURDusingEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace CURDusingEF.Controllers
{
    
    public class AccountController : Controller
    {
        public readonly DatabaseContext _context;
        public AccountController(DatabaseContext context) {
            _context = context;
        }

       
        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact obj)
        {
            if (obj == null)
            {

            }
            else
            {
                if (ModelState.IsValid)
                {
                    _context.Contact.Add(obj);
                    int x = _context.SaveChanges();
                    if (x > 0)
                    {
                        return RedirectToAction("Home", "Account");
                    }

                }
            }
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

      
       
    }
    
}

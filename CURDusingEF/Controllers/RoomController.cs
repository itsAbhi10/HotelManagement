using CURDusingEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace CURDusingEF.Controllers
{
    public class RoomController : Controller
    {
        public readonly DatabaseContext _context;
        public RoomController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var res = from s in _context.AccountModel select s;

            return View(res.ToList());
        }
    }
}

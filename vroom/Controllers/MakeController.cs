using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vroom.AppDbContext;
using vroom.Models;

namespace vroom.Controllers
{
    public class MakeController : Controller
    {
        private readonly VroomDbContext _db;

        public MakeController(VroomDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Makes.ToList());
        }
    }
}

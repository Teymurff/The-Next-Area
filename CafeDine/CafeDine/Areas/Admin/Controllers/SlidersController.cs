using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CafeDine.DAL;
using CafeDine.Models;

namespace CafeDine.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly DineContext _context;

        public SlidersController(DineContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders);
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
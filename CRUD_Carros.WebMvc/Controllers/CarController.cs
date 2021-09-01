using CRUD_Carros.WebMvc.Models;
using CRUD_Carros.WebMvc.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Carros.WebMvc.Controllers
{
    public class CarController : Controller
    {
        private readonly Context _dbContext;

        public CarController(Context dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _dbContext.Cars.ToListAsync();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _dbContext.AddAsync(car);
            return RedirectToAction(nameof(Index));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovies.Data;

namespace MvcMovies.Controllers
{
    public class CategoryController : Controller


    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }

        //public IActionResult Data()
        //{
        //    var categories = from c in _context.Categories select c;
        //    var parser = new Parser<Category>(Request.Form, categories);
        //    return Json(parser.Parse());
        //}

        //[HttpGet]
        //public async Task<IActionResult> Details(long? id)
        //{
        //    if (id == null) return NotFound();
        //    var res = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        //    if (res == null) return NotFound();
        //    return PartialView("_Details", res);

        //}

    }
}
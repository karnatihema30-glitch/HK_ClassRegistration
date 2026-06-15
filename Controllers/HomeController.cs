using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HK_Registration.Data;
using HK_Registration.Models;

namespace HK_Registration.Controllers
{
    public class HomeController : Controller
    {
        private readonly CourseRegistrationContext _context;

        public HomeController(CourseRegistrationContext context)
        {
            _context = context;
        }
        // GET: Home/Add
        public IActionResult Index()
        {
            var classes = _context.Classes.ToList();
            return View(classes);
        }
        
        public IActionResult Add()
        {
         return View();
        }
    
        // POST: Home/Add
        [HttpPost]
        public IActionResult Add(HKClass hkClass)
        {
            if (ModelState.IsValid)
            {
             _context.Classes.Add(hkClass);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
            }

            return View(hkClass);
        }       
         // GET: Home/Edit
        public IActionResult Edit(int id)
        {
        var course = _context.Classes.Find(id);

        if (course == null)
        return NotFound();

        return View("Add", course);
}

 // POST: Home/Edit
[HttpPost]
public IActionResult Edit(HKClass hkClass)
{
    if (ModelState.IsValid)
    {
        _context.Classes.Update(hkClass);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    return View("Add", hkClass);
}
        // GET: Home/Delete
        public IActionResult Delete(int id)
        {
            var course = _context.Classes.Find(id);

            if (course == null)
                return NotFound();

            return View(course);
        }

        // POST: Home/Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var course = _context.Classes.Find(id);

            if (course == null)
                return NotFound();

            _context.Classes.Remove(course);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
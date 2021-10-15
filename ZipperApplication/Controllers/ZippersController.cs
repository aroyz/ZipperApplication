using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZipperApplication.Data;
using ZipperApplication.Models;

namespace ZipperApplication.Controllers
{
    public class ZippersController : Controller
    {
        private readonly ZipperApplicationContext _context;

        public ZippersController(ZipperApplicationContext context)
        {
            _context = context;
        }

        // GET: Zippers
        public async Task<IActionResult> Index(string zipperType, string searchString) //added zipperType and searchString as parameters for Index
        {
            //use LINQ to get list of genres
            IQueryable<string> typeQuery = from z in _context.Zipper
                                           orderby z.Type
                                           select z.Type;

            //LINQ query to select the zippers
            var zippers = from z in _context.Zipper
                          select z;

            if (!string.IsNullOrEmpty(searchString)) //does code in curly brackets if searchString is NOT null or empty
            {
                zippers = zippers.Where(s => s.Name.Contains(searchString)); //sets zippers variable to contain only the zippers whose Name contains what's stored in searchString
            } //end if

            if (!string.IsNullOrEmpty(zipperType)) //does code in curly brackets if zipperType is NOT null or empty
            {
                zippers = zippers.Where(x => x.Type == zipperType); //sets zippers variable to contain only the zippers whose Type is the type in zipperType
            } //end if

            var zipperTypeVM = new ZipperTypeViewModel //creates a new item of type ZipperTypeViewModel
            {
                Types = new SelectList(await typeQuery.Distinct().ToListAsync()), //sets value of Types
                Zippers = await zippers.ToListAsync() //sets value of Zippers
            };

            return View(zipperTypeVM);
        }

        // GET: Zippers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zipper = await _context.Zipper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zipper == null)
            {
                return NotFound();
            }

            return View(zipper);
        }

        // GET: Zippers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zippers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,Length,Size,TapeColour,Closure,Price,Rating")] Zipper zipper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zipper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zipper);
        }

        // GET: Zippers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zipper = await _context.Zipper.FindAsync(id);
            if (zipper == null)
            {
                return NotFound();
            }
            return View(zipper);
        }

        // POST: Zippers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,Length,Size,TapeColour,Closure,Price,Rating")] Zipper zipper)
        {
            if (id != zipper.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zipper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZipperExists(zipper.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(zipper);
        }

        // GET: Zippers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zipper = await _context.Zipper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zipper == null)
            {
                return NotFound();
            }

            return View(zipper);
        }

        // POST: Zippers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zipper = await _context.Zipper.FindAsync(id);
            _context.Zipper.Remove(zipper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZipperExists(int id)
        {
            return _context.Zipper.Any(e => e.Id == id);
        }
    }
}

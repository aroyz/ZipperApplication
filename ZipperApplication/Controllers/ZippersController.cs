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
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zipper.ToListAsync());
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

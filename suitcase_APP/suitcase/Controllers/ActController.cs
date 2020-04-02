using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using suitcase.Data;
using suitcase.Models;

namespace suitcase.Controllers
{
    public class ActController : Controller
    {
        private readonly Context _context;

        public ActController(Context context)
        {
            _context = context;
        }

        // GET: Act
        public async Task<IActionResult> Index()
        {
            var context = _context.Acts.Include(a => a.Performance);
            return View(await context.ToListAsync());
        }

        // GET: Act/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var act = await _context.Acts
                .Include(a => a.Performance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (act == null)
            {
                return NotFound();
            }

            return View(act);
        }

        // GET: Act/Create
        public IActionResult Create()
        {
            ViewData["PerformanceId"] = new SelectList(_context.Performances, "Id", "Id");
            return View();
        }

        // POST: Act/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PerformanceId,Id,Name")] Act act)
        {
            if (ModelState.IsValid)
            {
                act.Id = Guid.NewGuid();
                _context.Add(act);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PerformanceId"] = new SelectList(_context.Performances, "Id", "Id", act.PerformanceId);
            return View(act);
        }

        // GET: Act/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var act = await _context.Acts.FindAsync(id);
            if (act == null)
            {
                return NotFound();
            }
            ViewData["PerformanceId"] = new SelectList(_context.Performances, "Id", "Id", act.PerformanceId);
            return View(act);
        }

        // POST: Act/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PerformanceId,Id,Name")] Act act)
        {
            if (id != act.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(act);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActExists(act.Id))
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
            ViewData["PerformanceId"] = new SelectList(_context.Performances, "Id", "Id", act.PerformanceId);
            return View(act);
        }

        // GET: Act/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var act = await _context.Acts
                .Include(a => a.Performance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (act == null)
            {
                return NotFound();
            }

            return View(act);
        }

        // POST: Act/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var act = await _context.Acts.FindAsync(id);
            _context.Acts.Remove(act);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActExists(Guid id)
        {
            return _context.Acts.Any(e => e.Id == id);
        }
    }
}

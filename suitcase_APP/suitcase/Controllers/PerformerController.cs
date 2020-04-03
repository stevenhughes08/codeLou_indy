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
    public class PerformerController : Controller
    {
        private readonly Context _context;

        public PerformerController(Context context)
        {
            _context = context;
        }

        // GET: Performer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Performers.ToListAsync());
        }

        // GET: Performer/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var performer = await _context.Performers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (performer == null)
            {
                return NotFound();
            }

            return View(performer);
        }

        // GET: Performer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Performer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HeadShotUrl,Id,Name")] Performer performer)
        {
            if (ModelState.IsValid)
            {
                performer.Id = Guid.NewGuid();
                _context.Add(performer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(performer);
        }

        // GET: Performer/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var performer = await _context.Performers.FindAsync(id);
            if (performer == null)
            {
                return NotFound();
            }
            return View(performer);
        }

        // POST: Performer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("HeadShotUrl,Id,Name")] Performer performer)
        {
            if (id != performer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(performer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerformerExists(performer.Id))
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
            return View(performer);
        }

        // GET: Performer/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var performer = await _context.Performers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (performer == null)
            {
                return NotFound();
            }

            return View(performer);
        }

        // POST: Performer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var performer = await _context.Performers.FindAsync(id);
            _context.Performers.Remove(performer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerformerExists(Guid id)
        {
            return _context.Performers.Any(e => e.Id == id);
        }
    }
}

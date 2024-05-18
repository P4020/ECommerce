using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class CarrelloController : Controller
    {
        private readonly dbContext _context;

        public CarrelloController(dbContext context)
        {
            _context = context;
        }

        // GET: Carrello
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carrello.ToListAsync());
        }

        // GET: Carrello/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrello = await _context.Carrello
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carrello == null)
            {
                return NotFound();
            }

            return View(carrello);
        }

        // GET: Carrello/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carrello/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descrizione,DataRilascio,genere,Prezzo")] Carrello carrello)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carrello);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carrello);
        }

        // GET: Carrello/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrello = await _context.Carrello.FindAsync(id);
            if (carrello == null)
            {
                return NotFound();
            }
            return View(carrello);
        }

        // POST: Carrello/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descrizione,DataRilascio,genere,Prezzo")] Carrello carrello)
        {
            if (id != carrello.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carrello);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarrelloExists(carrello.Id))
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
            return View(carrello);
        }

        // GET: Carrello/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrello = await _context.Carrello
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carrello == null)
            {
                return NotFound();
            }

            return View(carrello);
        }

        // POST: Carrello/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carrello = await _context.Carrello.FindAsync(id);
            if (carrello != null)
            {
                _context.Carrello.Remove(carrello);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarrelloExists(int id)
        {
            return _context.Carrello.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Models;

namespace PruebaComponentesObdulio.Controllers
{
    public class PedidoComponentesController : Controller
    {
        private readonly TiendaOrdenadoresContext _context;

        public PedidoComponentesController(TiendaOrdenadoresContext context)
        {
            _context = context;
        }

        // GET: PedidoComponentes
        public async Task<IActionResult> Index()
        {
              return _context.PedidoComponentes != null ? 
                          View(await _context.PedidoComponentes.ToListAsync()) :
                          Problem("Entity set 'TiendaOrdenadoresContext.PedidoComponentes'  is null.");
        }

        // GET: PedidoComponentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PedidoComponentes == null)
            {
                return NotFound();
            }

            var pedidoComponentes = await _context.PedidoComponentes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidoComponentes == null)
            {
                return NotFound();
            }

            return View(pedidoComponentes);
        }

        // GET: PedidoComponentes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PedidoComponentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumeroPedido,Cliente")] PedidoComponentes pedidoComponentes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedidoComponentes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pedidoComponentes);
        }

        // GET: PedidoComponentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PedidoComponentes == null)
            {
                return NotFound();
            }

            var pedidoComponentes = await _context.PedidoComponentes.FindAsync(id);
            if (pedidoComponentes == null)
            {
                return NotFound();
            }
            return View(pedidoComponentes);
        }

        // POST: PedidoComponentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumeroPedido,Cliente")] PedidoComponentes pedidoComponentes)
        {
            if (id != pedidoComponentes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedidoComponentes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoComponentesExists(pedidoComponentes.Id))
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
            return View(pedidoComponentes);
        }

        // GET: PedidoComponentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PedidoComponentes == null)
            {
                return NotFound();
            }

            var pedidoComponentes = await _context.PedidoComponentes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidoComponentes == null)
            {
                return NotFound();
            }

            return View(pedidoComponentes);
        }

        // POST: PedidoComponentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PedidoComponentes == null)
            {
                return Problem("Entity set 'TiendaOrdenadoresContext.PedidoComponentes'  is null.");
            }
            var pedidoComponentes = await _context.PedidoComponentes.FindAsync(id);
            if (pedidoComponentes != null)
            {
                _context.PedidoComponentes.Remove(pedidoComponentes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoComponentesExists(int id)
        {
          return (_context.PedidoComponentes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

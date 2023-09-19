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
    public class PedidoOrdenadoresController : Controller
    {
        private readonly TiendaOrdenadoresContext _context;

        public PedidoOrdenadoresController(TiendaOrdenadoresContext context)
        {
            _context = context;
        }

        // GET: PedidoOrdenadores
        public async Task<IActionResult> Index()
        {
              return _context.PedidoOrdenadores != null ? 
                          View(await _context.PedidoOrdenadores.ToListAsync()) :
                          Problem("Entity set 'TiendaOrdenadoresContext.PedidoOrdenadores'  is null.");
        }

        // GET: PedidoOrdenadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PedidoOrdenadores == null)
            {
                return NotFound();
            }

            var pedidoOrdenadores = await _context.PedidoOrdenadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidoOrdenadores == null)
            {
                return NotFound();
            }

            return View(pedidoOrdenadores);
        }

        // GET: PedidoOrdenadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PedidoOrdenadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumeroPedido,Cliente")] PedidoOrdenadores pedidoOrdenadores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedidoOrdenadores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pedidoOrdenadores);
        }

        // GET: PedidoOrdenadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PedidoOrdenadores == null)
            {
                return NotFound();
            }

            var pedidoOrdenadores = await _context.PedidoOrdenadores.FindAsync(id);
            if (pedidoOrdenadores == null)
            {
                return NotFound();
            }
            return View(pedidoOrdenadores);
        }

        // POST: PedidoOrdenadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumeroPedido,Cliente")] PedidoOrdenadores pedidoOrdenadores)
        {
            if (id != pedidoOrdenadores.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedidoOrdenadores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoOrdenadoresExists(pedidoOrdenadores.Id))
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
            return View(pedidoOrdenadores);
        }

        // GET: PedidoOrdenadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PedidoOrdenadores == null)
            {
                return NotFound();
            }

            var pedidoOrdenadores = await _context.PedidoOrdenadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidoOrdenadores == null)
            {
                return NotFound();
            }

            return View(pedidoOrdenadores);
        }

        // POST: PedidoOrdenadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PedidoOrdenadores == null)
            {
                return Problem("Entity set 'TiendaOrdenadoresContext.PedidoOrdenadores'  is null.");
            }
            var pedidoOrdenadores = await _context.PedidoOrdenadores.FindAsync(id);
            if (pedidoOrdenadores != null)
            {
                _context.PedidoOrdenadores.Remove(pedidoOrdenadores);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoOrdenadoresExists(int id)
        {
          return (_context.PedidoOrdenadores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

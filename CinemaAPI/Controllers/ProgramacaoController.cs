using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaAPI.Contexto;
using CinemaAPI.Models;

namespace CinemaAPI.Controllers
{
    public class ProgramacaoController : Controller
    {
        private readonly CinemaContexto _context;

        public ProgramacaoController(CinemaContexto context)
        {
            _context = context;
        }

        // GET: Programacao
        public async Task<IActionResult> Index()
        {
            var cinemaContexto = _context.Programacao.Include(p => p.Cinema);
            return View(await cinemaContexto.ToListAsync());
        }

        // GET: Programacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programacao = await _context.Programacao
                .Include(p => p.Cinema)
                .FirstOrDefaultAsync(m => m.ProgramacaoId == id);
            if (programacao == null)
            {
                return NotFound();
            }

            return View(programacao);
        }

        // GET: Programacao/Create
        public IActionResult Create()
        {
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "CinemaId");
            return View();
        }

        // POST: Programacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProgramacaoId,DataLancamento,FilmeHoje,FilmeSemana,CinemaId")] Programacao programacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "CinemaId", programacao.CinemaId);
            return View(programacao);
        }

        // GET: Programacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programacao = await _context.Programacao.FindAsync(id);
            if (programacao == null)
            {
                return NotFound();
            }
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "CinemaId", programacao.CinemaId);
            return View(programacao);
        }

        // POST: Programacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProgramacaoId,DataLancamento,FilmeHoje,FilmeSemana,CinemaId")] Programacao programacao)
        {
            if (id != programacao.ProgramacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramacaoExists(programacao.ProgramacaoId))
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
            ViewData["CinemaId"] = new SelectList(_context.Cinema, "CinemaId", "CinemaId", programacao.CinemaId);
            return View(programacao);
        }

        // GET: Programacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programacao = await _context.Programacao
                .Include(p => p.Cinema)
                .FirstOrDefaultAsync(m => m.ProgramacaoId == id);
            if (programacao == null)
            {
                return NotFound();
            }

            return View(programacao);
        }

        // POST: Programacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programacao = await _context.Programacao.FindAsync(id);
            _context.Programacao.Remove(programacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramacaoExists(int id)
        {
            return _context.Programacao.Any(e => e.ProgramacaoId == id);
        }
    }
}

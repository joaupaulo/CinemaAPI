using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemaAPI.Contexto;
using CinemaAPI.Models;

namespace CinemaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramacaoController : ControllerBase
    {
        private readonly CinemaContexto _context;

        public ProgramacaoController(CinemaContexto context)
        {
            _context = context;
        }

        // GET: api/Programacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Programacao>>> GetProgramacao()
        {
            return await _context.Programacao.ToListAsync();
        }

        // GET: api/Programacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Programacao>> GetProgramacao(int id)
        {
            var programacao = await _context.Programacao.FindAsync(id);

            if (programacao == null)
            {
                return NotFound();
            }

            return programacao;
        }

        // PUT: api/Programacao/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProgramacao(int id, Programacao programacao)
        {
            if (id != programacao.Id)
            {
                return BadRequest();
            }

            _context.Entry(programacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramacaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Programacao
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Programacao>> PostProgramacao(Programacao programacao)
        {
            _context.Programacao.Add(programacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProgramacao", new { id = programacao.Id }, programacao);
        }

        // DELETE: api/Programacao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgramacao(int id)
        {
            var programacao = await _context.Programacao.FindAsync(id);
            if (programacao == null)
            {
                return NotFound();
            }

            _context.Programacao.Remove(programacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProgramacaoExists(int id)
        {
            return _context.Programacao.Any(e => e.Id == id);
        }
    }
}

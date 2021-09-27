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
    public class IngressoController : ControllerBase
    {
        private readonly CinemaContexto _context;

        public IngressoController(CinemaContexto context)
        {
            _context = context;
        }

        // GET: api/Ingresso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingressos>>> GetIngressos()
        {
            return await _context.Ingressos.ToListAsync();
        }

        // GET: api/Ingresso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ingressos>> GetIngressos(int id)
        {
            var ingressos = await _context.Ingressos.FindAsync(id);

            if (ingressos == null)
            {
                return NotFound();
            }

            return ingressos;
        }

        // PUT: api/Ingresso/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngressos(int id, Ingressos ingressos)
        {
            if (id != ingressos.IngressoId)
            {
                return BadRequest();
            }

            _context.Entry(ingressos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngressosExists(id))
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

        // POST: api/Ingresso
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ingressos>> PostIngressos(Ingressos ingressos)
        {
            _context.Ingressos.Add(ingressos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIngressos", new { id = ingressos.IngressoId }, ingressos);
        }

        // DELETE: api/Ingresso/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngressos(int id)
        {
            var ingressos = await _context.Ingressos.FindAsync(id);
            if (ingressos == null)
            {
                return NotFound();
            }

            _context.Ingressos.Remove(ingressos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IngressosExists(int id)
        {
            return _context.Ingressos.Any(e => e.IngressoId == id);
        }
    }
}

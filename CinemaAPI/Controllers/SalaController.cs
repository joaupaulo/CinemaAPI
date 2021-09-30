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
    public class SalaController : ControllerBase
    {
        private readonly CinemaContexto _context;

        public SalaController(CinemaContexto context)
        {
            _context = context;
        }

        // GET: api/Sala
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sala>>> GetSala()
        {
            return await _context.Sala.ToListAsync();
        }

        // GET: api/Sala/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sala>> GetSala(int id)
        {
            var sala = await _context.Sala.FindAsync(id);

            if (sala == null)
            {
                return NotFound();
            }

            return sala;
        }

        // PUT: api/Sala/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSala(int id, Sala sala)
        {
            if (id != sala.Id)
            {
                return BadRequest();
            }

            _context.Entry(sala).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalaExists(id))
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

        // POST: api/Sala
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sala>> PostSala(Sala sala)
        {
            _context.Sala.Add(sala);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSala", new { id = sala.Id }, sala);
        }

        // DELETE: api/Sala/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSala(int id)
        {
            var sala = await _context.Sala.FindAsync(id);
            if (sala == null)
            {
                return NotFound();
            }

            _context.Sala.Remove(sala);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalaExists(int id)
        {
            return _context.Sala.Any(e => e.Id == id);
        }
    }
}

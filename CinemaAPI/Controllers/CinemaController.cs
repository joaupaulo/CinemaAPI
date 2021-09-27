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
    public class CinemaController : ControllerBase
    {
        private readonly CinemaContexto _context;

        public CinemaController(CinemaContexto context)
        {
            _context = context;
        }

        // GET: api/Cinema
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cinema>>> GetCinema()
        {
            return await _context.Cinema.ToListAsync();
        }

        // GET: api/Cinema/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cinema>> GetCinema(int id)
        {
            var cinema = await _context.Cinema.FindAsync(id);

            if (cinema == null)
            {
                return NotFound();
            }

            return cinema;
        }

        // PUT: api/Cinema/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCinema(int id, Cinema cinema)
        {
            if (id != cinema.CinemaId)
            {
                return BadRequest();
            }

            _context.Entry(cinema).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CinemaExists(id))
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

        // POST: api/Cinema
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cinema>> PostCinema(Cinema cinema)
        {
            _context.Cinema.Add(cinema);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCinema", new { id = cinema.CinemaId }, cinema);
        }

        // DELETE: api/Cinema/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCinema(int id)
        {
            var cinema = await _context.Cinema.FindAsync(id);
            if (cinema == null)
            {
                return NotFound();
            }

            _context.Cinema.Remove(cinema);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CinemaExists(int id)
        {
            return _context.Cinema.Any(e => e.CinemaId == id);
        }
    }
}

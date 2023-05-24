using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCustomComputers.Data;
using MyCustomComputers.Models;

namespace MyCustomComputers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnsController : ControllerBase
    {
        private readonly MyCustomComputersContext _context;

        public ReturnsController(MyCustomComputersContext context)
        {
            _context = context;
        }

        // GET: api/Returns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Return>>> GetReturn()
        {
          if (_context.Return == null)
          {
              return NotFound();
          }
            return await _context.Return.ToListAsync();
        }

        // GET: api/Returns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Return>> GetReturn(int id)
        {
          if (_context.Return == null)
          {
              return NotFound();
          }
            var @return = await _context.Return.FindAsync(id);

            if (@return == null)
            {
                return NotFound();
            }

            return @return;
        }

        // PUT: api/Returns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReturn(int id, Return @return)
        {
            if (id != @return.ID)
            {
                return BadRequest();
            }

            _context.Entry(@return).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReturnExists(id))
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

        // POST: api/Returns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Return>> PostReturn(Return @return)
        {
          if (_context.Return == null)
          {
              return Problem("Entity set 'MyCustomComputersContext.Return'  is null.");
          }
            _context.Return.Add(@return);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReturn", new { id = @return.ID }, @return);
        }

        // DELETE: api/Returns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReturn(int id)
        {
            if (_context.Return == null)
            {
                return NotFound();
            }
            var @return = await _context.Return.FindAsync(id);
            if (@return == null)
            {
                return NotFound();
            }

            _context.Return.Remove(@return);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReturnExists(int id)
        {
            return (_context.Return?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkoutApi.Models;

namespace WorkoutApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Sets")]
    public class SetsController : Controller
    {
        private readonly WorkoutApiContext _context;

        public SetsController(WorkoutApiContext context)
        {
            _context = context;
        }

        // GET: api/Sets
        [HttpGet]
        public IEnumerable<Set> GetSet()
        {
            return _context.Set;
        }

        // GET: api/Sets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSet([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @set = await _context.Set.SingleOrDefaultAsync(m => m.ID == id);

            if (@set == null)
            {
                return NotFound();
            }

            return Ok(@set);
        }

        // PUT: api/Sets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSet([FromRoute] int id, [FromBody] Set @set)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @set.ID)
            {
                return BadRequest();
            }

            _context.Entry(@set).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SetExists(id))
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

        // POST: api/Sets
        [HttpPost]
        public async Task<IActionResult> PostSet([FromBody] Set @set)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Set.Add(@set);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSet", new { id = @set.ID }, @set);
        }

        // DELETE: api/Sets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSet([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @set = await _context.Set.SingleOrDefaultAsync(m => m.ID == id);
            if (@set == null)
            {
                return NotFound();
            }

            _context.Set.Remove(@set);
            await _context.SaveChangesAsync();

            return Ok(@set);
        }

        private bool SetExists(int id)
        {
            return _context.Set.Any(e => e.ID == id);
        }
    }
}
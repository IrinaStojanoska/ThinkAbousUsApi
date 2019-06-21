using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThinkAboutApi.Models;

namespace ThinkAboutApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomelessDogsDetailsController : ControllerBase
    {
        private readonly HomelessDogsContext _context;

      
        public HomelessDogsDetailsController(HomelessDogsContext context)
        {
            _context = context;
        }

        // GET: api/HomelessDogsDetails
        [HttpGet]
        public IEnumerable<HomelessDogsDetails> GetDetails()
        {
            return _context.HomelessDogs;
        }

        // GET: api/HomelessDogsDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHomelessDogsDetails([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var homelessDogsDetails = await _context.HomelessDogs.FindAsync(id);

            if (homelessDogsDetails == null)
            {
                return NotFound();
            }

            return Ok(homelessDogsDetails);
        }

        // PUT: api/HomelessDogsDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHomelessDogsDetails([FromRoute] int id, [FromBody] HomelessDogsDetails homelessDogsDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != homelessDogsDetails.code)
            {
                return BadRequest();
            }

            _context.Entry(homelessDogsDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomelessDogsDetailsExists(id))
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

        // POST: api/HomelessDogsDetails
        [HttpPost]
        public async Task<IActionResult> PostHomelessDogsDetails([FromBody] HomelessDogsDetails homelessDogsDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.HomelessDogs.Add(homelessDogsDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHomelessDogsDetails", new { id = homelessDogsDetails.code }, homelessDogsDetails);
        }

        // DELETE: api/HomelessDogsDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomelessDogsDetails([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var homelessDogsDetails = await _context.HomelessDogs.FindAsync(id);
            if (homelessDogsDetails == null)
            {
                return NotFound();
            }

            _context.HomelessDogs.Remove(homelessDogsDetails);
            await _context.SaveChangesAsync();

            return Ok(homelessDogsDetails);
        }

        private bool HomelessDogsDetailsExists(int id)
        {
            return _context.HomelessDogs.Any(e => e.code == id);
        }
    }
}
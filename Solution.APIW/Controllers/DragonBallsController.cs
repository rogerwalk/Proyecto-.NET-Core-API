using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solution.APIW.Model;

namespace Solution.APIW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DragonBallsController : ControllerBase
    {
        private readonly Examen1Progra5Context _context;

        public DragonBallsController(Examen1Progra5Context context)
        {
            _context = context;
        }

        // GET: api/DragonBalls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DragonBall>>> GetDragonBall()
        {
            return await _context.DragonBall.ToListAsync();
        }

        // GET: api/DragonBalls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DragonBall>> GetDragonBall(int id)
        {
            var dragonBall = await _context.DragonBall.FindAsync(id);

            if (dragonBall == null)
            {
                return NotFound();
            }

            return dragonBall;
        }

        // PUT: api/DragonBalls/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDragonBall(int id, DragonBall dragonBall)
        {
            if (id != dragonBall.Id)
            {
                return BadRequest();
            }

            _context.Entry(dragonBall).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DragonBallExists(id))
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

        // POST: api/DragonBalls
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DragonBall>> PostDragonBall(DragonBall dragonBall)
        {
            _context.DragonBall.Add(dragonBall);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDragonBall", new { id = dragonBall.Id }, dragonBall);
        }

        // DELETE: api/DragonBalls/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DragonBall>> DeleteDragonBall(int id)
        {
            var dragonBall = await _context.DragonBall.FindAsync(id);
            if (dragonBall == null)
            {
                return NotFound();
            }

            _context.DragonBall.Remove(dragonBall);
            await _context.SaveChangesAsync();

            return dragonBall;
        }

        private bool DragonBallExists(int id)
        {
            return _context.DragonBall.Any(e => e.Id == id);
        }
    }
}

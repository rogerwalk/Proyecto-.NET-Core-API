
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.DAL.EF;
using data = Solution.DO.Objects;
namespace Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DragonBallController : Controller
    {
        private readonly SolutionDBContext _context;


        public DragonBallController(SolutionDBContext context)
        {
            _context = context;
        }


        // GET: api/DragonBall
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.DragonBall>>> GetDragonBall()
        {
            return new Solution.BS.DragonBall(_context).GetAll().ToList();
        }

        // GET: api/DragonBall/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.DragonBall>> GetDragonBall(int id)
        {
            var dragonBall = new Solution.BS.DragonBall(_context).GetOneById(id);

            if (dragonBall == null)
            {
                return NotFound();
            }

            return dragonBall;
        }
        // PUT: api/DragonBall/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDragonBall(int id, data.DragonBall dragonBall)
        {
            if (id != dragonBall.Id)
            {
                return BadRequest();
            }



            try
            {
                new Solution.BS.DragonBall(_context).Update(dragonBall);
            }
            catch (Exception)
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

        // POST: api/DragonBall
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<data.DragonBall>> PostDragonBall(data.DragonBall dragonBall)
        {
            new Solution.BS.DragonBall(_context).Insert(dragonBall);

            return CreatedAtAction("GetDragonBall", new { id = dragonBall.Id }, dragonBall);
        }

        // DELETE: api/DragonBall/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.DragonBall>> DeleteDragonBall(int id)
        {
            var dragonBall = new Solution.BS.DragonBall(_context).GetOneById(id);
            if (dragonBall == null)
            {
                return NotFound();
            }

            new Solution.BS.DragonBall(_context).Delete(dragonBall);

            return dragonBall;
        }

        private bool DragonBallExists(int id)
        {
            return (new Solution.BS.DragonBall(_context).GetOneById(id) != null);


        }

    }

}



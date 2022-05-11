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
    public class TransformersController : Controller
    {
        private readonly SolutionDBContext _context;


        public TransformersController(SolutionDBContext context)
        {
            _context = context;
        }


        // GET: api/Transformers
        [HttpGet]




        public async Task<ActionResult<IEnumerable<data.Transformers>>> GetTransformers()
        {
            return new Solution.BS.Transformers(_context).GetAll().ToList();
        }

        // GET: api/Transformers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Transformers>> GetTransformers(int id)
        {
            var transformers = new Solution.BS.Transformers(_context).GetOneById(id);

            if (transformers == null)
            {
                return NotFound();
            }

            return transformers;
        }

        // PUT: api/Transformers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransformers(int id, data.Transformers transformers)
        {
            if (id != transformers.Id)
            {
                return BadRequest();
            }



            try
            {
                new Solution.BS.Transformers(_context).Update(transformers);
            }
            catch (Exception)
            {
                if (!TransformersExists(id))
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

        // POST: api/Transformers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<data.Transformers>> PostTransformers(data.Transformers transformers)
        {
            new Solution.BS.Transformers(_context).Insert(transformers);

            return CreatedAtAction("GetTransformers", new { id = transformers.Id }, transformers);
        }

        // DELETE: api/Transformers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Transformers>> DeleteTransformers(int id)
        {
            var transformers = new Solution.BS.Transformers(_context).GetOneById(id);
            if (transformers == null)
            {
                return NotFound();
            }

            new Solution.BS.Transformers(_context).Delete(transformers);

            return transformers;
        }

        private bool TransformersExists(int id)
        {
            return (new Solution.BS.Transformers(_context).GetOneById(id) != null);


        }

    }

}


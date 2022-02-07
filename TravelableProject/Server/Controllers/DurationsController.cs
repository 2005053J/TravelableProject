using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelableProject.Server.Data;
using TravelableProject.Server.IRepository;
using TravelableProject.Shared.Domain;

namespace TravelableProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DurationsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public DurationsController(ApplicationDbContext context)
        public DurationsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Durations
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Duration>>> GetDurations()
        public async Task<IActionResult> GetDurations()
        {
            //return await _context.Durations.ToListAsync();
            var durations = await _unitOfWork.Durations.GetAll();
            return Ok(durations);
        }

        // GET: api/Durations/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Duration>> GetDuration(int id)
        public async Task<IActionResult> GetDuration(int id)
        {
            //var duration = await _context.Durations.FindAsync(id);
            var duration = await _unitOfWork.Durations.Get(q => q.Id == id);

            if (duration == null)
            {
                return NotFound();
            }

            //return duration;
            return Ok(duration);
        }

        // PUT: api/Durations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDuration(int id, Duration duration)
        {
            if (id != duration.Id)
            {
                return BadRequest();
            }

            //_context.Entry(duration).State = EntityState.Modified;
            _unitOfWork.Durations.Update(duration);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!DurationExists(id))
                if (!await DurationExists(id))
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

        // POST: api/Durations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Duration>> PostDuration(Duration duration)
        {
            //_context.Durations.Add(duration);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Durations.Insert(duration);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetDuration", new { id = duration.Id }, duration);
        }

        // DELETE: api/Durations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDuration(int id)
        {
            //var duration = await _context.Durations.FindAsync(id);
            var duration = await _unitOfWork.Durations.Get(q => q.Id == id);
            if (duration == null)
            {
                return NotFound();
            }

            //_context.Durations.Remove(duration);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Durations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool DurationExists(int id)
        private async Task<bool> DurationExists(int id)
        {
            //return _context.Durations.Any(e => e.Id == id);
            var duration = await _unitOfWork.Durations.Get(q => q.Id == id);
            return duration != null;
        }
    }
}

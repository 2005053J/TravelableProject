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
    public class HotelsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public HotelsController(ApplicationDbContext context)
        public HotelsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Hotels
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
        public async Task<IActionResult> GetHotels()
        {
            //return await _context.Hotels.ToListAsync();
            var hotels = await _unitOfWork.Hotels.GetAll();
            return Ok(hotels);
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Hotel>> GetHotel(int id)
        public async Task<IActionResult> GetHotel(int id)
        {
            //var hotel = await _context.Hotels.FindAsync(id);
            var hotel = await _unitOfWork.Hotels.Get(q => q.Id == id);

            if (hotel == null)
            {
                return NotFound();
            }

            //return hotel;
            return Ok(hotel);
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return BadRequest();
            }

            //_context.Entry(hotel).State = EntityState.Modified;
            _unitOfWork.Hotels.Update(hotel);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!HotelExists(id))
                if (!await HotelExists(id))
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

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
        {
            //_context.Hotels.Add(hotel);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Hotels.Insert(hotel);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetHotel", new { id = hotel.Id }, hotel);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            //var hotel = await _context.Hotels.FindAsync(id);
            var hotel = await _unitOfWork.Hotels.Get(q => q.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }

            //_context.Hotels.Remove(hotel);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Hotels.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool HotelExists(int id)
        private async Task<bool> HotelExists(int id)
        {
            //return _context.Hotels.Any(e => e.Id == id);
            var hotel = await _unitOfWork.Hotels.Get(q => q.Id == id);
            return hotel != null;
        }
    }
}

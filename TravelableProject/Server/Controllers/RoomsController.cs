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
    public class RoomsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public RoomsController(ApplicationDbContext context)
        public RoomsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Rooms
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        public async Task<IActionResult> GetRooms()
        {
            //return await _context.Rooms.ToListAsync();
            var rooms = await _unitOfWork.Rooms.GetAll();
            return Ok(rooms);
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Room>> GetRoom(int id)
        public async Task<IActionResult> GetRoom(int id)
        {
            //var room = await _context.Rooms.FindAsync(id);
            var room = await _unitOfWork.Rooms.Get(q => q.Id == id);

            if (room == null)
            {
                return NotFound();
            }

            //return room;
            return Ok(room);
        }

        // PUT: api/Rooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            if (id != room.Id)
            {
                return BadRequest();
            }

            //_context.Entry(room).State = EntityState.Modified;
            _unitOfWork.Rooms.Update(room);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!RoomExists(id))
                if (!await RoomExists(id))
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

        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            //_context.Rooms.Add(room);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Rooms.Insert(room);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRoom", new { id = room.Id }, room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            //var room = await _context.Rooms.FindAsync(id);
            var room = await _unitOfWork.Rooms.Get(q => q.Id == id);
            if (room == null)
            {
                return NotFound();
            }

            //_context.Rooms.Remove(room);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Rooms.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool RoomExists(int id)
        private async Task<bool> RoomExists(int id)
        {
            //return _context.Rooms.Any(e => e.Id == id);
            var room = await _unitOfWork.Rooms.Get(q => q.Id == id);
            return room != null;
        }
    }
}

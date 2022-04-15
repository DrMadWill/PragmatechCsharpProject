using ApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly ApiSchoolDbContext _dbContext;

        public ClassRoomController(ApiSchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.ClassRooms.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            var classRoom = await _dbContext.ClassRooms.FirstOrDefaultAsync(dr => dr.Id == id);
            if (classRoom == null) return NotFound();
            return Ok(classRoom);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ClassRoom classRoom)
        {
            if (ModelState.IsValid)
            {
                await _dbContext.ClassRooms.AddAsync(classRoom);
                await _dbContext.SaveChangesAsync();
                return Ok(classRoom);
            }
            return NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ClassRoom classRoom)
        {
            if (!ModelState.IsValid) return NotFound();
            var classRoomDb = await _dbContext.ClassRooms.FirstOrDefaultAsync(dr => dr.Id == classRoom.Id);
            if (classRoomDb == null) return NotFound();

            classRoomDb.Name = classRoom.Name;
            classRoomDb.Capacity = classRoom.Capacity;
            await _dbContext.SaveChangesAsync();
            return Ok(classRoomDb);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var classRoom = await _dbContext.ClassRooms.FirstOrDefaultAsync(dr => dr.Id == id);
            if (classRoom == null) return NotFound();
            _dbContext.ClassRooms.Remove(classRoom);
            await _dbContext.SaveChangesAsync();
            return Ok("Deleted");
        }

    }
}

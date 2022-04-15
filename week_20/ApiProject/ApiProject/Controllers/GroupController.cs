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
    public class GroupController : ControllerBase
    {
        private readonly ApiSchoolDbContext _dbContext;

        public GroupController(ApiSchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.Groups.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            var group = await _dbContext.Groups.Include(x=>x.Teacher).Include(x=>x.Students).FirstOrDefaultAsync(dr => dr.Id == id);
            if (group == null) return NotFound();
            return Ok(group);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Group group)
        {
            if (ModelState.IsValid)
            {
                var teacher = await _dbContext.Teachers.FirstOrDefaultAsync(dr => dr.Id == group.TeacherId);
                if (teacher == null) return NotFound();
                group.Teacher = teacher;
                await _dbContext.Groups.AddAsync(group);
                await _dbContext.SaveChangesAsync();
                return Ok(group);
            }
            return NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Group group)
        {
            if (!ModelState.IsValid) return NotFound();
            var groupDb = await _dbContext.Groups.FirstOrDefaultAsync(dr => dr.Id == group.Id);
            if (groupDb == null) return NotFound();

            var teacher = await _dbContext.Teachers.FirstOrDefaultAsync(dr => dr.Id == group.TeacherId);
            if (teacher == null) return NotFound();

            groupDb.Name = group.Name;
            groupDb.TeacherId = group.TeacherId;

            await _dbContext.SaveChangesAsync();
            return Ok(groupDb);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var group = await _dbContext.Groups.Include(x=>x.Students).FirstOrDefaultAsync(dr => dr.Id == id);
            if (group == null) return NotFound();
            _dbContext.Groups.Remove(group);
            await _dbContext.SaveChangesAsync();
            return Ok("Deleted");
        }
    }
}

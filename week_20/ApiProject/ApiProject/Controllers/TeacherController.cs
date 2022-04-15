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
    public class TeacherController : ControllerBase
    {
        private readonly ApiSchoolDbContext _dbContext;

        public TeacherController(ApiSchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.Teachers.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            var teacher = await _dbContext.Teachers.FirstOrDefaultAsync(dr => dr.Id == id);
            if (teacher == null) return NotFound();
            return Ok(teacher);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                await _dbContext.Teachers.AddAsync(teacher);
                await _dbContext.SaveChangesAsync();
                return Ok(teacher);
            }
            return NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Teacher teacher)
        {
            if (!ModelState.IsValid) return NotFound();
            var teacherDB = await _dbContext.Teachers.FirstOrDefaultAsync(dr => dr.Id == teacher.Id);
            if (teacherDB == null) return NotFound();

            teacherDB.Email = teacher.Email;
            teacherDB.FullName = teacher.FullName;

            await _dbContext.SaveChangesAsync();
            return Ok(teacherDB);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var teacher = await _dbContext.Teachers.Include(c=>c.Groups).FirstOrDefaultAsync(dr => dr.Id == id);
            if (teacher == null) return NotFound();

            _dbContext.Teachers.Remove(teacher);
            await _dbContext.SaveChangesAsync();

            return Ok("Deleted");
        }

    }
}

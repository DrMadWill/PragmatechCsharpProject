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
    public class StudentController : ControllerBase
    {
        private readonly ApiSchoolDbContext _dbContext;

        public StudentController(ApiSchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.Students.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            var student = await _dbContext.Students.Include(x => x.Group).FirstOrDefaultAsync(dr => dr.Id == id);
            if (student == null) return NotFound();
            return Ok(student);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Student student)
        {
            if (ModelState.IsValid)
            {
                var group = await _dbContext.Groups.FirstOrDefaultAsync(dr => dr.Id == student.GroupId);
                if (group == null) return NotFound();
                student.Group = group;
                await _dbContext.Students.AddAsync(student);
                await _dbContext.SaveChangesAsync();
                return Ok(student);
            }
            return NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Student student)
        {
            if (!ModelState.IsValid) return NotFound();
            var studentDB = await _dbContext.Students.FirstOrDefaultAsync(dr => dr.Id == student.Id);
            if (studentDB == null) return NotFound();

            var group = await _dbContext.Groups.FirstOrDefaultAsync(dr => dr.Id == student.GroupId);
            if (group == null) return NotFound();

            studentDB.FullName = student.FullName;
            studentDB.Email = student.Email;
            studentDB.GroupId = student.GroupId;
            studentDB.Group = group;
            await _dbContext.SaveChangesAsync();
            return Ok(studentDB);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var student = await _dbContext.Students.FirstOrDefaultAsync(dr => dr.Id == id);
            if (student == null) return NotFound();
            _dbContext.Students.Remove(student);
            await _dbContext.SaveChangesAsync();
            return Ok("Deleted");
        }
    }
}

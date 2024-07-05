using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P418App.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _studentService.GetAll();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _studentService.GetById(id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Add(StudentDto studentDto)
        {
            await _studentService.Add(studentDto);
            return CreatedAtAction(nameof(GetById), new { id = studentDto.Id }, studentDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] StudentDto studentDto)
        {
            if (id != studentDto.Id) return BadRequest();
            await _studentService.Update(studentDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _studentService.Delete(id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> Search([FromQuery] string name)
        {
            var students = await _studentService.Search(name);
            return Ok(students);
        }
    }
}

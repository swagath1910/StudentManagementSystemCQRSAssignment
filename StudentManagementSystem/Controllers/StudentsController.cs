using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.Commands;
using StudentManagementSystem.Application.Queries;

namespace StudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IMediator _mediator;
        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddStudentCommand studentCommand)
        {
            var id = await _mediator.Send(studentCommand);
            return Ok(new { Id = id });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _mediator.Send(new GetAllStudentsQuery());
            return Ok(students);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateStudentCommand command)
        {
            if (id != command.Id)
                return BadRequest("Route ID and Command ID must match.");
            var student = await _mediator.Send(command);
            if (!student)
                return NotFound();
            return Ok(student);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _mediator.Send(new DeleteStudentCommand(id));
            if (!student)
                return NotFound();
            return Ok("Student deleted Successfully");
        }

    }
}

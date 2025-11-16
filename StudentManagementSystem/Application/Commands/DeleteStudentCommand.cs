using MediatR;

namespace StudentManagementSystem.Application.Commands
{
    public record DeleteStudentCommand(int Id) : IRequest<bool> { }
}

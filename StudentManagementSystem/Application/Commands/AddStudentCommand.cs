using MediatR;
namespace StudentManagementSystem.Application.Commands
{
    public record AddStudentCommand(int Id, string Name, string Email, int Age) : IRequest<int>;
}

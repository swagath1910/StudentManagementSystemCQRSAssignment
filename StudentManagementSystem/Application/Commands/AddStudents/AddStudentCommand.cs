using MediatR;
namespace StudentManagementSystem.Application.Commands.AddStudents
{
    public record AddStudentCommand(int Id, string Name, string Email, int Age) : IRequest<int>;
}

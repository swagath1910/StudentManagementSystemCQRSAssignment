using MediatR;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Application.Queries
{
    public class GetAllStudentsQuery : IRequest<IEnumerable<Student>> { }
}

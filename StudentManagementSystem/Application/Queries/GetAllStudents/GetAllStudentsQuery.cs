using MediatR;
using StudentManagementSystem.Models;
using StudentManagementSystem.Application.Queries.GetAllStudents;
namespace StudentManagementSystem.Application.Queries.GetAllStudents
{
    public class GetAllStudentsQuery : IRequest<IEnumerable<Student>> { }
}

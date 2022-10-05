using OData.New.Models;

namespace OData.New.Services;

public interface IStudentService
{
    IQueryable<Student> RetrieveAllStudents();
}
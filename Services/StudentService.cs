using OData.New.Models;

namespace OData.New.Services;

public class StudentService : IStudentService
{
    public IQueryable<Student> RetrieveAllStudents()
    {
        return new List<Student>
        {
            new Student
            {
                Name = "Abdulaziz",
                Score = 200,
                Age = 16
            },
            new Student
            {
                Name = "Muhammad Diyor",
                Score = 154,
                Age = 18
            },
            new Student
            {
                Name = "Umidbek",
                Score = 200,
                Age = 25
            },
            new Student
            {
                Name = "Umidbek",
                Score = 200,
                Age = 25
            }

        }.AsQueryable();
    }
}
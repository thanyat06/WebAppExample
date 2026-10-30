using WebAppExample.Models;
using WebAppExample.DTOs;

namespace WebAppExample.Services;

public interface IStudentService
{
    List<StudentDto> GetAllStudents();

    StudentDto? GetStudentById(int id);

    StudentDto AddStudent(CreateStudentDto studentDto);

    StudentDto? UpdateStudent(int id, UpdateStudentDto studentDto);

    bool EmailExists(string email, int? id = null);
}
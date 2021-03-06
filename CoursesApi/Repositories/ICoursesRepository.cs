using System.Collections.Generic;
using CoursesApi.Models.DTOModels;
using CoursesApi.Models.ViewModels;

namespace CoursesApi.Repositories
{
    public interface ICoursesRepository
    {
        IEnumerable<CoursesListItemDTO> GetCourses(string semsester);
        CourseDetailsDTO GetCourseById(int courseId);
        CourseDetailsDTO AddCourse(CourseViewModel newCourse);
        CourseDetailsDTO UpdateCourse(int courseId, CourseViewModel updatedCourse);
        IEnumerable<StudentDTO> GetStudentsByCourseId(int courseId);
        IEnumerable<StudentDTO> GetWaitingStudentsByCourseId(int courseId);

        StudentDTO AddStudentToCourse(int courseId, StudentViewModel newStudent);
        StudentDTO AddStudentToCourseWaitingList(int courseId, StudentViewModel newStudent);

        bool DeleteCourseById(int courseId);

        bool RemoveStudentFromCourseBySSN(int courseId, string SSN);
        bool RemoveStudentFromWaitingList(int courseId, string SSN);

        int NumberOfStudentsEnrolled(int courseId);
    }
}



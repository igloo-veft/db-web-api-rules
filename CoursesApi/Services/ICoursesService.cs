using System;
using System.Collections.Generic;
using CoursesApi.Models.DTOModels;
using CoursesApi.Models.ViewModels;

namespace CoursesApi.Services
{
    public interface ICoursesService
    {
        IEnumerable<CoursesListItemDTO> GetCourses(string semester);
        CourseDetailsDTO GetCourseById(int courseId);
        IEnumerable<StudentDTO> GetStudentsByCourseId(int courseId);
        CourseDetailsDTO AddCourse(CourseViewModel newCourse);
        CourseDetailsDTO UpdateCourse(int courseId, CourseViewModel updatedCourse);
        StudentDTO AddStudentToCourse(int courseId, StudentViewModel newStudent);
        bool DeleteCourseById(int courseId);

        bool RemoveStudentFromCourseBySSN(int courseId, string SSN);
        IEnumerable<StudentDTO> GetWaitingListByCourseId(int courseId);
        StudentDTO AddStudentToWaitingList(int courseId, StudentViewModel newStudent);
        int NumberOfStudentsEnrolled(int courseId);
    }
}

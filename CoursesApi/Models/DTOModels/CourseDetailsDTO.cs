using System;
using System.Collections.Generic;

namespace CoursesApi.Models.DTOModels
{
    /// <summary>
    /// The course details exposed to the user. A more detailed version of course
    /// </summary>
    public class CourseDetailsDTO
    {
        public CourseDetailsDTO()
        {
            Students = new List<StudentDTO>();
            WaitingStudents = new List<StudentDTO>();
        }
        /// <summary>
        /// The id of the course
        /// </summary>
        /// <returns></returns>
        public int Id { get; set; }
        /// <summary>
        /// The name of the course
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; }
        /// <summary>
        /// The starting date of the course
        /// </summary>
        /// <returns></returns>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// The end date of the course
        /// </summary>
        /// <returns></returns>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// A list of students which are currently enrolled in this course
        /// </summary>
        /// <returns></returns>
        public List<StudentDTO> Students { get; set; }

        /// <summary>
        /// How many students can be enrolled in a course
        /// </summary>
        /// <returns></returns>
        public int MaxStudents { get; set; }
        /// <summary>
        /// A list of students who are currently on a waiting list for this course
        /// </summary>
        /// <returns></returns>
        public List<StudentDTO> WaitingStudents { get; set; }
    }
}
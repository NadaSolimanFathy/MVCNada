using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Entities
{
    public class Course: BaseEntity
    {






        [Required(ErrorMessage = "Course Name is required ")]
        public string CourseName { get; set; }


        [Required(ErrorMessage = "Course Start Date is required ")]

        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Course End Date is required ")]
        public DateTime EndDate { get; set; }


        //Total Grade => ex : this Course total Grade is 100 ,other maybe 50.
        [Required(ErrorMessage = "Course Total Grade is required ")]
        public int Grade { get; set; }



        [Required(ErrorMessage = "Course Price  is required ")]
        public int Price { get; set; }



        //unary/Self/Recursive Relationship
        public Course ParentCourse { get; set; }
        public int? ParentCourseId { get; set; }


        List<CourseInstructor> CourseInstructors { get; set; }

        List<StudentCrsFeedback> StudentCrsFeedbacks { get; set; }

        List<StudentCourse> StudentCourses { get; set; }


    }
}

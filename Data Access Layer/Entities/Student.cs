using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Access_Layer.Entities
{
    public class Student:Person
    {


        List<StudentCrsFeedback> StudentCrsFeedbacks { get; set; }

        List<StudentCourse> StudentCourses { get; set; }


    }
}

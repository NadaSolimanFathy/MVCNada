using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Entities
{
    public class CourseInstructor
    {

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
        public int CourseId { get; set; }

        public int InstructorId { get; set; }

    }
}

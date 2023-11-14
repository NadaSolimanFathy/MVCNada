using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Entities
{
    public class StudentCrsFeedback
    {
        //ex: nada soliman's feedback on PL1 course

        public Course Course { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public string FeedBack { get; set; }
    }
}

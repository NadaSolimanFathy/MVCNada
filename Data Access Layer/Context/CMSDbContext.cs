using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Context
{
    public  class CMSDbContext:DbContext
    {
        //what this part do ???
        public CMSDbContext(DbContextOptions<CMSDbContext> options) : base(options)
        {

        }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CourseInstructor>()
                .HasKey(CrsIst => new { CrsIst.InstructorId, CrsIst.CourseId });



            modelBuilder.Entity<StudentCourse>()
                .HasKey(StuCrs => new { StuCrs.StudentId, StuCrs.CourseId });



            modelBuilder.Entity<StudentCrsFeedback>()
                .HasKey(StuCrs => new { StuCrs.StudentId, StuCrs.CourseId });

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Course>()
                        .Property(crs => crs.ParentCourseId)
                        .IsRequired(false);//optinal case

            base.OnModelCreating(modelBuilder);

        }
        DbSet<Student> Students { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<Admin> Admins { get; set; }
        DbSet<Course> Courses { get; set; }

        DbSet<CourseInstructor> CourseInstructors { get; set; }
        DbSet<StudentCourse> StudentCourses { get; set; }
        DbSet<StudentCrsFeedback> StudentCrsFeedbacks { get; set; }








    }
}

using EF_core_Assig3.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_Assig3.Context
{
    internal class ITIDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ITI_DataBase; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                 .HasMany(s => s.Courses)
                .WithOne(sc => sc.Student)
                .HasForeignKey(sc => sc.stud_ID)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Students)
                .WithOne(sc => sc.Course)
                .HasForeignKey(sc => sc.Course_ID)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();


            modelBuilder.Entity<Department>()
                .HasMany(d => d.Instructors)
                .WithOne(i => i.InsDepartment)
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Instructor>()
                .HasOne(d => d.InsDepartment)
                .WithMany(i => i.Instructors)
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Instructor>()
                .HasMany(i => i.courses)
                .WithOne(ci => ci.Instructor)
                .HasForeignKey(ci => ci.inst_ID);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Instructor)
                .WithOne(ci => ci.Course)
                .HasForeignKey(ci => ci.Course_ID);



        }
        //DbSet<Student> Students { get; set; }
        //DbSet<Course> Courses { get; set; }
        //DbSet<Stud_Course> StudentCourses { get; set; }

        //DbSet<Department> Departments { get; set; }
        //DbSet<Instructor> Instructors { get; set; }
        DbSet<Course_Inst> Course_Instructors{get; set;}
    }
}

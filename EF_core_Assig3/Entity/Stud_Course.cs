using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_Assig3.Entity
{
    [PrimaryKey(nameof(stud_ID), nameof(Course_ID))]

    internal class Stud_Course
    {
        [ForeignKey(nameof(Student))]
        public int stud_ID { get; set; }
        public Student Student { get; set; }


        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public int Grade { get; set; }
    }
}

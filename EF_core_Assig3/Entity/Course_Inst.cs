using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_Assig3.Entity
{
    [PrimaryKey(nameof(inst_ID), nameof(Course_ID))]
    internal class Course_Inst
    {
        [ForeignKey(nameof(Instructor))]
        public int inst_ID { get; set; }
        public Instructor Instructor { get; set; }


        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public string Evaluate { get; set; }
    }
}

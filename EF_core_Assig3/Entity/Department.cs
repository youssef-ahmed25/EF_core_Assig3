using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_Assig3.Entity
{
    internal class Department
    {
        [Key]
        public int dept_ID { get; set; }
        [Column("Name", TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HiringDate { get; set; }

        [ForeignKey(nameof(Instructor))]
        public int ins_ID { get; set; }
        [InverseProperty(nameof(Instructor.InsDepartment))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_Assig3.Entity
{
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stud_ID { get; set; }
        [Column("first", TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string Fname { get; set; }
        [Column("second", TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string Lname { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }

        public ICollection<Stud_Course> Courses { get; set; }=new HashSet<Stud_Course>();

        [ForeignKey(nameof(Department))]
        public int Dept_ID { get; set; }
        [InverseProperty(nameof(Department.Students))]
        public Department stuDepartment { get; set; }

    }
}

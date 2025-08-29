using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_Assig3.Entity
{
    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ins_ID { get; set; }
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Range(0, 1000)]
        public decimal Bouns { get; set; }
        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [MaxLength(100)]
        public string Adress { get; set; }

        public decimal HourRate { get; set; }
        [ForeignKey(nameof(Department))]
        public int Dept_ID { get; set; }

        [InverseProperty(nameof(Department.Instructors))]
        public Department InsDepartment { get; set; }




        //[InverseProperty(nameof(Course_Inst.ins_Course))]
        public ICollection<Course_Inst> courses { get; set; } = new HashSet<Course_Inst>();
    }
}

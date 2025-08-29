using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_Assig3.Entity
{
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cors_ID { get; set; }
        public int Duration { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]

        [MaxLength(500)]
        public string Description { get; set; }

        [InverseProperty(nameof(Stud_Course.Course))]
        public ICollection<Stud_Course> Students { get; set; } = new HashSet<Stud_Course>();

        [ForeignKey(nameof(Topic))]
        public int Topic_ID { get; set; }

        [InverseProperty(nameof(Topic.Courses))]
        public ICollection<Topic> CorsTopics { get; set; } = new HashSet<Topic>();


        //[InverseProperty(nameof(Course_Inst.Instructor))]
        public ICollection<Course_Inst> Instructor { get; set; } = new HashSet<Course_Inst>();


    }
}

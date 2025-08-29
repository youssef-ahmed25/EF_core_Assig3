using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_Assig3.Entity
{
    internal class Topic
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [InverseProperty(nameof(Course.CorsTopics))]
        public Course Courses { get; set; }

        
    }
}

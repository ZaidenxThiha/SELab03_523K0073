using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; }
    }
}

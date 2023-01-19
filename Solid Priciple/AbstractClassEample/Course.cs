using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Priciple.AbstractClassEample
{
    public abstract class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public abstract void Subscribe();
    }
}

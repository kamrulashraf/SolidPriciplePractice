using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Priciple.AbstractClassEample
{
    public class OnlineCourse : Course
    {
        public override void Subscribe()
        {
            Console.WriteLine("Online Course subscribed");
        }
    }
}

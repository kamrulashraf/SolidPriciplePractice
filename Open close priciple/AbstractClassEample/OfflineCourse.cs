using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Priciple.AbstractClassEample
{
    public class OfflineCourse : Course
    {
        public override void Subscribe()
        {
            Console.WriteLine("Offline course subscribed");
        }
    }
}

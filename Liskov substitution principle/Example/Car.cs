using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle.Example
{
    public class Car : Vehicle
    {
        private int width = 10;

        public override int GetInterioWidth()
        {
            return GetCabinWith();
        }
        public int GetCabinWith()
        {
            return width;
        }
    }
}

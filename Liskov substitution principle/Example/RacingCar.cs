using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle.Example
{
    public class RacingCar : Vehicle
    {
        public override int GetInterioWidth()
        {
            return GetCockpitWidth();
        }
        public int GetCockpitWidth()
        {
            return 20; // cockpit with
        }
    }
}

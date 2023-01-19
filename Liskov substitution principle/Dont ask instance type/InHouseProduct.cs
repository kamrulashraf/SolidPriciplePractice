using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle.Dontaskinstancetype
{
    public class InHouseProduct : Product
    {
        public override double GetDiscount()
        {
            double discount = 10; // retrive from database
            discount += this.GetExtraDiscount();
            return (double) discount;
        }

        public double GetExtraDiscount() {
            var discount = 10;
            var extraPercent = .10;
            return discount * extraPercent;
        }
    }
}

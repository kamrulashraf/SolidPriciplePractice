using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle.Dontaskinstancetype
{
    public class Product
    {
        public virtual double GetDiscount() {
            return 10; // may retrive data from database and return
        }
    }
}

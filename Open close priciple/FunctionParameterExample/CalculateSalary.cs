using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Priciple.FunctionParameterExample
{
    public class CalculateSalary
    {
        public int GetSalary(Func<double, double> getBounus) {
            double totalAmount = 100; // call database
            double discount = getBounus(totalAmount);

            return  (int) (totalAmount + discount); 
        }
    }
}

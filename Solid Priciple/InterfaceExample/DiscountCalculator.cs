using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Priciple.InterfaceExample
{
    public class DiscountCalculator
    {
        private ICustomerProfile profile { get; set; }

        public DiscountCalculator(ICustomerProfile profile)
        {
            this.profile = profile;
        }

        public double GetDiscount()
        {
            if (profile.IsLoyalCustomer())
            {
                return 20;
            }
            else return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Priciple.InterfaceExample
{
    public class CarInsuranceCustomerProfile : ICustomerProfile
    {
        public string GetCustomerInfo()
        {
            throw new NotImplementedException();
        }

        public bool IsLoyalCustomer()
        {
            return true;  // may be some thing else base on logic
        }
    }
}

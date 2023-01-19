using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Priciple
{
    public class HealthInsuranceCustomerProfile : ICustomerProfile
    {
        public string GetCustomerInfo()
        {
            throw new NotImplementedException();
        }

        public bool IsLoyalCustomer()
        {
            return true;
        }
    }
}

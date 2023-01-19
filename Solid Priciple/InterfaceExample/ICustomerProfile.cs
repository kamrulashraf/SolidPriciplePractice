using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Priciple
{
    public interface ICustomerProfile
    {
        public string GetCustomerInfo();
        public bool IsLoyalCustomer();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Second
{
    public class PaymentService
    {
        public void Payment(string type)
        {
            if(type == "card")
            {
                //payment by credit card
            }
            if(type == "cash")
            {
                //payment by cash
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Fifth
{
    public class Shop
    {
        private Cash _cash;

        public Shop(Cash cash)
        {
            _cash = cash;
        }

        public void DoPayment(int amount)
        {
            _cash.DoTransaction(amount);
        }
    }
}

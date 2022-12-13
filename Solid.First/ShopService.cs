using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.First
{
    public class ShopService
    {
        public Shop CreateShop(int id)
        {
            return new Shop { Id = id };
        }

        public void CreateOrder(Shop shop)
        {
            //create order
        }

        public void PrintOrder(int id)
        {
            //print order info
        }

        public void GetProductInfo(string category)
        {
            if(category == "pants")
            {
                //get pants info
            }
            if(category == "shoes")
            {
                //get shoes info
            }
        }
    }
}

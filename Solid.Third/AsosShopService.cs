﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Third
{
    public class AsosShopService : IShopService
    {
        public string GetLocationShop()
        {
            //нет имплементации, т к у онлайн магазина нет координат
            throw new NotImplementedException();
        }

        public string GetNameShop()
        {
            return "ASOS";
        }
    }
}

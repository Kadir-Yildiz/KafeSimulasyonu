﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeSimulasyonu
{
    internal class Menu
    {
        public string Ad { get; set; }
        public byte HazırlanmaSuresi { get; set; }


        public override string ToString()
        {
            return Ad;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram.Model
{
    internal class InventoryModel
    {
        public CommonProperties Rice { get; set; }
        public CommonProperties Pulses { get; set; }
        public CommonProperties Wheats { get; set; }
    }

    public class CommonProperties
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int PricePerKG { get; set; }
    }
}

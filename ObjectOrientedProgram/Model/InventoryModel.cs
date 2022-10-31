﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram.Model
{
    internal class InventoryModel
    {
        public List<CommonProperties> Rice { get; set; }
        public List<CommonProperties> Pulses { get; set; }
        public List<CommonProperties> Wheats { get; set; }
    }

    public class CommonProperties
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int PricePerKG { get; set; }
    }
}

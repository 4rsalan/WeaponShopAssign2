﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{   // This class implements a backpack as a linked list
    // The backpack can hold any number of weapons as long as maxWeight is not crossed.
    // If an attempt to add a weapon to backpack is rejected due to weight
    class Backpack
    {
        double maxWeight;
        double presentWeight;

        public Backpack(double mWeight)
        {
            maxWeight = mWeight;
            presentWeight = 0;
        }

    }
}

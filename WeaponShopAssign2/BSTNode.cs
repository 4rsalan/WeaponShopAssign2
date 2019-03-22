using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class BSTNode
    {
        public Weapon weapon;

        public BSTNode left, right;

        public BSTNode(Weapon w)
        {
            left = null;
            right = null;
            weapon = w;
        }
    }
}

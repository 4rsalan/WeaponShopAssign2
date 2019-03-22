using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class LinkedListNode
    {
        public LinkedListNode next;
        public Weapon weapon;

        public LinkedListNode(Weapon w)
        {
            next = null;
            weapon = w;
        }
    }
}

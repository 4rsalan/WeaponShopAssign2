using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssignmentGUI
{
    public class BSTNode
    {
        public Stack<Weapon> weapon;

        public BSTNode left, right;

        public BSTNode()
        {
            left = null;
            right = null;
            weapon = new Stack<Weapon>();
        }

        public void UpdateNode(string n, int rang, int dam, double w, double c, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                this.weapon.Push(new Weapon(n, rang, dam, w, c));
            }
        }

    }
}

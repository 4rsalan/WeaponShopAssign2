using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class Weapon
    {
        public string weaponName { get; set; }
        public int range;
        public int damage;
        public double weight;
        public double cost;

        public Weapon(string n, int rang, int dam, double w, double c)
        {
            weaponName = n;
            damage = dam;
            range = rang;
            weight = w;
            cost = c;
        }

        public string toString()
        {
            return "Weapon Name: " + weaponName + "\n" + 
                    "Damage: " + damage + "\n" + 
                    "Range: " + range + "\n" + 
                    "Weight: " + weight + "\n" + 
                    "Cost: " + cost + "\n";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class Player
    {
        public string name;
        public Backpack backpack;
        public int numItems;
        public double money;

        public Player(string n, double m)
        {
            name = n;
            money = m;
            numItems = 0;
            backpack = new Backpack(30);
        }
        /*
        public void buy(Weapon w)
        {
            Console.WriteLine(w.weaponName+" bought...");
            //backpack[numItems] = w;
            backpack.AddToBackpack(w);
            numItems++;
            Console.Write(numItems);
        }// */
        public string buyFromShop(Shop shop, Weapon w, int amount)
        {
            if (w.weight * amount + backpack.presentWeight > backpack.maxWeight)
            {
               // Console.WriteLine("You are to weak to carry these weapons");
                return "You are to weak to carry these weapons";
            }
            if (w.cost * amount > money)
            {
                //Console.WriteLine("You are to poor to buy these weapons");
                return "You are to poor to buy these weapons";
            }
            Stack<Weapon> purchestedWeapons = shop.buyWeapon(w.weaponName, amount);
            while (purchestedWeapons.Count > 0)
            {
                backpack.AddToBackpack(purchestedWeapons.Pop());
                money -= w.cost;
            }
            return $"You are the roud owner of {amount} {w.weaponName}s";
        }


        public void withdraw(double amt)
        {
            money = money - amt;
        }

        public bool inventoryFull()
        {
            bool full = false;
            if (numItems == 10) full = true;
            return full;
        }


        public void printCharacter()
        {
            Console.WriteLine(" Name:"+name+"\n Money:"+money);
            printBackpack();
        }

        public string printBackpack()
        {
            return backpack.PrintContents();
        }
        public string printPlayer()
        {
            return $"Name: {name}, Money: {money}" + backpack.PrintWeaponNames();
        }
    }
}

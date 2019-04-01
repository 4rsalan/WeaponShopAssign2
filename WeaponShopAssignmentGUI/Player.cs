using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssignmentGUI
{
    public class Player
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
        public Weapon SearchBackpack(string weaponName)
        {
            return backpack.findWeapon(weaponName);
        }
        public string buyFromShop(Shop shop, Weapon w, int amount)
        {
            if (w.weight * amount + backpack.presentWeight > backpack.maxWeight)
            {
                //Console.WriteLine("You are to weak to carry these weapons");
                return "You are to Weak to Carry this Weapon";
            }
            if (w.cost * amount > money)
            {
                //Console.WriteLine("You are to poor to buy these weapons");
                return "You are to Poor to Buy This Weapons";
            }
            Stack<Weapon> purchestedWeapons = shop.buyWeapon(w.weaponName, amount);
            if (purchestedWeapons == null)
                return "We do not sell that here";
            while (purchestedWeapons.Count > 0)
            {
                backpack.AddToBackpack(purchestedWeapons.Pop());
                money -= w.cost;
            }
            return "Weapon Purchest, Have nice day";
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
            /*
            Console.WriteLine(" "+name+", you own "+numItems+" Weapons:");
            for (int x = 0; x < numItems; x++)
            {
                Console.WriteLine(" "+backpack[x].weaponName);
            }
            Console.WriteLine();
            */
        }
    }
}

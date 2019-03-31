using System;

namespace WeaponShopAssign2
{
    class Program
    {


        public static void addWeapons(HashTable h)
        {
            Console.WriteLine("***********WELCOME TO THE WEAPON ADDING MENU*********");
            string weaponName; int weaponRange; int weaponDamage; double weaponWeight; double weaponCost;
            Console.WriteLine("Please enter the NAME of the Weapon ('end' to quit):");
            weaponName=Console.ReadLine();
            while (weaponName.CompareTo("end") != 0)
            {
                Console.WriteLine("Please enter the Range of the Weapon (0-10):");
                weaponRange= Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Please enter the Damage of the Weapon:");
                weaponDamage=Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Please enter the Weight of the Weapon (in pounds):");
                weaponWeight= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the Cost of the Weapon:");
                weaponCost=Convert.ToDouble(Console.ReadLine());
                Weapon w = new Weapon(weaponName, weaponRange, weaponDamage, weaponWeight, weaponCost);
                h.put(w);
                Console.WriteLine("Please enter the NAME of another Weapon ('end' to quit):");
                weaponName = Console.ReadLine();
            }
        }

        public static void showRoom(HashTable ht, Player player)
        {
            string choice;
            Console.WriteLine("WELCOME TO THE SHOWROOM!!!!");
            ht.printTable();
            Console.WriteLine(" You have "+player.money+" money.");
            Console.WriteLine("Please select a weapon to buy('end' to quit):");
            choice=Console.ReadLine();
            while (choice.CompareTo("end") != 0 && !player.inventoryFull())
            {
                Weapon weapon = ht.get(choice);
                if (weapon != null)
                {
                    if (weapon.cost > player.money)
                    {
                        Console.WriteLine("Insufficient funds to buy "+weapon.weaponName );
                    }
                    else
                    {
                        player.buyFromShop(shop, weapon, 1);
                        player.withdraw(weapon.cost);
                    }
                }
                else
                {
                    Console.WriteLine(" ** "+choice+" not found!! **" );
                }
                Console.WriteLine("Please select another weapon to buy('end' to quit):");
                choice = Console.ReadLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string pname;
            Console.WriteLine("Please enter Player name:");
            pname=Console.ReadLine();
            Player pl= new Player(pname,45);
            HashTable ht= new HashTable(101);
            addWeapons(ht);
            showRoom(ht, pl);
            pl.printCharacter();
            Console.ReadKey();

        }
    }
}

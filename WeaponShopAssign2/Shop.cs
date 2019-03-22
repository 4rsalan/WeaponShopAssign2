using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssign2
{
    class Shop
    {
        BSTNode root;

        public Shop()
        {

        }

        public void AddToStore(string n, int rang, int dam, double w, double c)
        {
                root = InsertHelper(root, n, rang, dam, w, c);
        }

        private BSTNode InsertHelper(BSTNode curr, string n, int rang, int dam, double w, double c)
        {
            Weapon newWeapon = new Weapon(n, rang, dam, w, c);
            if (curr == null) return new BSTNode(newWeapon);
            if (newWeapon.weaponName.CompareTo(curr.weapon.weaponName) < 0)
            {
                curr.left = InsertHelper(curr, n, rang, dam, w, c);

            }
            if (newWeapon.weaponName.CompareTo(curr.weapon.weaponName) > 0)
            {
                curr.right = InsertHelper(curr, n, rang, dam, w, c);

            }
            return curr;
        }

        public string Search(string wName)
        {
            return searchHelper(root, wName);
        }

        private string searchHelper(BSTNode curr, string wName)
        {
            if (curr == null) return "Weapon not found";
            if (curr.weapon.weaponName == wName) return "Weapon " + wName + " was found";
            if (curr.weapon.weaponName.CompareTo(curr.weapon.weaponName) < 0) return searchHelper(curr.left, wName);
            return searchHelper(curr.right, wName);
        }

        public void PrintInOrder()
        {
            InOrderTraversal(root);
        }

        private void InOrderTraversal(BSTNode curr)
        {
            if (curr == null) return;
            InOrderTraversal(curr.left);
            Console.WriteLine(curr.weapon.toString());
            InOrderTraversal(curr.right);
        }

    }
}

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

        public void AddToStore(string n, int rang, int dam, double w, double c, int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Please enter a value greater than zero");
            }
                root = InsertHelper(root, n, rang, dam, w, c, amount);
        }

        private BSTNode InsertHelper(BSTNode curr, string n, int rang, int dam, double w, double c, int amount)
        {
            Weapon newWeapon = new Weapon(n, rang, dam, w, c);
            if (curr == null) {
                BSTNode newNode = new BSTNode();
                newNode.UpdateNode(n, rang, dam, w, c, amount);
                return newNode;
            }
            if (curr.weapon.Peek().weaponName == n)
            {
                curr.UpdateNode(n, rang, dam, w, c, amount);
                return curr;
            }
            if (newWeapon.weaponName.CompareTo(curr.weapon.Peek().weaponName) < 0)
            {
                curr.left = InsertHelper(curr, n, rang, dam, w, c, amount);

            }
            if (newWeapon.weaponName.CompareTo(curr.weapon.Peek().weaponName) > 0)
            {
                curr.right = InsertHelper(curr, n, rang, dam, w, c, amount);

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
            if (curr.weapon.Peek().weaponName == wName) return "Weapon " + wName + " was found" + curr.weapon.Peek().toString();
            if (curr.weapon.Peek().weaponName.CompareTo(curr.weapon.Peek().weaponName) < 0) return searchHelper(curr.left, wName);
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
            Console.WriteLine(curr.weapon.Peek().toString());
            InOrderTraversal(curr.right);
        }

    }
}

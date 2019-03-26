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
            BSTNode node = getNode(wName);
            if (node != null)
            {
                return node.weapon.Peek().toString();
            }
            else
            {
                return "Weapon not found";
            }
        }

        public void PrintInOrder()
        {
            PrintInOrderHelper(root);
        }

        private void PrintInOrderHelper(BSTNode curr)
        {
            if (curr == null) return;
            PrintInOrderHelper(curr.left);
            Console.WriteLine(curr.weapon.Peek().toString());
            PrintInOrderHelper(curr.right);
        }

        private BSTNode getNode (string wName)
        {
            return getNodeHelper(root, wName);
        }
        private BSTNode getNodeHelper(BSTNode curr, string wName)
        {
            if (curr == null) return null;
            if (curr.weapon.Peek().weaponName == wName) return curr;
            if (curr.weapon.Peek().weaponName.CompareTo(curr.weapon.Peek().weaponName) < 0) return getNodeHelper(curr.left, wName);
            return getNodeHelper(curr.right, wName);
        }

        public Stack<Weapon> buyWeapon(string wName, int amount)
        {
            BSTNode node = getNode(wName);
            Stack<Weapon> purchestWeapons = new Stack<Weapon>();
            if (node == null) return null;
            for (int i = 0; i < amount || node.weapon.Count == 0; i++)
                purchestWeapons.Push(node.weapon.Pop());
            if (node.weapon.Count == 0)
                deleteNode(wName);
            return purchestWeapons;
        }

        public void deleteNode(string wName)
        {
            root = deleteNodeHelper(root, wName);
        }
        private BSTNode deleteNodeHelper(BSTNode curr, string wName)
        {
            if (curr == null) return null;
            int comparison = curr.weapon.Peek().weaponName.CompareTo(wName);
            if (comparison < 0)
                curr.left = deleteNodeHelper(curr.left, wName);
            if (comparison > 0)
                curr.right = deleteNodeHelper(curr.right, wName);
            if (comparison == 0)
            {
                //Case 1 delete a leaf node
                //Case 2 delete a node that has a single child
                if (curr.left == null)
                    return curr.right;
                if (curr.left == null)
                    return curr.right;
                //Case 3 two children (replace with in order sucessor) 
                //find next in order node
                BSTNode nextInOrder = curr.right;
                while (nextInOrder.left != null)
                    nextInOrder = nextInOrder.left;
                curr.weapon = nextInOrder.weapon;
                curr.right = deleteNodeHelper(curr.right, curr.weapon.Peek().weaponName);
            }
            return curr;
        }
    }
}

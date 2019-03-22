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

            if (curr.weapon.Peek().weaponName == wName)
            {
                //Case 1 delete a leaf node
                if (curr.left == null && curr.right == null)
                    return null;
                //Case 2 delete a node that has a single child
                if (curr.left == null)
                    return curr.right;
                if (curr.left == null)
                    return curr.right;
                //Case 3 two children (replace with in order sucessor) 
                //find next in order node
                BSTNode nextInOrder = curr.right;
                BSTNode prev = null;
                while (nextInOrder.left != null)
                {
                    prev = nextInOrder;
                    nextInOrder = nextInOrder.left;
                }
                if (prev != null)prev.left = nextInOrder.right;
                nextInOrder.right = curr.right;
                nextInOrder.left = curr.left;
                return nextInOrder;
            }
            if (curr.weapon.Peek().weaponName.CompareTo( wName) < 0)
                curr.left = deleteNodeHelper(curr.left, wName);
            else if (curr.weapon.Peek().weaponName.CompareTo(wName) > 0)
                curr.right = deleteNodeHelper(curr.right, wName);
            return curr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssignmentGUI
{
    public class Shop
    {
        BSTNode root;

        public Shop()
        {

        }

        public void AddToStore(string name, int rang, int dam, double wieght, double cost, int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Please enter a value greater than zero");
            }
                root = InsertHelper(root, name, rang, dam, wieght, cost, amount);
        }

        private BSTNode InsertHelper(BSTNode curr, string name, int rang, int dam, double wieght, double cost, int amount)
        {
            Weapon newWeapon = new Weapon(name, rang, dam, wieght, cost);
            if (curr == null) {
                BSTNode newNode = new BSTNode();
                newNode.UpdateNode(name, rang, dam, wieght, cost, amount);
                return newNode;
            }
            if (curr.weapon.Peek().weaponName == name)
            {
                curr.UpdateNode(name, rang, dam, wieght, cost, amount);
                return curr;
            }
            if (newWeapon.weaponName.CompareTo(curr.weapon.Peek().weaponName) < 0)
            {
                curr.left = InsertHelper(curr.left, name, rang, dam, wieght, cost, amount);

            }
            if (newWeapon.weaponName.CompareTo(curr.weapon.Peek().weaponName) > 0)
            {
                curr.right = InsertHelper(curr.right, name, rang, dam, wieght, cost, amount);

            }
            return curr;
        }

        public Weapon Search(string wName)
        {
            BSTNode node = getNode(wName);
            if (node != null)
            {
                return node.weapon.Peek();
            }
            else
            {
                return null;
            }
        }

        public string PrintInOrder()
        {
            return PrintInOrderHelper(root);
        }

        private string PrintInOrderHelper(BSTNode curr)
        {
            string s = "";

            if (curr == null) return s;
            s += PrintInOrderHelper(curr.left);
            s += $"{curr.weapon.Peek().toString()} \n Inventory: {curr.weapon.Count}\n";
            s +=PrintInOrderHelper(curr.right);

            return s;
        }

        private BSTNode getNode (string wName)
        {
            return getNodeHelper(root, wName);
        }
        private BSTNode getNodeHelper(BSTNode curr, string wName)
        {
            if (curr == null) return null;
            if (curr.weapon.Peek().weaponName == wName) return curr;
            if (curr.weapon.Peek().weaponName.CompareTo(wName) > 0) return getNodeHelper(curr.left, wName);
            return getNodeHelper(curr.right, wName);
        }

        public Stack<Weapon> buyWeapon(string wName, int amount)
        {
            BSTNode node = getNode(wName);
            Stack<Weapon> purchestWeapons = new Stack<Weapon>();
            if (node == null) return null;
            for (int i = 0; i < amount; i++)
            {
                if (node.weapon.Count == 1)
                { // buying last weapon delete node
                    purchestWeapons.Push(node.weapon.Peek());
                    deleteNode(wName);
                }
                purchestWeapons.Push(node.weapon.Pop());
            }

            return purchestWeapons;
        }

        public bool deleteNode(string wName)
        {
            bool weaponfound = false;
            root = deleteNodeHelper(root, wName, ref weaponfound);
            return weaponfound;
        }
        private BSTNode deleteNodeHelper(BSTNode curr, string wName, ref bool weaponfound)
        {
            if (curr == null) return null;
            int comparison = curr.weapon.Peek().weaponName.CompareTo(wName);
            if (comparison > 0)
                curr.left = deleteNodeHelper(curr.left, wName, ref weaponfound);
            if (comparison < 0)
                curr.right = deleteNodeHelper(curr.right, wName, ref weaponfound);
            if (comparison == 0)
            {
                weaponfound = true;
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
                curr.right = deleteNodeHelper(curr.right, curr.weapon.Peek().weaponName, ref weaponfound);
            }
            return curr;
        }
    }
}

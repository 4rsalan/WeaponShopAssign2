﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponShopAssignmentGUI
{   // This class implements a backpack as a linked list
    // The backpack can hold any number of weapons as long as maxWeight is not crossed.
    // If an attempt to add a weapon to backpack is rejected due to weight
    public class Backpack
    {
        public double maxWeight { get; set; }
        public double presentWeight { get; set; }
        private LinkedListNode head;

        public Backpack(double mWeight)
        {
            maxWeight = mWeight;
            presentWeight = 0;
            head = null;
        }

        public void AddToBackpack(Weapon weapon)
        {
            LinkedListNode newWeapon = new LinkedListNode(weapon);
            if (head == null)
            {
                newWeapon.next = head;
                head = newWeapon;
                presentWeight += weapon.weight;
            }
            else
            {
                LinkedListNode curr = head;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = newWeapon;
                presentWeight += weapon.weight;
            }
        }

        public Weapon findWeapon(string weaponName)
        {
            LinkedListNode curr = head;
            while (curr != null)
            {
                if (curr.weapon.weaponName == weaponName)
                    return curr.weapon;
                curr = curr.next;
            }
            return null;
        }

        public void AddToBackpackInOrder(Weapon weapon)
        {
            LinkedListNode newWeapon = new LinkedListNode(weapon);
            if (head == null)
            {
                newWeapon.next = head;
                head = newWeapon;
                presentWeight += weapon.weight;
            }
            else
            {
                LinkedListNode prev = head;
                LinkedListNode curr = head.next;

                while (curr != null && (prev.weapon.weaponName.CompareTo(curr.weapon.weaponName) < 0))
                {
                    prev = prev.next;
                    curr = curr.next;
                }
                prev.next = newWeapon;
                newWeapon.next = curr;
                presentWeight += weapon.weight;
            }
        }

        public string PrintContents()
        {
            if (head != null)
            {
                String s = "";

                LinkedListNode curr = head;
                while (curr != null)
                {
                    s += curr.weapon.toString();
                    curr = curr.next;
                }
                return s;
            }
            else
            {
                return "Backpack is empty";
            }
        }

        public string PrintWeaponNames()
        {
            if (head != null)
            {
                String s = "";

                LinkedListNode curr = head;
                while (curr.next != null)
                {
                    s += curr.weapon.weaponName + "\n";
                    curr = curr.next;
                }
                return s;
            }
            else
            {
                return "Backpack is empty";
            }
        }

    }
}

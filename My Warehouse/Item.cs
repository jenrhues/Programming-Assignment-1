/*
 * Name: Jennifer Huestis
 * Date: 01/23/2020
 * File: Item.cs
 * Description: This is the base class. It is abstract so that the derived classes may override the abstract functions.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace My_Warehouse
{
    abstract class Item
    {
        // Was I supposed to be able to access these in the derived classes?
        private string Name;
        private double Price;
        private int Quantity;

        public virtual void Sell()
        {
            Console.WriteLine("Selling an item...");
        }
        public virtual void Restock()
        {
            Console.WriteLine("Restocking an item...");
        }
        public virtual void Info()
        {
            Console.WriteLine("This is a generic item of My Warehouse.");
            Console.WriteLine("We have " + Quantity + " " + Name + "s.");
            Console.WriteLine(Name + "has a price of $" + Price);
        }
    }
}

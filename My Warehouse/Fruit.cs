/*
 * Name: Jennifer Huestis
 * Date: 01/23/2020
 * File: Fruit.cs
 * Description: This is a derived class for Item. It overrides abstract functions in the abstract Item class.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace My_Warehouse
{
    class Fruit : Item
    {
        private string taste;
        public override void Sell()
        {
            Console.WriteLine("Selling fruit...");
        }
        public override void Restock()
        {
            Console.WriteLine("Restocking fruit...");
        }
        public override void Info()
        {
            Console.WriteLine("This is a fruit from My Warehouse.");
            Console.WriteLine("The fruit tastes " + taste + ".");
        }
    }
}

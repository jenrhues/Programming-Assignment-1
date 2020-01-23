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
    class Toy : Item
    {
        private string color;
        public override void Sell()
        {
            Console.WriteLine("Selling toys...");
        }
        public override void Restock()
        {
            Console.WriteLine("Restocking toys...");
        }
        public override void Info()
        {
            Console.WriteLine("This is a toy from My Warehouse.");
            Console.WriteLine("The toy is " + color + ".");
        }
    }
}

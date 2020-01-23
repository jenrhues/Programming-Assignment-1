/*
 * Name: Jennifer Huestis
 * Date: 01/23/2020
 * File: Book.cs
 * Description: This is a derived class for Item. It overrides abstract functions in the abstract Item class.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace My_Warehouse
{
    class Book : Item
    {
        private int age;
        public override void Sell()
        {
            Console.WriteLine("Selling books...");
        }
        public override void Restock()
        {
            Console.WriteLine("Restocking books...");
        }
        public override void Info()
        {
            Console.WriteLine("This is a book from My Warehouse.");
            Console.WriteLine("The book is " + age + " years old.");
        }
    }
}

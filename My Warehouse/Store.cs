/*
 * Name: Jennifer Huestis
 * Date: 01/23/2020
 * File: Store.cs
 * Description: Declares a List of Items, and has a menu-driven interface that adds items, sells, restocks 
 *  and accesses information on each item, and exits the program.
 * Difficulties: This program is unfinished. I did not know how to use my list of the Item class to perform 
 *  the add, sell, restock, and access information functions. I did not know how to access my base and derived
 *  classes in my Store object. I attempted to create the classes regardless even though I cannot demonstrate
 *  how they work with one another. I hope to get further in my next programming assignment.
 */

using System;
using System.Collections.Generic;

namespace My_Warehouse
{
    class Store
    {
        static void Main(string[] args)
        {
            bool quit = false;
            var MyWarehouse = new List<Item>();     // How do I use this?
            Console.WriteLine("Welcome to my warehouse!");
            Console.WriteLine("The warehouse is full of various items:");
            Console.WriteLine("\tbooks, fruits, and toys\n");
            Console.WriteLine("What would you like to do?\n\tadd, sell, restock, access information, or quit");
            string choice = Console.ReadLine();
            while (!quit)
            {
                Console.WriteLine("You selected: " + choice + "\n");
                if (choice == "add")
                {
                    
                    Console.WriteLine("What would you like to do?\n\tadd, sell, restock, access information, or quit");
                    choice = Console.ReadLine();
                }
                else if (choice == "sell")
                {
                    Console.WriteLine("What would you like to do?\n\tadd, sell, restock, access information, or quit");
                    choice = Console.ReadLine();
                }
                else if (choice == "restock")
                {
                    
                    Console.WriteLine("What would you like to do?\n\tadd, sell, restock, access information, or quit");
                    choice = Console.ReadLine();
                }
                else if (choice == "access information")
                {
                    
                    Console.WriteLine("What would you like to do?\n\tadd, sell, restock, access information, or quit");
                    choice = Console.ReadLine();
                }
                else if(choice == "quit")
                {
                    quit = true;
                    Console.WriteLine("\nExiting my warehouse...");
                }
                else
                {
                    Console.WriteLine("Invalid Selection\n");
                    Console.WriteLine("What would you like to do?\n\tadd, sell, restock, access information, or quit\n");
                    choice = Console.ReadLine();
                }
            }
            
        }
        
        static void Sell()
        {

        }
        static void Add()
        {

        }
        static void Restock()
        {

        }
        static void AccessInformation()
        {

        }
    }
}
using System.Collections.Generic;
using System;
using System.Text;

namespace GildedRose.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var inventory = new Inventory();

            inventory.PrintItems();
            inventory.UpdateItems();
            inventory.PrintItems();

            System.Console.ReadKey();
        }
    }
}

using System;
using GildedRose.Console;

namespace GildedRose.ConsoleApp
{
    public abstract class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public string GetItem() {
            return !string.IsNullOrEmpty(Name) ? $"{Name} {SellIn} {Quality}" : "No item";
        }

        public abstract void Update();
    }
}

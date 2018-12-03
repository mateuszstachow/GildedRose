using System;
using GildedRose.ConsoleApp;

namespace GildedRose.Console.Items
{
    public class AgedBrie : Item
    {
        public AgedBrie()
        {
        }

        public override void Update()
        {

            SellIn = SellIn - 1;
            Quality = Quality + 1;
        }
    }
}

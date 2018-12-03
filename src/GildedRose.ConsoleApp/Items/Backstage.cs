using System;
using GildedRose.ConsoleApp;

namespace GildedRose.Console.Items
{
    public class Backstage : Item
    {
        public Backstage()
        {
        }

        public override void Update()
        {
            SellIn = SellIn - 1;

            if (SellIn <= 0)
            {
                Quality = 0;
            }
            else if (SellIn <= 5)
            {
                Quality = Quality + 3;
            }
            else if (SellIn <= 10)
            {
                Quality = Quality + 2;
            }
            else
            {
                Quality = Quality + 1;
            }
        }
    }
}

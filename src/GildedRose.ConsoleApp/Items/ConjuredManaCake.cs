using System;
using GildedRose.ConsoleApp;

namespace GildedRose.Console.Items
{
    public class ConjuredManaCake : Item
    {
        public ConjuredManaCake()
        {
        }

        public override void Update()
        {
            SellIn = SellIn - 1;

            if (SellIn <= 0)
            {
                Quality =  Quality * 2;
            }
        }
    }
}

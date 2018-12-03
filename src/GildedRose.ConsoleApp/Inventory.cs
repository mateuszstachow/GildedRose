using System;
using System.Collections.Generic;
using GildedRose.Console.Items;

namespace GildedRose.ConsoleApp
{
    public class Inventory
    {
        public readonly IList<Item> Items;

        public Inventory()
        {
            Items = new List<Item>
            {
              new DexterityVest {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
              new AgedBrie {Name = "Aged Brie", SellIn = 2, Quality = 0},
              new ElixirOfTheMongoose {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
              new Sulfuras {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
              new Backstage
                  {
                      Name = "Backstage passes to a TAFKAL80ETC concert",
                      SellIn = 15,
                      Quality = 20
                  },
              new ConjuredManaCake {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        }

        public void PrintItems() {

            foreach (var item in Items)
            {
                System.Console.WriteLine($"{item.Name} {item.SellIn} {item.Quality}");
            }

        }

        public void UpdateItems() 
        {
            foreach(Item item in Items)
            {
                item.Update();
            }
        }

        //public void UpdateQuality()
        //{
        //    for (var i = 0; i < Items.Count; i++)
        //    {
        //        if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //        {
        //            if (Items[i].Quality > 0)
        //            {
        //                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                {
        //                    Items[i].Quality = Items[i].Quality - 1;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (Items[i].Quality < 50)
        //            {
        //                Items[i].Quality = Items[i].Quality + 1;

        //                if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
        //                {
        //                    if (Items[i].SellIn < 11)
        //                    {
        //                        if (Items[i].Quality < 50)
        //                        {
        //                            Items[i].Quality = Items[i].Quality + 1;
        //                        }
        //                    }

        //                    if (Items[i].SellIn < 6)
        //                    {
        //                        if (Items[i].Quality < 50)
        //                        {
        //                            Items[i].Quality = Items[i].Quality + 1;
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //        {
        //            Items[i].SellIn = Items[i].SellIn - 1;
        //        }

        //        if (Items[i].SellIn < 0)
        //        {
        //            if (Items[i].Name != "Aged Brie")
        //            {
        //                if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //                {
        //                    if (Items[i].Quality > 0)
        //                    {
        //                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                        {
        //                            Items[i].Quality = Items[i].Quality - 1;
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    Items[i].Quality = Items[i].Quality - Items[i].Quality;
        //                }
        //            }
        //            else
        //            {
        //                if (Items[i].Quality < 50)
        //                {
        //                    Items[i].Quality = Items[i].Quality + 1;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
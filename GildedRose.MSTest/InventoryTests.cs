using GildedRose.Console.Items;
using GildedRose.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.MSTest
{
    [TestClass]
    public class InventoryTests
    {
        [TestMethod]
        public void CheckItemsCountTest()
        {
            var inventory = new Inventory();
            Assert.AreEqual(6, inventory.Items.Count);
        }

        [TestMethod]
        public void AgedUpdatePassTest() 
        {
            AgedBrie item = new AgedBrie()
            {
                Name = "Aged Brie",
                SellIn = 2,
                Quality = 0
            };

            item.Update();

            Assert.AreEqual("Aged Brie 1 1", item.GetItem());
        }

        [TestMethod]
        public void ElixirUpdatePassTest()
        {
            ElixirOfTheMongoose item = new ElixirOfTheMongoose()
            {
                Name = "Elixir of the Mongoose",
                SellIn = 5,
                Quality = 7
            };

            item.Update();

            Assert.AreEqual("Elixir of the Mongoose 4 6", item.GetItem());
        }

        [TestMethod]
        public void BackstageUpdatePassTest()
        {
            Backstage item = new Backstage()
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 2,
                Quality = 0
            };

            item.Update();

            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert 14 21", item.GetItem());
        }

        [TestMethod]
        public void ConjuredManaCakePassTest()
        {
            ConjuredManaCake item = new ConjuredManaCake()
            {
                Name = "Conjured Mana Cake",
                SellIn = 3,
                Quality = 6
            };

            item.Update();

            Assert.AreEqual("Conjured Mana Cake 2 5", item.GetItem());
        }

        [TestMethod]
        public void DexterityVestUpdatePassTest()
        {
            DexterityVest item = new DexterityVest()
            {
                Name = "+5 Dexterity Vest",
                SellIn = 10,
                Quality = 20
            };

            item.Update();

            Assert.AreEqual("+5 Dexterity Vest 1 1", item.GetItem());
        }

        [TestMethod]
        public void SulfurasUpdatePassTest()
        {
            Sulfuras item = new Sulfuras()
            {
                Name = "Sulfuras, Hand of Ragnaros",
                SellIn = 0,
                Quality = 80
            };

            item.Update();

            Assert.AreEqual("Sulfuras, Hand of Ragnaros 0 80", item.GetItem());
        }
    }
}

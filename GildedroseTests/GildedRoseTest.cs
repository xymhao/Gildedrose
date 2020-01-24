using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using GildedRose;

namespace GildedroseTests
{
    [TestClass]
    public class GildedRoseTest
    {
        //todo 一旦过了保质期，"Quality"就以双倍的速度下滑。
        //todo 陈年干酪（Aged Brie）是一种特殊的商品，放得越久，价值反而越高。
        //todo 商品的价值永远不会小于 0，也永远不会超过 50。
        //todo 萨弗拉斯（Sulfuras）是一种传奇商品，没有保质期的概念，质量也不会下滑。
        //todo 后台门票（Backstage pass）和陈年干酪有相似之处：越是接近演出日，随着"SellIn"值的增加，商品价值"Quality"值反而上升。在演出前 10 天，价值每天上升 2 点；演出前 5 天，价值每天上升 3 点。但一旦过了演出日，价值就马上变成 0。
        [TestMethod]
        public void foo()
        {
            Goods[] items = new Goods[] { new Goods("foo", 1, 5) };
            var app = new GildedRose.GildedRose(items);
            app.update_quality();
            Assert.AreEqual("foo", app.items[0].Name);
            Assert.AreEqual(app.items[0].Quality, (4));
            Assert.AreEqual(app.items[0].SellIn, (0));
        }

        [TestMethod]
        public void Establish_SafeNet()
        {
            Goods[] items = new Goods[] {
                new Goods("+5 Dexterity Vest", 10, 20), //
                new AgeBrie(2, 0), //
                new Goods("Elixir of the Mongoose", 5, 7), //
                new Goods("Elixir of the Mongoose", 1, 7), //
                new Sulfuras(0, 80), //
                new Sulfuras(-1, 80),
                new Tickets(15, 20), 
                new Tickets(10, 49),
                new Tickets(5, 49),
                new Tickets(1, 20),
                // this conjured item does not work properly yet
                new Goods("Conjured Mana Cake", 3, 6) };

            GildedRose.GildedRose app = new GildedRose.GildedRose(items);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                app.update_quality();
                foreach (Goods item in items)
                {
                    builder.Append(item.ToString());
                }
            }

            var result =
                "+5 Dexterity Vest, 9, 19Aged Brie, 1, 1Elixir of the Mongoose, 4, 6Elixir of the Mongoose, 0, 6Sulfuras, Hand of Ragnaros, 0, 80Sulfuras, Hand of Ragnaros, -1, 80Backstage passes to a TAFKAL80ETC concert, 14, 21Backstage passes to a TAFKAL80ETC concert, 9, 50Backstage passes to a TAFKAL80ETC concert, 4, 50Backstage passes to a TAFKAL80ETC concert, 0, 23Conjured Mana Cake, 2, 5+5 Dexterity Vest, 8, 18Aged Brie, 0, 2Elixir of the Mongoose, 3, 5Elixir of the Mongoose, -1, 4Sulfuras, Hand of Ragnaros, 0, 80Sulfuras, Hand of Ragnaros, -1, 80Backstage passes to a TAFKAL80ETC concert, 13, 22Backstage passes to a TAFKAL80ETC concert, 8, 50Backstage passes to a TAFKAL80ETC concert, 3, 50Backstage passes to a TAFKAL80ETC concert, -1, 0Conjured Mana Cake, 1, 4+5 Dexterity Vest, 7, 17Aged Brie, -1, 4Elixir of the Mongoose, 2, 4Elixir of the Mongoose, -2, 2Sulfuras, Hand of Ragnaros, 0, 80Sulfuras, Hand of Ragnaros, -1, 80Backstage passes to a TAFKAL80ETC concert, 12, 23Backstage passes to a TAFKAL80ETC concert, 7, 50Backstage passes to a TAFKAL80ETC concert, 2, 50Backstage passes to a TAFKAL80ETC concert, -2, 0Conjured Mana Cake, 0, 3";

            Assert.AreEqual(result, builder.ToString());
        }
    }
}

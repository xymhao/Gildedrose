using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Gildedrose;

namespace GildedroseTests
{
    [TestClass]
    public class GildedRoseTest
    {

        [TestMethod]
        public void foo()
        {
            Item[] items = new Item[] { new Item("foo", 1, 5) };
            GildedRose app = new GildedRose(items);
            app.update_quality();
            Assert.AreEqual("foo", app.items[0].name);
            Assert.AreEqual(app.items[0].quality, (4));
            Assert.AreEqual(app.items[0].sell_in, (0));
        }

    }
}

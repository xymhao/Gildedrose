using System;
using System.Collections.Generic;
using System.Text;
using Gildedrose;

namespace GildedroseTests
{
    public class TexttestFixture
    {
        public static void main(String[] args)
        {
            Console.WriteLine("OMGHAI!");

            Item[] items = new Item[] {
                new Item("+5 Dexterity Vest", 10, 20), //
                new Item("Aged Brie", 2, 0), //
                new Item("Elixir of the Mongoose", 5, 7), //
                new Item("Sulfuras, Hand of Ragnaros", 0, 80), //
                new Item("Sulfuras, Hand of Ragnaros", -1, 80),
                new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new Item("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                new Item("Backstage passes to a TAFKAL80ETC concert", 5, 49),
                new Item("Backstage passes to a TAFKAL80ETC concert", 1, 20),
                // this conjured item does not work properly yet
                new Item("Conjured Mana Cake", 3, 6) };

            GildedRose app = new GildedRose(items);

            int days = 3;
            if (args.Length > 0)
            {
                days = int.Parse(args[0]) + 1;
            }

            for (int i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (Item item in items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                app.update_quality();
            }
        }

    }
}

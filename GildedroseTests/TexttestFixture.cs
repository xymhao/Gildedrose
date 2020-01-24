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

            Goods[] items = new Goods[] {
                new Goods("+5 Dexterity Vest", 10, 20), //
                new Goods("Aged Brie", 2, 0), //
                new Goods("Elixir of the Mongoose", 5, 7), //
                new Goods("Sulfuras, Hand of Ragnaros", 0, 80), //
                new Goods("Sulfuras, Hand of Ragnaros", -1, 80),
                new Goods("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new Goods("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                new Goods("Backstage passes to a TAFKAL80ETC concert", 5, 49),
                new Goods("Backstage passes to a TAFKAL80ETC concert", 1, 20),
                // this conjured item does not work properly yet
                new Goods("Conjured Mana Cake", 3, 6) };

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
                foreach (Goods item in items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                app.update_quality();
            }
        }

    }
}

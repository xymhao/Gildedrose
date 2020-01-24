using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    public class Sulfuras : Goods
    {
        public Sulfuras(int sellIn, int quality) : base("Sulfuras, Hand of Ragnaros", sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
        }
    }
}

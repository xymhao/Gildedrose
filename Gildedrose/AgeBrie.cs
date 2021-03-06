﻿namespace GildedRose
{
    public class AgeBrie : Goods
    {
        public AgeBrie(int sellIn, int quality) : base("Aged Brie", sellIn, quality)
        {

        }

        public override void UpdateQuality()
        {
            SellIn -= 1;

            if (SellIn >= 0)
            {
                Quality += 1;
            }
            else
            {
                Quality += 2;
            }

            if (Quality >= MaxQualityValue)
            {
                Quality = MaxQualityValue;
            }
        }
    }
}

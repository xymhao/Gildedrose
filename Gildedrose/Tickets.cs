namespace GildedRose
{
    public class Tickets : Goods
    {
        private const int TenDaysAgo = 11;
        private const int FiveDayAgo = 6;

        public Tickets(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            if (Quality < MaxQualityValue)
            {
                Quality += 1;

                if (SellIn < TenDaysAgo)
                {
                    if (Quality < MaxQualityValue)
                    {
                        Quality += 1;
                    }
                }

                if (SellIn < FiveDayAgo)
                {
                    if (Quality < MaxQualityValue)
                    {
                        Quality += 1;
                    }
                }
            }

            SellIn -= 1;

            if (SellIn < 0)
            {
                Quality -= Quality;
            }
        }
    }
}

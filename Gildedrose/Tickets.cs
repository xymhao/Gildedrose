namespace GildedRose
{
    public class Tickets : Goods
    {
        private const int TenDaysAgo = 11;
        private const int FiveDayAgo = 6;

        public Tickets(int sellIn, int quality) : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            if (Quality < MaxQualityValue)
            {
                Quality += 1;
                AddQuality(TenDaysAgo);
                AddQuality(FiveDayAgo);
            }

            SellIn -= 1;

            if (SellIn < 0)
            {
                Quality -= Quality;
            }
        }

        private void AddQuality(int days)
        {
            if (SellIn < days)
            {
                if (Quality < MaxQualityValue)
                {
                    Quality += 1;
                }
            }
        }
    }
}

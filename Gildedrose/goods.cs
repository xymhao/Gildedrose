namespace GildedRose
{
    public class Goods
    {
        protected const int MaxQualityValue = 50;

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public Goods(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;

        }

        public override string ToString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }

        public virtual void UpdateQuality()
        {
            SellIn -= 1;

            ReduceQuality(SellIn < 0 ? 2 : 1);
        }

        protected void ReduceQuality(int quality)
        {
            if (Quality > 0)
            {
                Quality -= quality;
            }
        }
    }
}
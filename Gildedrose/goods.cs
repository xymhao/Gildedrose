using System;

namespace GildedRose
{
    public class Goods
    {
        protected const string AgedBrie = "Aged Brie";
        protected const string BackstagePassesToATafkal80EtcConcert = "Backstage passes to a TAFKAL80ETC concert";
        protected const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";

        protected const int MaxQualityValue = 50;

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public Goods(string name, int sell_in, int quality)
        {
            this.Name = name;
            this.SellIn = sell_in;
            this.Quality = quality;

        }

        public string ToString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }

        public virtual void UpdateQuality()
        {
            var goods = this;
            if (goods.Name.Equals(SulfurasHandOfRagnaros))
            {
                return;
            }

            if (goods.Name.Equals(AgedBrie))
            {
                var ageBrie = new AgeBrie(Name, SellIn, Quality);
                ageBrie.UpdateQuality();
                Name = ageBrie.Name;
                SellIn = ageBrie.SellIn;
                Quality = ageBrie.Quality;
                return;
            }

            if (Name.Equals(BackstagePassesToATafkal80EtcConcert))
            {
                var ageBrie = new Tickets(Name, SellIn, Quality);
                ageBrie.UpdateQuality();
                Name = ageBrie.Name;
                SellIn = ageBrie.SellIn;
                Quality = ageBrie.Quality;
                return;
            }

            var hasQuality = goods.Quality > 0;
            var isAgeBrie = goods.Name.Equals(AgedBrie);
            var isConcert = goods.Name.Equals(BackstagePassesToATafkal80EtcConcert);

            {
                if (hasQuality)
                {
                    goods.Quality -= 1;
                }
            }

            goods.SellIn -= 1;

            if (goods.SellIn < 0)
            {
                {
                    if (isConcert)
                    {
                        goods.Quality -= goods.Quality;
                    }
                    else
                    {
                        if (hasQuality)
                        {
                            goods.Quality -= 1;
                        }
                    }
                }
            }

        }
    }
}
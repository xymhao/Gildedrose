using System;

namespace Gildedrose
{
    public class Goods
    {
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePassesToATafkal80EtcConcert = "Backstage passes to a TAFKAL80ETC concert";
        private const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";

        public string name;

        public int sell_in;

        public int quality;

        public Goods(string name, int sell_in, int quality)
        {
            this.name = name;
            this.sell_in = sell_in;
            this.quality = quality;
        }

        public string toString()
        {
            return this.name + ", " + this.sell_in + ", " + this.quality;
        }

        public void UpdateQuality()
        {
            var goods = this;
            if (goods.name.Equals(AgedBrie) ||
                goods.name.Equals(BackstagePassesToATafkal80EtcConcert))
            {
                if (goods.quality < 50)
                {
                    goods.quality = goods.quality + 1;

                    if (goods.name.Equals(BackstagePassesToATafkal80EtcConcert))
                    {
                        if (goods.sell_in < 11)
                        {
                            if (goods.quality < 50)
                            {
                                goods.quality = goods.quality + 1;
                            }
                        }

                        if (goods.sell_in < 6)
                        {
                            if (goods.quality < 50)
                            {
                                goods.quality = goods.quality + 1;
                            }
                        }
                    }
                }
            }
            else
            {
                if (goods.quality > 0)
                {
                    if (!goods.name.Equals(SulfurasHandOfRagnaros))
                    {
                        goods.quality = goods.quality - 1;
                    }
                }
            }

            if (!goods.name.Equals(SulfurasHandOfRagnaros))
            {
                goods.sell_in = goods.sell_in - 1;
            }

            if (goods.sell_in < 0)
            {
                if (goods.name.Equals(AgedBrie))
                {
                    if (goods.quality < 50)
                    {
                        goods.quality = goods.quality + 1;
                    }
                }
                else
                {
                    if (goods.name.Equals(BackstagePassesToATafkal80EtcConcert))
                    {
                        goods.quality = goods.quality - goods.quality;
                    }
                    else
                    {
                        if (goods.quality > 0)
                        {
                            if (!goods.name.Equals(SulfurasHandOfRagnaros))
                            {
                                goods.quality = goods.quality - 1;
                            }
                        }
                    }
                }
            }

        }
    }
}
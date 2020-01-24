namespace Gildedrose
{
    public class GildedRose
    {
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePassesToATafkal80EtcConcert = "Backstage passes to a TAFKAL80ETC concert";
        private const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";
        public Goods[] items;

        public GildedRose(Goods[] items)
        {
            this.items = items;
        }

        public void update_quality()
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].name.Equals(AgedBrie) ||
                    items[i].name.Equals(BackstagePassesToATafkal80EtcConcert))
                {
                    if (items[i].quality < 50)
                    {
                        items[i].quality = items[i].quality + 1;

                        if (items[i].name.Equals(BackstagePassesToATafkal80EtcConcert))
                        {
                            if (items[i].sell_in < 11)
                            {
                                if (items[i].quality < 50)
                                {
                                    items[i].quality = items[i].quality + 1;
                                }
                            }

                            if (items[i].sell_in < 6)
                            {
                                if (items[i].quality < 50)
                                {
                                    items[i].quality = items[i].quality + 1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (items[i].quality > 0)
                    {
                        if (!items[i].name.Equals(SulfurasHandOfRagnaros))
                        {
                            items[i].quality = items[i].quality - 1;
                        }
                    }
                }

                if (!items[i].name.Equals(SulfurasHandOfRagnaros))
                {
                    items[i].sell_in = items[i].sell_in - 1;
                }

                if (items[i].sell_in < 0)
                {
                    if (items[i].name.Equals(AgedBrie))
                    {
                        if (items[i].quality < 50)
                        {
                            items[i].quality = items[i].quality + 1;
                        }
                    }
                    else
                    {
                        if (items[i].name.Equals(BackstagePassesToATafkal80EtcConcert))
                        {
                            items[i].quality = items[i].quality - items[i].quality;
                        }
                        else
                        {
                            if (items[i].quality > 0)
                            {
                                if (!items[i].name.Equals(SulfurasHandOfRagnaros))
                                {
                                    items[i].quality = items[i].quality - 1;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

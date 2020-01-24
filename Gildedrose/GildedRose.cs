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
                var goods = items[i];
                goods.UpdateQuality();
            }
        }
    }
}

namespace GildedRose
{
    public class GildedRose
    {
        public Goods[] items;

        public GildedRose(Goods[] items)
        {
            this.items = items;
        }

        public void update_quality()
        {
            foreach (var goods in items)
            {
                goods.UpdateQuality();
            }
        }
    }
}

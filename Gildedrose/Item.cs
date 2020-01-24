using System;

namespace Gildedrose
{
    public class Item
    {

        public string name;

        public int sell_in;

        public int quality;

        public Item(string name, int sell_in, int quality)
        {
            this.name = name;
            this.sell_in = sell_in;
            this.quality = quality;
        }

        public string toString()
        {
            return this.name + ", " + this.sell_in + ", " + this.quality;
        }
    }
}
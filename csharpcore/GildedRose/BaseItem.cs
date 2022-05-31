using GildedRoseKata;

namespace GildedRoseKata
{
    public class BaseItem : Item
    {
        public BaseItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
        }

        public virtual void UpdateQuality()
        {
            if (Quality > 0)
            {
                if (SellIn <= 0)
                {
                    Quality -= 2;
                }
                else
                {
                    Quality--;
                }
            }

            SellIn--;
        }
    }
}

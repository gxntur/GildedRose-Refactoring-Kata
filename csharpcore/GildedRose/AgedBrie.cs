namespace GildedRoseKata
{
    public class AgedBrie : BaseItem
    {
        public AgedBrie(int sellIn, int quality) : base(sellIn, quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Aged Brie";
        }

        public override void UpdateQuality()
        {
            if (SellIn <= 0)
            {
                Quality += 2;
            }
            else
            {
                Quality++;
            }

            SellIn--;

            if (Quality > 50)
            {
                Quality = 50;
            }
        }
    }
}

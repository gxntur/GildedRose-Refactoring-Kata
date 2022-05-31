namespace GildedRoseKata
{
    public class Backstage : BaseItem
    {
        public Backstage(int sellIn, int quality) : base(sellIn, quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Backstage passes to a TAFKAL80ETC concert";
        }

        public override void UpdateQuality()
        {
            switch (SellIn)
            {
                case <= 0:
                    Quality = 0;
                    break;
                case <= 5:
                    Quality += 3;
                    break;
                case <= 10:
                    Quality += 2;
                    break;
                default:
                    Quality++;
                    break;
            }

            SellIn--;

            if (Quality > 50)
            {
                Quality = 50;
            }
        }
    }
}

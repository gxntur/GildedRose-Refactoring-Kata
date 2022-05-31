namespace GildedRoseKata
{
    public class Sulfuras : BaseItem
    {
        public Sulfuras(int sellIn, int quality) : base(sellIn, quality)
        {
            SellIn = sellIn;
            Quality = quality;
            Name = "Sulfuras, Hand of Ragnaros";
        }

        public override void UpdateQuality()
        {
            return;
        }
    }
}

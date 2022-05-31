using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class AgedBrieTests
    {
        private GildedRose AgedBrieSetup(int sellIn, int quality)
        {
            var Items = new List<BaseItem> { new AgedBrie(sellIn, quality) };
            return new GildedRose(Items);
        }

        [Fact]
        public void Aged_Brie_Quality_Decreases()
        {
            GildedRose app = AgedBrieSetup(2, 0);

            app.UpdateQuality();

            Assert.Equal(1, app.BaseItems[0].SellIn);
            Assert.Equal(1, app.BaseItems[0].Quality);
        }

        [Fact]
        public void Aged_Brie_Quality_Decreases_Past_SellIn()
        {
            GildedRose app = AgedBrieSetup(0, 20);

            app.UpdateQuality();

            Assert.Equal(-1, app.BaseItems[0].SellIn);
            Assert.Equal(22, app.BaseItems[0].Quality);
        }

        [Fact]
        public void Aged_Brie_Quality_Never_Above_50()
        {
            GildedRose app = AgedBrieSetup(0, 49);

            app.UpdateQuality();

            Assert.Equal(-1, app.BaseItems[0].SellIn);
            Assert.Equal(50, app.BaseItems[0].Quality);
        }
    }
}

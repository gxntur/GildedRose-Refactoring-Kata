using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class BackstageTests
    {
        private GildedRose BackstageSetup(int sellIn, int quality)
        {
            var Items = new List<BaseItem> { new Backstage(sellIn, quality) };
            return new GildedRose(Items);
        }

        [Fact]
        public void Backstage_Quality_Less_Than_5_Days()
        {
            GildedRose app = BackstageSetup(2, 0);

            app.UpdateQuality();

            Assert.Equal(1, app.BaseItems[0].SellIn);
            Assert.Equal(3, app.BaseItems[0].Quality);
        }

        [Fact]
        public void Backstage_Quality_Less_Than_10_Days()
        {
            GildedRose app = BackstageSetup(9, 21);

            app.UpdateQuality();

            Assert.Equal(8, app.BaseItems[0].SellIn);
            Assert.Equal(23, app.BaseItems[0].Quality);
        }

        [Fact]
        public void Backstage_Quality_Never_Above_50()
        {
            GildedRose app = BackstageSetup(2, 48);

            app.UpdateQuality();

            Assert.Equal(1, app.BaseItems[0].SellIn);
            Assert.Equal(50, app.BaseItems[0].Quality);
        }

        [Fact]
        public void Backstage_Quality_Drops_To_Zero_Past_SellIn()
        {
            GildedRose app = BackstageSetup(0, 48);

            app.UpdateQuality();

            Assert.Equal(-1, app.BaseItems[0].SellIn);
            Assert.Equal(0, app.BaseItems[0].Quality);
        }
    }
}

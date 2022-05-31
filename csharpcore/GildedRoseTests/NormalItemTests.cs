using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class NormalItemTests
    {
        private GildedRose NormalItemSetup(int sellIn, int quality)
        {
            var Items = new List<BaseItem> { new BaseItem(sellIn, quality) };
            return new GildedRose(Items);
        }

        [Fact]
        public void Normal_Item_Quality_Decreases()
        {
            GildedRose app = NormalItemSetup(10, 20);

            app.UpdateQuality();

            Assert.Equal(9, app.BaseItems[0].SellIn);
            Assert.Equal(19, app.BaseItems[0].Quality);
        }

        [Fact]
        public void Normal_Item_Quality_Decreases_Past_SellIn()
        {
            GildedRose app = NormalItemSetup(0, 20);

            app.UpdateQuality();

            Assert.Equal(-1, app.BaseItems[0].SellIn);
            Assert.Equal(18, app.BaseItems[0].Quality);
        }

        [Fact]
        public void Normal_Item_Quality_Is_Never_Negative()
        {
            GildedRose app = NormalItemSetup(5, 0);

            app.UpdateQuality();

            Assert.Equal(4, app.BaseItems[0].SellIn);
            Assert.Equal(0, app.BaseItems[0].Quality);
        }

        [Fact]
        public void Normal_Item_Quality_Decreases_On_SellIn_Date()
        {
            GildedRose app = NormalItemSetup(0, 10);

            app.UpdateQuality();

            Assert.Equal(-1, app.BaseItems[0].SellIn);
            Assert.Equal(8, app.BaseItems[0].Quality);
        }
    }
}

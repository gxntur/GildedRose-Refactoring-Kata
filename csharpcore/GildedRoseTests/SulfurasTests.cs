using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class SulfurasTests
    {
        private GildedRose SulfurasSetup(int sellIn, int quality)
        {
            var Items = new List<BaseItem> { new Sulfuras(sellIn, quality) };
            return new GildedRose(Items);
        }

        [Fact]
        public void Sulfuras_Nothing_Happens()
        {
            GildedRose app = SulfurasSetup(10, 20);
            app.UpdateQuality();

            Assert.Equal(10, app.BaseItems[0].SellIn);
            Assert.Equal(20, app.BaseItems[0].Quality);
        }
    }
}

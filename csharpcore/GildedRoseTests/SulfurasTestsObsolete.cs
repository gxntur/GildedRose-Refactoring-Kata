using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class SulfurasTestsObsolete
    {
        [Fact]
        public void Sulfuras_Nothing_Happens()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(10, Items[0].SellIn);
            Assert.Equal(20, Items[0].Quality);
        }
    }
}

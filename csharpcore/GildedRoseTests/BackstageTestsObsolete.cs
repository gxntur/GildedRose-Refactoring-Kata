using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class BackstageTestsObsolete
    {
        [Fact]
        public void Backstage_Quality_Less_Than_5_Days()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(1, Items[0].SellIn);
            Assert.Equal(3, Items[0].Quality);
        }

        [Fact]
        public void Backstage_Quality_Less_Than_10_Days()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 21 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(8, Items[0].SellIn);
            Assert.Equal(23, Items[0].Quality);
        }

        [Fact]
        public void Backstage_Quality_Never_Above_50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 48 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(1, Items[0].SellIn);
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void Backstage_Quality_Drops_To_Zero_Past_SellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 48 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }
    }
}

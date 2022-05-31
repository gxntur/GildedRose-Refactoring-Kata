using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class AgedBrieTestsObsolete
    {
        [Fact]
        public void Aged_Brie_Quality_Decreases()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(1, Items[0].SellIn);
            Assert.Equal(1, Items[0].Quality);
        }

        [Fact]
        public void Aged_Brie_Quality_Decreases_Past_SellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(22, Items[0].Quality);
        }

        [Fact]
        public void Aged_Brie_Quality_Never_Above_50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(50, Items[0].Quality);
        }
    }
}

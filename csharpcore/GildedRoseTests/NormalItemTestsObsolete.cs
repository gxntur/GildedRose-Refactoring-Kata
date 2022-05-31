using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class NormalItemTestsObsolete
    {
        [Fact]
        public void Normal_Item_Quality_Decreases()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(19, Items[0].Quality);
        }

        [Fact]
        public void Normal_Item_Quality_Decreases_Past_SellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(18, Items[0].Quality);
        }

        [Fact]
        public void Normal_Item_Quality_Is_Never_Negative()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 5, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(4, Items[0].SellIn);
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void Normal_Item_Quality_Decreases_On_SellIn_Date()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQualityObsolete();

            Assert.Equal(-1, Items[0].SellIn);
            Assert.Equal(8, Items[0].Quality);
        }
    }
}

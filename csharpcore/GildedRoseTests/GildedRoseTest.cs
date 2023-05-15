using Xunit;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        private GildedRose NewApp(params Item[] items)
        {
            return new GildedRose(items);
        }

        private void TestAppItem(GildedRose app, Item item, params int[] expectedQualities)
        {
            foreach (var quality in expectedQualities)
            {
                app.UpdateQuality();
                Assert.Equal(item.Quality, quality);
            }
        }

        [Fact]
        public void Foo()
        {
            var item = new Item { Name = "foo" };
            var app = NewApp(item);
            app.UpdateQuality();
            Assert.Equal("foo", item.Name);
        }

        [Fact]
        public void Generic_Quality()
        {
            var item = new Item
            {
                Quality = 7,
                SellIn = 3
            };
            var app = NewApp(item);
            TestAppItem(app, item, 6, 5, 4, 2, 0, 0);
        }

        [Fact]
        public void AgedBrie_Quality()
        {
            var item = new AgedBrie
            {
                Quality = 48,
                SellIn = 3
            };
            var app = NewApp(item);
            TestAppItem(app, item, 49, 50, 50, 50);
        }

        [Fact]
        public void BackstagePass_Quality()
        {
            var item = new BackstagePass
            {
                Quality = 10,
                SellIn = 12
            };
            var app = NewApp(item);
            TestAppItem(app, item, 11, 12, 14, 16, 18, 20, 22, 25, 28, 31, 34, 37, 0, 0);
        }

        [Fact]
        public void Sulfuras_Quality()
        {
            var item = new Sulfuras();
            var app = NewApp(item);
            TestAppItem(app, item, 80, 80, 80, 80);
            item.Quality = 81;
            app.UpdateQuality();
            Assert.Equal(item.Quality, 80);
            Assert.Equal(item.SellIn, 0);
            item.SellIn = -1;
            app.UpdateQuality();
            Assert.Equal(item.SellIn, 0);
        }
    }
}
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        private void UpdateGeneric(Item item)
        {
            if (item.SellIn > 0)
                item.Quality--;
            else
                item.Quality -= 2;

            item.Quality = System.Math.Max(item.Quality, 0);
            item.SellIn -= 1;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item is SpecificItem)
                    (item as SpecificItem).UpdateQuality();
                else
                    UpdateGeneric(item);
            }
        }
    }
}

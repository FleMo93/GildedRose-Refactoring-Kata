namespace GildedRoseKata
{
    public class Sulfuras : Item, SpecificItem
    {
        public Sulfuras()
        {
            Quality = 80;
        }

        void SpecificItem.UpdateQuality()
        {
            Quality = 80;
            SellIn = 0;
        }
    }
}
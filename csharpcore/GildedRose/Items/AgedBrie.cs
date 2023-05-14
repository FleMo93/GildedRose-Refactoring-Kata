namespace GildedRoseKata
{
    public class AgedBrie : Item, SpecificItem
    {
        void SpecificItem.UpdateQuality()
        {
            Quality++;
            Quality = System.Math.Min(Quality, 50);
            SellIn -= 1;
        }
    }
}
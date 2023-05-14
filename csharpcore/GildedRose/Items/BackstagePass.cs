namespace GildedRoseKata
{
    public class BackstagePass : Item, SpecificItem
    {
        void SpecificItem.UpdateQuality()
        {
            if (SellIn > 10)
                Quality += 1;
            else if (SellIn > 5)
                Quality += 2;
            else if (SellIn > 0)
                Quality += 3;
            else
                Quality = 0;
            SellIn -= 1;
        }
    }
}
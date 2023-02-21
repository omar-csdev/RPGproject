public class CountedItem
{
    public Item TheItem;
    public int Quantity = 1;

    public CountedItem(Item item, int count)
    { 
        this.TheItem = item;
        this.Quantity = count;
    }
}
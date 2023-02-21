public class CountedItem
{
    public Item TheItem;
    public int Quantity = 0;

    public CountedItem(Item item)
    { 
        this.TheItem = item;
        this.Quantity++;
    }
}
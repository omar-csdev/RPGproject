public class CountedItemList
{
    public List<CountedItem> TheCountedItemList;

    public CountedItemList()
    {
        this.TheCountedItemList = new List<CountedItem>();
    }

    public void AddItem(Item item)
    {
        int count = 0;
        foreach (CountedItem i in this.TheCountedItemList) 
        {
            if (i.TheItem.ID == item.ID)
            {
                count++;
            }
        }

        if (count == 0) 
        {
            this.TheCountedItemList.Add(new CountedItem(item));
        }
    }

    public void DisplayItems()
    {
        foreach (CountedItem item in this.TheCountedItemList) 
        {
            Console.WriteLine($"{item.TheItem.Name} x {item.Quantity}");
        }
    }
}
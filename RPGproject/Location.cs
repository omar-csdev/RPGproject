public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Item ItemRequiredToEnter;
    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;
    public Location LocationToNorth = null;
    public Location LocationToSouth = null;
    public Location LocationToWest = null;
    public Location LocationToEast = null;

    public Location(int id, string n, string d, Item item, Quest q, Monster m)
    {
        this.ID = id;
        this.Name = n;
        this.Description = d;
        this.ItemRequiredToEnter = item;
        this.QuestAvailableHere = q;
        this.MonsterLivingHere = m;
    }
}
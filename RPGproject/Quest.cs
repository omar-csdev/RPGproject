public class Quest
{
    public int ID;
    public string Name;
    public string Description;
    public int RewardExperiencePoints;
    public int RewardGold;
    public Item RewardItem;
    public Weapon RewardWeapon;
    public CountedItemList QuestCompletionItems;

    public Quest(int id, string n, string desc, int rexp, int rg, Item ri, Weapon rw)
    {
        this.ID = id; 
        this.Name = n;
        this.Description = desc;
        this.RewardExperiencePoints = rexp;
        this.RewardGold = rg;
        this.RewardItem = ri;
        this.RewardWeapon = rw;
        this.QuestCompletionItems = new CountedItemList();
    }


}
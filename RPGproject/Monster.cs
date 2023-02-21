public class Monster
{
    public int ID;
    public string Name;
    public string NamePlural;
    public int MaximumDamage = 0;
    public int RewardExperience = 0;
    public int RewardGold = 0;
    public CountedItemList Loot;
    public int CurrentHitPoints = 0;
    public int MaximumHitPoints = 0;

    public Monster(int id, string n, string np, int md, int re, int rg, int c, int mhp)
    {
        this.ID = id;
        this.Name = n;
        this.NamePlural = np;
        this.MaximumDamage = md;
        this.RewardExperience = re;
        this.RewardGold = rg;
        this.Loot = new CountedItemList();
        this.CurrentHitPoints = c;
        this.MaximumHitPoints = mhp;
    }
}
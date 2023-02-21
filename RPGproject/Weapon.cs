public class Weapon
{
    public int ID;
    public string Name;
    public string NamePlural;
    public int MinimumDamage;
    public int MaximumDamage;

    public Weapon(int i, string n, string np, int min, int max)
    {
        this.ID = i; 
        this.Name = n;
        this.NamePlural = np;
        this.MinimumDamage = min;
        this.MaximumDamage = max;
    }
}
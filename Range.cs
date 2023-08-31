class Range : Enemy
{

    public Range(string title) : base(title)
    {
        Title= title;
        Health = 80;
        AttackList = new List<Attack>()
        {
            new("Bow", 20),
            new("Knife", 15),
        };
    }

    public void Heal(Enemy Target)
    {
        Health = Target.Health + 40;
        Console.WriteLine($"{Target.Title} Gained 40 Health, {Target.Title}'s Health is now {Health}");
    }
}
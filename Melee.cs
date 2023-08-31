class Melee : Enemy
{

    public Melee(string title) : base(title)
    {
        Title = title;
        Health = 120;
        AttackList = new List<Attack>()
        {
            new("Punch", 20),
            new("Kick", 15),
            new("Tackle", 25)
        };
    }

    public void Rage(Enemy Target, Attack ChosenAttack)
    {
        Target.Health = Target.Health - ChosenAttack.Damage +10;
        Console.WriteLine($"{Target.Title} took {ChosenAttack.Damage + 10} from Rage");
    }
}
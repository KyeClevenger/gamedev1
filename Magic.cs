class Magic : Enemy
{
    public int Travel;

    public Magic(string title) : base(title)
    {
        Title = title;
        Health = 80;
        AttackList = new List<Attack>()
        {
            new("Knife", 15),
            new("Arrow", 20)
        };
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if( Travel < 20)
        {
            Console.WriteLine("Go farther away");
        } else {
            Console.WriteLine($"{Title} Selected {ChosenAttack.Special} For {ChosenAttack.Damage} Damage On {Target.Title}");
        }
    }

    public void Dash()
    {
        if( Travel < 20)
        {
            Travel = 20;
        }
        Console.WriteLine($"{Title} Chose Their Travel To Be 20");
    }
}
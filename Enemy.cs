class Enemy
{
    public string Title;
    public int Health;
    public List<Attack> AttackList;

    public Enemy(string title)
    {
        Title = title;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void RandomAttack()
    {
        Random weapon = new();
        int random = weapon.Next(0,3);
        Console.WriteLine($"{Title} Selected {AttackList[random].Special}, It Hit You For {AttackList[random].Damage} Health");
    }

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health = Health - ChosenAttack.Damage;
        Console.WriteLine($"{Target.Title} Took {ChosenAttack.Damage} Damage From {ChosenAttack.Special}");
    } 

    public void PrintInfo()
    {
        Console.WriteLine($"{Title} is Currently {Health} Health");
    }
}

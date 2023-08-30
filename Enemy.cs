class Enemy
{
    public string Title;
    // public string _Title {get {return Title;}}
    public int Health;
    // public int _Health {get {return Health;}}
    public List<Attack> AttackList;


    public Enemy(string title, int health)
    {
        Title = title;
        Health = health;
        AttackList = new List<Attack>();
    }

    public void RandomAttack()
    {
        Random weapon = new();
        int random = weapon.Next(0,AttackList.Count);
        Console.WriteLine($"{Title} Did {AttackList[random].Special} It Took Away {AttackList[random].Damage} Health");
    }


    public void PrintInfo()
    {
        Console.WriteLine($"{Title} is Currently {Health} Health");
    }
}

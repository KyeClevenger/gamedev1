class Attack 
{
    public string Special;
    // public string _Special {get {return Special;}}
    public int Damage;
    // public int _Damage {get {return Damage;}}


    public Attack(string special, int damage)
    {
        Special = special;
        Damage = damage;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Special} Did {Damage} Damage Points");
    }
}
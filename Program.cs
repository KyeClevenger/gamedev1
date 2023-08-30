Enemy Guard = new("Guard" , 100);
Console.WriteLine($"Enemy {Guard.Title} Is Your Opponent");
Console.WriteLine($"Guard is {Guard.Health} Health");

Attack Sword = new("Sword" , 20);
Console.WriteLine($"You Selected {Sword.Special}");
Console.WriteLine($"Sword Swung: Blade Did {Sword.Damage} Attack Damage");

Attack Crossbow = new("Crossbow" , 15);
Console.WriteLine($"You Selected {Crossbow.Special}");
Console.WriteLine($"Crossbow Shot: Arrow Did {Crossbow.Damage} Attack Damage");

Attack Torch = new("Torch" , 10);
Console.WriteLine($"You Selected {Torch.Special}");
Console.WriteLine($"Torch Armed: Burn Did {Torch.Damage} Attack Damage");

Guard.AttackList.Add (Sword);
Guard.AttackList.Add (Crossbow);
Guard.AttackList.Add (Torch);

Guard.PrintInfo();
Sword.PrintInfo();
Crossbow.PrintInfo();
Torch.PrintInfo();

for (int i = 0; i < Guard.AttackList.Count; i++)
{
Console.WriteLine(Guard.AttackList[i].Special);
}

Guard.RandomAttack();
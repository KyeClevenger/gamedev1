Enemy Guard = new("Guard");
Range Sniper =new("Sniper");
Melee Minion =new("Minion");
Magic Zoltar =new("Zoltar");

Console.WriteLine($"Enemy {Guard.Title} Is Your Opponent");

Attack Sword = new("Sword" , 20);
// Console.WriteLine($"You Selected {Sword.Special}");
Console.WriteLine($"Sword Swung: Blade Did {Sword.Damage} Attack Damage");

Attack Crossbow = new("Crossbow" , 15);
// Console.WriteLine($"You Selected {Crossbow.Special}");
Console.WriteLine($"Crossbow Shot: Arrow Did {Crossbow.Damage} Attack Damage");

Attack Torch = new("Torch" , 10);
// Console.WriteLine($"You Selected {Torch.Special}");
Console.WriteLine($"Torch Armed: Burn Did {Torch.Damage} Attack Damage");

Guard.AttackList.Add (Sword);
Guard.AttackList.Add (Crossbow);
Guard.AttackList.Add (Torch);

// Guard.PrintInfo();
// Sword.PrintInfo();
// Crossbow.PrintInfo();
// Torch.PrintInfo();

foreach (Attack type in Guard.AttackList)
{
Console.WriteLine(type.Special);
}

Guard.RandomAttack();
Sniper.Heal(Zoltar);
Sniper.Heal(Sniper);
Zoltar.Dash();
Guard.PerformAttack(Guard, Crossbow);
Zoltar.PerformAttack(Guard, Zoltar.AttackList[1]);
Sniper.PerformAttack(Minion, Sniper.AttackList[0]);
Minion.PerformAttack(Zoltar, Minion.AttackList[1]);
Zoltar.PerformAttack(Minion, Zoltar.AttackList[1]);
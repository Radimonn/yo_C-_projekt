using System;
using System.Collections.Generic;
using System.Linq;

namespace Aréna_RPG;

class Program
{
	static void Main()
	{
		Player player = null;
		
		bool overeni = true;
		
		while (overeni)
		{
			Console.WriteLine("===Vyberte hrdinu===");
			Console.WriteLine("1 ---- Rogue (HP 50, DM 80)");
			Console.WriteLine("2 ---- Rytíř (HP 100, DM 40)");
			Console.WriteLine("3 ---- Čaroděj (HP 80, DM 60)");
		
			string vyber = Console.ReadLine();
			
			Console.Write("Zadejte jak se chcete jmenovat: ");
			
			string name = Console.ReadLine();
			
			switch (vyber)
			{
				case "1":
					player = new Player(name, 50, 80);
					break;
				case "2":
					player = new Player(name, 100, 40);
					break;
				case "3":
					player = new Player(name, 80, 60);
					break;
				default:
					Console.WriteLine("Špatné zadaní...");
					break;
			}
			Console.WriteLine($"Jste spokojeni se jménem {name} a HP: {player.MaxHP}, DM: {player.BaseDamage}? [ano - ne]: ");
			
			string zaver = Console.ReadLine();

			if (zaver == "ano")
			{
				overeni = false;
				Console.Clear();
			}
			else
			{
				Console.WriteLine("Tak znova...");
				Thread.Sleep(3000);
				Console.Clear();
			}
		}
		Console.Clear();

		List<Enemy> enemies = new List<Enemy>();
		enemies.Add(new Goblin("Goblin Petr"));
		enemies.Add(new Bandit("Bandit Jan"));
		enemies.Add(new Drak("Drak Jonaš"));
		

		Enemy enemy = enemies[0];
		
		Console.WriteLine("=== Bitva započala ===");
		
		while (player.IsAlive && enemy.IsAlive)
		{
			Console.WriteLine($"[{player.Name}] -------- [{enemy.Name}] \nHP: {player.CurrentHP}           HP: {enemy.CurrentHP} \nDM: {player.BaseDamage}            DM: {enemy.BaseDamage}");
			
			Console.WriteLine("\n1 - Útok\n2 - Super útok\n3 - Léčení");
			string volba = Console.ReadLine();

			if (volba == "1")
			{
				player.Attack(enemy);
			}
			else if (volba == "2")
			{
				player.UseSpecialAbility(enemy);
			}
			else if (volba == "3")
			{
				player.Heal();
			}

			if (enemy.IsAlive)
			{
				Console.WriteLine($"\nTah nepřítele {enemy.Name}");
				Thread.Sleep(1000);
				enemy.Attack(player);
				Thread.Sleep(1000);
				Console.WriteLine($"Po ubrání jsou vaše životy: {player.CurrentHP}");
				Thread.Sleep(1000);
			}
			
			if (!player.IsAlive)
			{
				Console.WriteLine("Umřel jste! Konec hry...");
				return;
			}
		}

		Console.WriteLine("Výborně... zabili jste Goblina, resetují se vám životy a můžete si koupit vylepšení... [1 - životy], [2 - damage]: ");
		string vylepseni = Console.ReadLine();
		if (vylepseni == "1")
		{
			player.MaxHP += 30;
			player.CurrentHP =  player.MaxHP;
		}
		else if (vylepseni == "2")
		{
			player.BaseDamage += 30;
			player.CurrentHP =  player.MaxHP;
		}
		Console.WriteLine("Výborně.. nyní se posouváte na další bitvu...");
		Thread.Sleep(3000);
		Console.Clear();
		
		enemy = enemies[1];
		
		Console.WriteLine("=== Bitva započala ===");
		
		while (player.IsAlive && enemy.IsAlive)
		{
			Console.WriteLine($"[{player.Name}] -------- [{enemy.Name}] \nHP: {player.CurrentHP}           HP: {enemy.CurrentHP} \nDM: {player.BaseDamage}            DM: {enemy.BaseDamage}");
			
			Console.WriteLine("\n1 - Útok\n2 - Super útok\n3 - Léčení");
			string volba = Console.ReadLine();

			if (volba == "1")
			{
				player.Attack(enemy);
			}
			else if (volba == "2")
			{
				player.UseSpecialAbility(enemy);
			}
			else if (volba == "3")
			{
				player.Heal();
			}

			if (enemy.IsAlive)
			{
				Console.WriteLine($"\nTah nepřítele {enemy.Name}");
				Thread.Sleep(1000);
				enemy.Attack(player);
				Thread.Sleep(1000);
				Console.WriteLine($"Po ubrání jsou vaše životy: {player.CurrentHP}");
				Thread.Sleep(1000);
			}
			
			if (!player.IsAlive)
			{
				Console.WriteLine("Umřel jste! Konec hry...");
				return;
			}
		}
		
		Console.WriteLine("Výborně... zabili jste Bandita, resetují se vám životy a můžete si koupit vylepšení... [1 - životy], [2 - damage]: ");
		vylepseni = Console.ReadLine();
		if (vylepseni == "1")
		{
			player.MaxHP += 30;
			player.CurrentHP =  player.MaxHP;
		}
		else if (vylepseni == "2")
		{
			player.BaseDamage += 30;
			player.CurrentHP =  player.MaxHP;
		}
		Console.WriteLine("Výborně.. nyní se posouváte na další bitvu...");
		Thread.Sleep(3000);
		Console.Clear();
		
		enemy = enemies[2];
		
		Console.WriteLine("=== Bitva započala ===");
		
		while (player.IsAlive && enemy.IsAlive)
		{
			Console.WriteLine($"[{player.Name}] -------- [{enemy.Name}] \nHP: {player.CurrentHP}           HP: {enemy.CurrentHP} \nDM: {player.BaseDamage}            DM: {enemy.BaseDamage}");
			
			Console.WriteLine("\n1 - Útok\n2 - Super útok\n3 - Léčení");
			string volba = Console.ReadLine();

			if (volba == "1")
			{
				player.Attack(enemy);
			}
			else if (volba == "2")
			{
				player.UseSpecialAbility(enemy);
			}
			else if (volba == "3")
			{
				player.Heal();
			}

			if (enemy.IsAlive)
			{
				Console.WriteLine($"\nTah nepřítele {enemy.Name}");
				Thread.Sleep(1000);
				enemy.Attack(player);
				Thread.Sleep(1000);
				Console.WriteLine($"Po ubrání jsou vaše životy: {player.CurrentHP}");
				Thread.Sleep(1000);
			}
			
			if (!player.IsAlive)
			{
				Console.WriteLine("Umřel jste! Konec hry...");
				return;
			}
		}
		Console.Clear();
		Console.WriteLine("Gratuluji vám k úspěšnému dohrání hry!");
	}
}
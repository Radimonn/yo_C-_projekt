namespace Aréna_RPG;

public abstract class Character
{
    public string Name { get; set; }
    public int MaxHP { get; set; }
    public int CurrentHP { get; set; }
    public int BaseDamage { get; set; }

    
    public bool IsAlive
    {
        get { return CurrentHP > 0; }
    }

    public virtual void TakeDamage(int amount)
    {
        CurrentHP -= amount;
        if (CurrentHP <= 0)
        {
            CurrentHP = 0;
        }
    }
    
    public Character(string name,  int maxHP, int damage)
    {
        Name = name;
        MaxHP = maxHP;
        CurrentHP = maxHP;
        BaseDamage = damage;
    }
    
}

public class Player : Character, IAttacker, IAttackable, ISpecialAbility
{
    public Player (string name, int health, int baseDamage)
        : base( name, health, baseDamage){}
    
    public void TakeDamage(int amount)
    {
        CurrentHP -= amount;
        if (CurrentHP <= 0)
        {
            CurrentHP = 0;
        }
    }
     
    public int Attack(IAttackable target)
    {
        int damage = BaseDamage;
        target.TakeDamage(damage);
        return damage;
    }

    public void UseSpecialAbility(Character target)
    {
        Random rand = new Random();
        if (rand.Next(0, 100) < 40)
        {
            Console.WriteLine("Dáváte superútok!");
            int damage = BaseDamage * 2;
            target.TakeDamage(damage);
        }
    }

    public void Heal()
    {
        int healAmount = 50;
        CurrentHP += healAmount;
         
        Random rand = new Random();
        if (rand.Next(0, 100) < 30)
        {
            CurrentHP *= 2;
            Console.WriteLine($"{Name} Super vyléčení!");
        }
         
        if (CurrentHP > MaxHP)
        {
            CurrentHP = MaxHP;
        }
    }
}

public class Enemy : Character, IAttackable, IAttacker
{
    public Enemy (string name, int health, int baseDamage)
        : base(name, health, baseDamage){}
    
    public void TakeDamage(int amount)
    {
        CurrentHP -= amount;
        if (CurrentHP <= 0)
        {
            CurrentHP = 0;
        }
    }
     
    public virtual int Attack(IAttackable target)
    {
        int damage = BaseDamage;
        target.TakeDamage(damage);
        return damage;
    }
}

public class Drak : Enemy
{
    public Drak(string name)
        : base (name, 80, 30){}

    public override int Attack(IAttackable target)
    {
        int damage = BaseDamage;
        
        //Šance na misnutí
        Random rand1 = new Random();
        if (rand1.Next(0, 100) < 50)
        {
            Console.WriteLine($"{Name} vás minul!");
        }
        else
        {
            Console.WriteLine($"{Name} vám udělil poškození!");
            target.TakeDamage(damage);
            if (CurrentHP <= 40)
            {
                Random rand = new Random();
                if (rand.Next(0, 100) < 30)
                {
                    damage = damage * 2;
                    Console.WriteLine($"{Name} udělal kritický zásah!");
                    target.TakeDamage(damage);
                }
            }
        }
        
        return damage;
    }
}

public class Goblin : Enemy
{
    public Goblin(string name)
        : base (name, 200, 20){}

    public override int Attack(IAttackable target)
    {
        int damage = BaseDamage;
        
        //Šance na misnutí
        Random rand1 = new Random();
        if (rand1.Next(0, 100) < 10)
        {

            Console.WriteLine($"{Name} vás minul!");
        }
        else
        {
            Console.WriteLine($"{Name} vám udělil poškození!");
            target.TakeDamage(damage);
            if (CurrentHP <= 80)
            {
                Random rand = new Random();
                if (rand.Next(0, 100) < 30)
                {
                    damage = damage * 2;
                    Console.WriteLine($"{Name} udělal kritický zásah!");
                    target.TakeDamage(damage);
                }
            }
        }
        
        return damage;
    }
}

public class Bandit : Enemy
{
    public Bandit(string name)
        : base (name, 150, 50){}

    public override int Attack(IAttackable target)
    {
        int damage = BaseDamage;
        
        //Šance na misnutí
        Random rand1 = new Random();
        if (rand1.Next(0, 100) < 20)
        {
            Console.WriteLine($"{Name} vás minul!");
        }
        else
        {
            Console.WriteLine($"{Name} vám udělil poškození!");
            target.TakeDamage(damage);
            if (CurrentHP <= 60)
            {
                Random rand = new Random();
                if (rand.Next(0, 100) < 30)
                {
                    damage = damage * 2;
                    Console.WriteLine($"{Name} udělal kritický zásah!");
                    target.TakeDamage(damage);
                }
            }
        }
        
        return damage;
    }
}
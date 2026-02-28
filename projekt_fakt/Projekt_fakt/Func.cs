namespace Aréna_RPG;

public interface ISpecialAbility
{
    void UseSpecialAbility(Character target);
}

public interface IAttacker
{
    int Attack(IAttackable target);
}

public interface IAttackable
{
    int CurrentHP { get; set; }
    void TakeDamage(int amount);
}
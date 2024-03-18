// See https://aka.ms/new-console-template for more information
public class Character
{
    private ICombatStrategy _combatStrategy;
    public Character()
    {

    }
    public Character(ICombatStrategy combatStrategy)
    {
        _combatStrategy = combatStrategy;
    }

    public void SetCombatStrategy(ICombatStrategy combatStrategy)
    {
        _combatStrategy = combatStrategy;
    }

    public void ApplyAttackStrategy()
    {
        _combatStrategy.Attack();
    }
}
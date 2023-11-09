namespace Model.Entities.Creatures.Models; 

public class CombatRound {
    public int CombatRatio { get; set; }
    public int RandomNumber { get; set; }
    public int EnduranceLossHero { get; set; }
    public int EnduranceLossEnemy { get; set; }
}
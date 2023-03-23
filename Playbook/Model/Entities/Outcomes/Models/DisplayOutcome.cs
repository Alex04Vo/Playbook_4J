using Model.Entities.Heroes;
using Model.Entities.Outcomes.SubOutcomes;
using Model.Entities.Sessions;

namespace Model.Entities.Outcomes.Models; 

public class DisplayOutcome {
    public AOutcome Outcome { get; set; }
    public bool IsChooseable { get; set; } = false;
    public string Type { get; set; }
    public int? RandomNumber { get; private set; } = null;

    public DisplayOutcome(AOutcome outcome, Hero hero, int random) {
        Outcome = outcome;
        Type = Outcome.GetType().Name;
        RandomNumber = random;
        IsChooseable = CheckOutcome(hero);
    }

    private bool CheckOutcome(Hero hero) {
        switch (this.Type) {
            case "DefaultOutcome" :
                return true; break;
            case "AbilityOutcome" :
                var abilityOutcome = (AbilityOutcome)this.Outcome;
                return hero.Abilities.Any(a => a.AbilityType == abilityOutcome.AbilityType);
                break;
            case "GoldOutcome" : 
                var goldOutcome = (GoldOutcome)this.Outcome;
                return hero.HeroOwnership.GoldCoins > Math.Abs(goldOutcome.Amount);
                break;
            case "ItemOutcome" : 
                var itemOutcome = (ItemOutcome)this.Outcome;
                return hero.Inventory.Items.Any(i=>i.ItemId == itemOutcome.ItemId);
                break;
            case "RandomOutcome" : 
                var randomOutcome = (RandomOutcome)this.Outcome;
                return randomOutcome.Min <= RandomNumber && RandomNumber <= randomOutcome.Max;
                break;
            case "MissionFailedOutcome" :
                return false; break;
            default: 
                return false; break;
        }
    }
}
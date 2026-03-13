using Model.Core.GoodyHuts.Outcomes;
using Model.Core.Units;

namespace Model.Core.GoodyHuts
{
    public class GoodyHut
    {
        private List<GoodyHutOutcome> _outcomes = new();

        public GoodyHut() 
        {
            // Gold
            _outcomes.Add(new GoldOutcome(50));
            // Mercenaries
            _outcomes.Add(new MercenariesOutcome());
            // Technology (scrolls)
            _outcomes.Add(new ScrollsOutcome());
            // Advanced Tribe (new city or nomads)
            _outcomes.Add(new AdvancedTribeOutcome());
            _outcomes.Add(new NomadsOutcome());
            // Barbarians
            _outcomes.Add(new BarbariansOutcome());
            //Abandoned Village / Nothing
            _outcomes.Add(new AbandonedVillageOutcome());
        }

        public GoodyHutOutcomeResult Trigger(Unit unit)
        {
            // Base chance of each outcome is equal. Certain game circumstances modify this ratio.
            // https://apolyton.net/forum/civilization-series/civilization-i-and-civilization-ii/82184-a-study-of-hut-outcomes
            var outcome = _outcomes[new Random().Next(0, _outcomes.Count)];
            return outcome.ApplyOutcome(unit);
        }
    }
}

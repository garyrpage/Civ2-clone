using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    internal class AbandonedVillageOutcome : GoodyHutOutcome
    {
        public string Name => "Abandoned Village";
        public AbandonedVillageOutcome() : base("SURPRISENOTHING") { }

        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            throw new NotImplementedException();
        }
    }
}

using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    public class AbandonedVillageOutcome : GoodyHutOutcome
    {
        public string Name => "Abandoned Village";
        public AbandonedVillageOutcome() : base("SURPRISENOTHING") { }

        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            return new GoodyHutOutcomeResult(Message, true, "Nothing");
        }
    }
}

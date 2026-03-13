using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    public class MercenariesOutcome : GoodyHutOutcome
    {
        public MercenariesOutcome() : base("SURPRISEMERCS") { }
        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            return new GoodyHutOutcomeResult(Message, true, "Mercenaries");
        }
    }
}

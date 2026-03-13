using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    public class BarbariansOutcome : GoodyHutOutcome
    {
        public string Name => "Barbarians";
        public BarbariansOutcome() : base("SURPRISEBARB") { }
        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            return new GoodyHutOutcomeResult(Message, true, "Barbarians");
        }
    }
}

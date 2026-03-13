using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    internal class BarbariansOutcome : GoodyHutOutcome
    {
        public string Name => "Barbarians";
        public BarbariansOutcome() : base("SURPRISEBARB") { }
        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            throw new NotImplementedException();
        }
    }
}

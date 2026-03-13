using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    internal class MercenariesOutcome : GoodyHutOutcome
    {
        public MercenariesOutcome() : base("SURPRISEMERCS") { }
        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            throw new NotImplementedException();
        }
    }
}

using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    internal class ScrollsOutcome : GoodyHutOutcome
    {
        public string Name => "Scrolls";
        public ScrollsOutcome() : base("SURPRISESCROLLS") { }
        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            throw new NotImplementedException();
        }
    }
}

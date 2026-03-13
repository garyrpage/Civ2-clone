using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    public class ScrollsOutcome : GoodyHutOutcome
    {
        public string Name => "Scrolls";
        public ScrollsOutcome() : base("SURPRISESCROLLS") { }
        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            return new GoodyHutOutcomeResult(Message, true, "Scrolls");
        }
    }
}

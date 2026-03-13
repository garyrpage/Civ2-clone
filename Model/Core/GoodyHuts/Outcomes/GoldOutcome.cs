using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    public class GoldOutcome : GoodyHutOutcome
    {        
        private readonly int _amount;
        public GoldOutcome(int amount) : base("SURPRISEMETALS")
        {
            _amount = amount;
        }
        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            unit.Owner.Money += _amount;
            return new GoodyHutOutcomeResult(Message, true, "Gold")
            {
                ReplaceNumbers = [_amount]
            };
        }
    }
}

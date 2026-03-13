using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    public abstract class GoodyHutOutcome
    {
        protected string Message { get; set; }
        public abstract GoodyHutOutcomeResult ApplyOutcome(Unit unit);

        protected GoodyHutOutcome(string message)
        {
            Message = message;
        }
    }

    public class GoodyHutOutcomeResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string OutcomeType { get; set; }
        public IList<int>? ReplaceNumbers { get; set; }

        public GoodyHutOutcomeResult(string message, bool success, string outcomeType = "Unknown")
        {
            Message = message;
            Success = success;
            OutcomeType = outcomeType;
        }
    }
}

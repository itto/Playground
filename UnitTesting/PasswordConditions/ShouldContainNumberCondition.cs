using System.Linq;

namespace Kristof.Kata.SecurityManagement.PasswordConditions
{
    public class ShouldContainNumberCondition : NoNullPasswordConditionBase
    {
        public ShouldContainNumberCondition(string password) : base(password)
        {
        }

        public override string Reason()
        {
            return "Should contain at least one number";
        }

        public override bool IsMet()
        {
            return Password.ToCharArray().Any(c => char.IsNumber(c));
        }
    }
}
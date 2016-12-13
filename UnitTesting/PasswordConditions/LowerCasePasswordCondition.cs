namespace Kristof.Kata.SecurityManagement.PasswordConditions
{
    public class LowerCasePasswordCondition : NoNullPasswordConditionBase
    {
        public LowerCasePasswordCondition(string password) : base(password)
        {
        }

        public override string Reason()
        {
            return "Should contain lowercase";
        }

        public override bool IsMet()
        {
            return !string.Equals(Password, Password.ToUpperInvariant());
        }
    }
}
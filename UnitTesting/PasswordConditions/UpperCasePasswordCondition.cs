namespace Kristof.Kata.SecurityManagement.PasswordConditions
{
    public class UpperCasePasswordCondition : NoNullPasswordConditionBase
    {
        public UpperCasePasswordCondition(string password) : base(password)
        {
        }

        public override bool IsMet()
        {
            return !string.Equals(Password, Password.ToLowerInvariant());
        }

        public override string Reason()
        {
            return "Should contain uppercase";
        }
    }
}
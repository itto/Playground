namespace Kristof.Kata.SecurityManagement.PasswordConditions
{
    public class NoNullPasswordCondition : NoNullPasswordConditionBase
    {
        public NoNullPasswordCondition(string password) : base(password)
        {
        }

        public override string Reason()
        {
            return "Value cannot be null.";
        }

        public override bool IsMet()
        {
            return !string.IsNullOrEmpty(Password);
        }
    }
}
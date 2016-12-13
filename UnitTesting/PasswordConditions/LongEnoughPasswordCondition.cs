namespace Kristof.Kata.SecurityManagement.PasswordConditions
{
    public class LongEnoughPasswordCondition : NoNullPasswordConditionBase
    {
        public LongEnoughPasswordCondition(string password) : base(password)
        {
        }

        public override string Reason()
        {
            return "Not long enough";
        }

        public override bool IsMet()
        {
            return Password.Length >= 8;
        }
    }
}
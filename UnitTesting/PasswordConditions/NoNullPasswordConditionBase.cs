namespace Kristof.Kata.SecurityManagement.PasswordConditions
{
    public abstract class NoNullPasswordConditionBase : IPasswordCondition
    {
        protected readonly string Password;

        protected NoNullPasswordConditionBase(string password)
        {
            Password = password;
        }

        public abstract string Reason();

        public abstract bool IsMet();
    }
}
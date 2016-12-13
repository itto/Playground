namespace Kristof.Kata.SecurityManagement.PasswordConditions
{
    public interface IPasswordCondition
    {
        string Reason();
        bool IsMet();
    }
}
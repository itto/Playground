namespace Kristof.Kata.SecurityManagement.UnitTests
{
    public class PersonBuilder
    {
        private int _salary;

        public PersonBuilder WithSalary(int salary)
        {
            this._salary = salary;
            return this;
        }

        public Person Build()
        {
            return new Person(this._salary);
        }
    }
}
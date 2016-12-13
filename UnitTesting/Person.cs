namespace Kristof.Kata.SecurityManagement
{
    public class Person
    {
        private readonly int _salary;
        private int _hours;

        public Person(int salary)
        {
            _salary = salary;
        }

        public void AddHoursWorked(int hours)
        {
            _hours += hours;
        }

        public int GetSalary()
        {
            return _salary*_hours;
        }
    }
}
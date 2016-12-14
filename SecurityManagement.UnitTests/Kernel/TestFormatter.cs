using System;
using Kristof.Kata.SecurityManagement.Kernel;

namespace Kristof.Kata.SecurityManagement.UnitTests.Kernel
{
    internal class TestFormatter
    {
        public void Print<TCommand>(EventSpecification<TCommand> specification) where TCommand : class, ICommand
        {
            Console.WriteLine("Specification: " + specification.GetType().Name.Replace("_", " "));
            Console.WriteLine();

            Console.WriteLine("Given that: ");
            foreach (var @event in specification.Given())
                Console.WriteLine("\t" + @event);

            Console.WriteLine();
            Console.WriteLine("When " + specification.When());
            Console.WriteLine();

            Console.WriteLine("Expect that: ");
            foreach (var @event in specification.Expect())
                Console.WriteLine("\t" + @event);
        }
    }
}
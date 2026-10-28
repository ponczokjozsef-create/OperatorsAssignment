using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values to its properties
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "John";
            employee1.LastName = "Smith";

            // Instantiate the second Employee object and assign values to its properties.
            // It has a different name, but the SAME Id as employee1.
            Employee employee2 = new Employee();
            employee2.Id = 1;
            employee2.FirstName = "Jane";
            employee2.LastName = "Doe";

            // Display both employees
            Console.WriteLine("Employee 1: Id = " + employee1.Id + ", " + employee1.FirstName + " " + employee1.LastName);
            Console.WriteLine("Employee 2: Id = " + employee2.Id + ", " + employee2.FirstName + " " + employee2.LastName);

            // Compare the two objects with the overloaded "==" operator (compares the Id)
            Console.WriteLine("employee1 == employee2: " + (employee1 == employee2));

            // Compare the two objects with the overloaded "!=" operator
            Console.WriteLine("employee1 != employee2: " + (employee1 != employee2));

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
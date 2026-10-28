using System;

namespace OperatorsAssignment
{
    // The Employee class with Id, FirstName and LastName properties
    class Employee
    {
        // Properties that store the employee's data
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator:
        // two Employee objects are equal if their Id properties are the same
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // If both variables point to the same object (or both are null), they are equal
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            // If only one of them is null, they are not equal
            if (employee1 is null || employee2 is null)
            {
                return false;
            }

            // Otherwise compare the Id properties
            return employee1.Id == employee2.Id;
        }

        // Overload the "!=" operator.
        // Comparison operators must be overloaded in pairs, so "==" needs a matching "!=".
        // It simply returns the opposite of the "==" result.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }

        // Override Equals() so it uses the same rule as "==" (compare by Id).
        // C# recommends this whenever "==" is overloaded.
        public override bool Equals(object obj)
        {
            return obj is Employee other && Id == other.Id;
        }

        // Override GetHashCode() so equal employees (same Id) get the same hash code.
        // C# recommends this whenever Equals() is overridden.
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
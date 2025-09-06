
// Amir Moeini Rad
// May 2025

// Main Concept: The IEnumerable<T> Interface
// IEnumerable<T> is a generic interface in the System.Collections.Generic namespace.
// It is used to define a collection of objects that can be enumerated, i.e. iterated over.
// In particular, IEnumerable<T> provides access to in-memory collections like List<T>, Array, etc.

namespace IEnumerableDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("IEnumerable<T> in C#.NET.");
            Console.WriteLine("-------------------------\n");


            // 'IEnumerable' is implemented by the 'List' class and also 'Array', etc.
            // 'IEnumerable' lacks direct data access methods such as Count, Add, etc.
            // 'IEnumerable' has no indexing capabilities. It is limited to enumeration only.
            // Use IEnumerable<T>' when you only need to iterate or apply LINQ,
            // and you want to keep your code flexible and less coupled to a specific collection type.            
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            // Also: List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            // But think of the advantages of using IEnumerable<int> instead of List<int>.


            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            
            Console.WriteLine("\nDone.");
        }
    }
}

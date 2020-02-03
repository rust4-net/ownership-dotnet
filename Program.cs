using System;

namespace ownership_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Rust4.NET -- Ownership ===");
            Console.WriteLine("C# (and .NET generally) use an accessor model");

            // Ints are intrinsic (non-object) values which are allocated on the stack
            //  74 is assigned to x; the value of x is copied to y
            int x = 74;
            int y = x;

            Console.WriteLine($"\tInteger value (stack), x = {x}");
            Console.WriteLine($"\tInteger value (stack),  y = {y}");
            Console.WriteLine();


            // Strings are objects which are allocated on the heap
            //  'Hello!' is allocated on the heap, and s1 points to it
            //  s1's pointer value (memory address) is copied to s2
            string s1 = "Hello!";
            string s2 = s1;

            Console.WriteLine($"\tString value on heap, s1 = {s1}");
            Console.WriteLine($"\tString value on heap, s2 = {s2}");
            Console.WriteLine($"\ts1 & s2 reference the same object? {object.ReferenceEquals(s1, s2)}");
            
        }
    }
}

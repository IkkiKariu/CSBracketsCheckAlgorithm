using DataStructures.Models;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleStack<char> stack = new SimpleStack<char>();

            BracketsCheckAlgorithm algorithm = new BracketsCheckAlgorithm(stack);

            Console.WriteLine(algorithm.Check("([]()[]{}){}"));
        }
    }
}
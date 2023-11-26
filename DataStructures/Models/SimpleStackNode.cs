using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Models
{
    internal class SimpleStackNode<T>
    {
        public T Value { get; private set; }

        public SimpleStackNode<T>? Next { get; set; } = null;
        public SimpleStackNode<T>? Previous { get; set; } = null;


        public SimpleStackNode(T value)
        {
            Value = value;
        }

        public void ShowState()
        {
            string state = "";

            state += Previous != null ? $"Previous: {Previous.Value}\n" : $"Previous: null\n";
            state += $"Value: {Value}\n";
            state += Next != null ? $"Next: {Next.Value}\n" : $"Next: null\n";

            Console.WriteLine(state);
        }
    }
}

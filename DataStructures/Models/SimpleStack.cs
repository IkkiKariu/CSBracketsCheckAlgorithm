using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Models
{
    internal class SimpleStack<T>
    {
        public SimpleStackNode<T>? Tail { get; private set; } = null;


        public void Put(SimpleStackNode<T> node)
        {
            if (Tail == null)
            {
                node.Next = null;
                node.Previous = null;

                Tail = node;
            }
            else
            {
                node.Previous = Tail;
                node.Next = null;

                Tail.Next = node;
                Tail = node;
            }
        }

        public SimpleStackNode<T>? Pop()
        {
            if (Tail == null)
            {
                return null;
            }
            else
            {
                var oldTail = Tail;

                Tail = Tail.Previous;

                if (Tail != null)
                {
                    Tail.Next = null;
                }

                oldTail.Previous = null;

                return oldTail;
            }
            
        }

        public bool IsEmpty()
        {
            return Tail == null ? true : false;
        }

        public SimpleStackNode<T>? Peek ()
        {
            return Tail;
        }

        public void ShowState()
        {
            string state = "";

            state += Tail != null ? $"Tail: {Tail.Value}\n" : $"Tail: null\n";

            Console.WriteLine(state);
        }
    }
}

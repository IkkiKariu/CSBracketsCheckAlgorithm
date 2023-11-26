using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Models
{
    internal class BracketsCheckAlgorithm
    {
        private SimpleStack<char> stack;

        public BracketsCheckAlgorithm(SimpleStack<char> stack) 
        {
            this.stack = stack;
        }

        public bool Check (string sequence)
        {
            foreach (char c in sequence)
            {
                var top = stack.Peek();

                switch (c)
                {
                    case '(':   
                    case '[':
                    case '{':
                        stack.Put(new SimpleStackNode<char>(c));
                        break;
                    case ')':
                        if (stack.IsEmpty())
                        {
                            return false;
                        }
                        else
                        {
                            if (top.Value == '(')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                    case ']':
                        if (stack.IsEmpty())
                        {
                            return false;
                        }
                        else
                        {
                            if (top.Value == '[')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                    case '}':
                        if (stack.IsEmpty())
                        {
                            return false;
                        }
                        else
                        {
                            if (top.Value == '{')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                }
            }

            return stack.IsEmpty() ? true : false;
        }
    }
}

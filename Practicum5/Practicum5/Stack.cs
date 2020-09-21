using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum5
{
    public class Stack : IStack
    {
        protected StackLink First { get; set; }

        public void Push(string value)
        {
            StackLink stack = new StackLink();
            if (First != null)
            {
                stack.Next = First;
            }
            else
            {
                stack.Next = null;
            }
            stack.String = value;
            First = stack;
        }

        public string Pop()
        {
            if (First == null)
            {
                return null;
            }

            string value = First.String;

            if (First.Next != null)
            {
                First = First.Next;
                
            }
            else
            {
                First = null;
            }
            return value;
        }

        public string Peek()
        {
            if (First != null)
            {
                return First.String;
            }
            return null;
        }

        public bool IsEmpty()
        {
            if (First == null)
            {
                return true;
            }
            return false;
        }
    }
}

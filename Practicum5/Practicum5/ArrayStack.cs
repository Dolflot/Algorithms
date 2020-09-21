using Alg1.Practica.Utils;
using System;

namespace Alg1.Practica.Practicum5
{
    public class ArrayStack : IStack
    {
        protected string[] values;
        protected int size;

        public ArrayStack(int capacity)
        {
            if (capacity > 0)
            {
                values = new string[capacity];
                int size = -1;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException();
            }
            
        }

        public void Push(string value)
        {
            if (size < values.Length)
            {
                size++;
                values[size] = value;
            }
            else
            {
                throw new System.InvalidOperationException();
            }
        }

        public string Pop()
        {
            if (size > -1)
            {
                string value = values[size];
                values[size] = null;
                size--;
                return value;
            }
            else
            {
                return null;
            }
        }

        public string Peek()
        {
            if (size > -1)
            {
                return values[size];
            }
            else
            {
                return null;
            }
        }

        public bool IsEmpty()
        {
            if(size == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (size == values.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum4
{
    public class NawDoublyLinkedList
    {
        public DoubleLink First { get; set; }
        public DoubleLink Last { get; set; }

        public void InsertHead(NAW naw)
        {
            DoubleLink temp = new DoubleLink();
            temp.Naw = naw;
            if (First != null)
            {
                temp.Next = First;
                First.Previous = temp;
            }
            else
            {
                Last = temp;
            }
            First = temp;
        }

        public NAW ItemAtIndex(int index)
        {
            throw new System.NotImplementedException();
        }

        public DoubleLink SwapLinkWithNext(DoubleLink link)
        {
            if (link.Next != null)
            {
                if (link.Previous == null)
                {
                    link.Next.Previous = null;
                    First = link.Next;
                }
                else
                {
                    link.Next.Previous = link.Previous;
                    link.Previous.Next = link.Next;
                }
                link.Previous = link.Next;
                if (link.Next.Next == null)
                {
                    link.Next = null;
                    Last = link;
                }
                else
                {
                    link.Next.Next.Previous = link;
                    link.Next = link.Next.Next;
                }
                link.Previous.Next = link;
            }

            return link.Previous;
        }

        public void BubbleSort()
        {
            DoubleLink current = First;
            DoubleLink lastNext = Last;

            while (current != lastNext)
            {
                while (current != lastNext)
                {
                    if (current.Naw.CompareTo(current.Next.Naw) == 1)
                    {
                        SwapLinkWithNext(current);
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
                lastNext = current.Previous;
                current = First; 
            }
        }

        public BigO OrderOfBubbleSort()
        {
            return BigO.N2;
        }
    }
}

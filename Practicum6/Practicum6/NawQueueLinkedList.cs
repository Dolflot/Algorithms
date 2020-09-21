using System;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueLinkedList
    {
        public Link First { get; set; }

        protected Link Last { get; set; }

        protected int _count;

        public void Enqueue(NAW naw)
        {
            Link temp = new Link();
            if (First == null)
            {
                First = temp;
            }
            else
            {
                Last.Next = temp;
            }
           
            temp.Naw = naw;
            temp.Next = null;         
            Last = temp;
            _count++;
        }

        public NAW Dequeue()
        {
            if (First == null)
            {
                return null;
            }
            else
            {
                NAW temp = First.Naw;
                First = First.Next;
                _count--;
                return temp;
            }
           
        }

        public int Count()
        {
            return _count;
        }
    }

}

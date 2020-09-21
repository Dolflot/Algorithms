using System;
using Alg1.Practica.Practicum2;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum3
{
    public class AlternativeBubbleSortableNawArrayUnordered : BubbleSortableNawArrayUnordered
    {
        public AlternativeBubbleSortableNawArrayUnordered(int size) : base(size)
        {
        }

        public void BubbleSortAlternative()
        {
            int outer;
            int inner;


            for (outer = _size; outer > 0; outer--)
            {
                for (inner = 0; inner < outer; inner++)
                {
                    if (_nawArray[inner].CompareTo(_nawArray[inner + 1]) >= 0)
                    {
                        NAW temp = _nawArray[inner];
                        _nawArray[inner] = _nawArray[inner + 1];
                        _nawArray[inner + 1] = temp;
                    }
                }
            }
        }
    }
}

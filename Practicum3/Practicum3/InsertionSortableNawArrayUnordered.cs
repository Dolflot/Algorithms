using System;
using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;
namespace Alg1.Practica.Practicum3
{
    public class InsertionSortableNawArrayUnordered : NawArrayUnordered, IInsertionSort
    {
        public InsertionSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void InsertionSort()
        {

            int input;

            for (int output = 1; output < _used; output++)
            {
                NAW temp = _nawArray[output];
                input = output;
                
                while(input > 0 && _nawArray[input -1].CompareTo(temp) > -1)
                {
                    _nawArray[input] = _nawArray[input - 1];
                    input--;
                }
                if (_nawArray[input].CompareTo(temp) != 0){
                    _nawArray[input] = temp;
                }

               

            }
        }

        public void InsertionSortInverted()
        {
            int input;

            for (int output = 1; output < _used; output++)
            {
                NAW temp = _nawArray[output];
                input = output;
                
                while(input > 0 && _nawArray[input -1].CompareTo(temp) > -1)
                {
                    _nawArray[input] = _nawArray[input - 1];
                    input--;
                }

                if (_nawArray[input].CompareTo(temp) != 0)
                {
                    _nawArray[input] = temp;
                }

            }
        }


    }
}

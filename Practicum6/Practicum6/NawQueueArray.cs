using System;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueArray
    {
        public int Front { get; set; }

        public int Rear { get; set; }

        protected Alg1NawArray _array; // interne array
        protected int _count; // aantal gebruikte index in interne array
        protected int _size; // maximale omvang van interne array

        public NawQueueArray(int initialSize)
        {
            // aanmaken intern array
            if ((initialSize > 0) && (initialSize <= 1000))
            {
                _size = initialSize;
            }
            else
            {
                throw new NawQueueArrayInvalidSizeException();
            }

            _array = new Alg1NawArray(_size);

            // verdere initialisatie

            Front = 0;
            Rear = -1;
        }

        public void Enqueue(NAW naw)
        {
            if(_count < _size)
            {
                _count++;
                Rear = (Rear + 1) % (_size);
                _array[Rear] = naw;
            }
            else
            {
                throw new NawQueueArrayOutOfBoundsException();
            }
        }

        public NAW Dequeue()
        {
            if (_count > 0)
            {

                NAW temp = _array[Front];
                _array[Front] = null;
                Front = (Front + 1) % (_size);
                _count--;
                return temp;
            }
            else
            {
                return null;
            }
        }

        public int Count()
        {
            return _count;
        }
    }

}

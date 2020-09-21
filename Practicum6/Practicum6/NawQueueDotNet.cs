using System;
using System.Collections;
using System.Collections.Generic;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueDotNet
    {

        private Queue<NAW> queue = new Queue<NAW>();

        public void Enqueue(NAW naw)
        {
            queue.Enqueue(naw);
        }

        public NAW Dequeue()
        {
            if(queue.Count == 0)
            {
                return null;
            }

            return queue.Dequeue();
        }

        public int Count()
        {
            return queue.Count;
        }

    }
}

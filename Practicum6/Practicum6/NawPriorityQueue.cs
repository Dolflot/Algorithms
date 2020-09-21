using System;
using System.Collections.Generic;
using System.Linq;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawPriorityQueue
    {

        public SortedDictionary<int, NawQueueLinkedList> _priorityQueue { get; set; }

        public NawPriorityQueue()
        {
            _priorityQueue = new SortedDictionary<int, NawQueueLinkedList>();
        }
        public void Enqueue(int priority, NAW naw)
        {
            NawQueueLinkedList queue;
            if (_priorityQueue.ContainsKey(priority))
            {
                 _priorityQueue.TryGetValue(priority, out queue);
                queue.Enqueue(naw);
                _priorityQueue.Remove(priority);
                _priorityQueue.Add(priority, queue);
            }
            else
            {
                queue = new NawQueueLinkedList();
                queue.Enqueue(naw);
                _priorityQueue.Add(priority, queue);
            }
        }

        public NAW Dequeue()
        {
            NawQueueLinkedList queue;
            if (_priorityQueue.Count > 0)
            {
                int key = _priorityQueue.Keys.First();
                _priorityQueue.TryGetValue(key, out queue);
                _priorityQueue.Remove(key);
                NAW temp = queue.Dequeue();
                if(queue.Count() > 0)
                {
                    _priorityQueue.Add(key, queue);
                }
                return temp;
            }

            return null;
        }

        public int Count()
        {
            int count = 0;
            NawQueueLinkedList queue;

            if (_priorityQueue.Count > 0)
            {
                foreach (KeyValuePair<int, NawQueueLinkedList> pair in _priorityQueue)
                {
                    int key = pair.Key;
                    _priorityQueue.TryGetValue(key, out queue);
                    count += queue.Count();
                }
            }

            return count;
        }

        public void Show()
        {
        }
    }
}

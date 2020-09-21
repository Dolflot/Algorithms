using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg1.Practica.Practicum1
{
    public class NawArrayUnordered : INawArray
    {
        protected Alg1NawArray _nawArray;
        public Alg1NawArray Array => _nawArray;
        protected int _size;
        protected int _used;
        public NawArrayUnordered(int initialSize)
        {
            if (initialSize < 1 || initialSize > 1000000)
            {
                throw new NawArrayUnorderedInvalidSizeException();
            }
            else
            {
                _size = initialSize;
                _used = 0;
                _nawArray = new Alg1NawArray(initialSize);
            }
        }

        public int Count
        {
            get { return ItemCount(); }
            set { _used = value; }
        }

        public int ItemCount()
        {
            return _used;
        }

        public virtual void Add(NAW item)
        {
            if (_used == _size)
            {
                throw new NawArrayUnorderedOutOfBoundsException();
            }
            else
            {
                _nawArray[_used] = item;
                _used += 1;
            }
        }

        public int Find(NAW item)
        {
            for (int i = 0; i < _used; i++)
            {
                if (_nawArray[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }



        public void Show()
        {
            System.Console.WriteLine("Array contains {0} of {1} items.", _used, _size);
            for (int i = 0; i < _size; i++)
            {
                if (i == _used)
                {
                    System.Console.WriteLine("------------------------------------------------------");
                }
                System.Console.Write("Item {0} contains: ", i);
                if (_nawArray[i] != null)
                {
                    _nawArray[i].Show();
                }
                else
                {
                    System.Console.WriteLine("nothing");
                }
            }
        }

        public NAW ItemAtIndex(int index)
        {
            if (index > _used)
            {
                throw new NawArrayUnorderedOutOfBoundsException();
            }
            else
            {
                return _nawArray[index];
            }
        }

        public void RemoveAtIndex(int index)
        {
            if (index > _used)
            {
                throw new NawArrayUnorderedOutOfBoundsException();
            }
            else
            {
                for (int j = index; j < _used; j++)
                {
                    _nawArray[j] = _nawArray[j + 1];
                }
                _used--;
            }
        }

        public bool Remove(NAW item)
        {
            int index = Find(item);
            if (index == -1)
            {
                return false;
            }
            else
            {
                RemoveAtIndex(index);
                return true;
            }
        }

    }

}

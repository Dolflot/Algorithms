using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;
using Alg1.Practica.Practicum1;


namespace Alg1.Practica.Practicum2
{
    public class BinarySearchableNawArrayOrdered : NawArrayOrdered, IBinarySearch
    {
        public BinarySearchableNawArrayOrdered(int initialSize) : base(initialSize)
        {
        }

        public int FindBinary(NAW item)
        {
            int lowerbound = 0;
            int upperbound = (_used - 1);
            int curInt;

            if (_used == 0)
            {
                return -1;
            }

            while (true)
            {
                curInt = (upperbound + lowerbound) / 2;

                if (_nawArray[curInt].CompareTo(item) == 0)
                {
                    return curInt;
                }
                else if (_nawArray[curInt].CompareTo(item) == -1)
                {
                    lowerbound = curInt + 1;
                }
                else if (_nawArray[curInt].CompareTo(item) == 1)
                {
                    upperbound = curInt - 1;
                }
            }

        }

        public void AddBinary(NAW item)
        {
            if (_used == _size)
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }
            else if (_used == 0)
            {
                _nawArray[0] = item;
                _used++;
            }
            else {

                int lowerbound = 0;
                int upperbound = (_used - 1);
                int curInt;

                while (true)
                {
                    curInt = (upperbound + lowerbound) / 2;
                    int x = _nawArray[curInt].CompareTo(item);
                    if (x == 0)
                    {
                        break;
                    }
                    else if (upperbound == lowerbound)
                    {
                        if (x == -1)
                        {
                            curInt++;
                        }
                        break;
                    }
                    else if (x == -1)
                    {
                        lowerbound = curInt + 1;
                    }
                    else if (x == 1)
                    {
                        upperbound = curInt - 1;
                    }
                }

                for (int i = _used; i > curInt; i--)
                {
                    _nawArray[i] = _nawArray[i - 1];
                }
                _nawArray[curInt] = item;
                _used++;

            }
           
        }
    }
}

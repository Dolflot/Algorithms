using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;

namespace Alg1.Practica.Practicum2
{
    public class BubbleSortableNawArrayUnordered : NawArrayUnordered, IBubbleSort
    {
        public BubbleSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void BubbleSort()
        {
            for (int i = 0; i < _used; i++)
            {
                for (int y = 0; y < (_used - i - 1); y++)
                {
                    if (_nawArray[y].CompareTo(_nawArray[y + 1]) == 1)
                    {
                        _nawArray.Swap(y, y + 1);
                    }
                }
            }
        }

        public void BubbleSortInverted()
        {
            for(int i = 0; i < _used; i++)
            {
                for (int y = _used -1; y > i; i--)
                {
                    if (_nawArray[y - 1].CompareTo(_nawArray[y]) == 1)
                    {
                        _nawArray.Swap(y - 1, y);
                    }
                }
            }
        }
    }
}

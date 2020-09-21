using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;
namespace Alg1.Practica.Practicum3
{
    public class SelectionSortableNawArrayUnordered : NawArrayUnordered, ISelectionSort
    {
        public SelectionSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void SelectionSort()
        {
            int min;

            for (int output = 0; output < _used; output++)
            {
                min = output;

                for (int input = output + 1; input < _used; input++)
                {
                    if (_nawArray[input].CompareTo(_nawArray[min]) < 1)
                    {
                        min = input;
                    }
                }
                if (min > output)
                {
                    _nawArray.Swap(output, min);
                }
            }
        }

        public void SelectionSortInverted()
        {
            int min;

            for (int output = _used - 1; output > 0; output--)
            {
                min = output;

                for (int input = 0; input < output; input++)
                {
                    if (_nawArray[input].CompareTo(_nawArray[min]) == 1)
                    {
                        min = input;
                    }
                }
                if (min < output)
                {
                    _nawArray.Swap(output, min);
                }
            }
        }
    }
}

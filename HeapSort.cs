namespace SelectionAndHeapSorting
{
    internal class HeapSort
    {
        int[] arr;

        public HeapSort(int[] array)
        {
            arr = array;
        }
        public int[] Sort()
        {
            var length = arr.Length;
            for (var i = length / 2 - 1; i >= 0; i--)
                Heapify(length, i);

            for (var i = length - 1; i > 0; i--)
            {
                Swap(i, 0);
                Heapify(i, 0);
            }
            return arr;
        }

        public void Heapify(int length, int i)
        {
            var largest = i;
            var leftBranch = 2 * i + 1;
            var rightBranch = 2 * i + 2;

            if (leftBranch < length && arr[leftBranch] > arr[largest])
                largest = leftBranch;

            if (rightBranch < length && arr[rightBranch] > arr[largest])
                largest = rightBranch;

            if (largest != i)
            {
                Swap(largest, i);
                Heapify(length, largest);
            }
        }
        private void Swap(int index1, int index2)
        {
            int value = arr[index2];
            arr[index2] = arr[index1];
            arr[index1] = value;
        }
    }
}

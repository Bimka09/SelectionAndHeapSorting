using SelectionAndHeapSorting;

int[] testArray = new int[] { 5, 3, 2, 7, 9, 4, 8, 1, 5, 8, 1, 5, 2, 5, 7, 2};
var a = new SelectionSort(testArray);
Console.WriteLine(String.Join(",", a.Sort()));
var b = new HeapSort(testArray);
Console.WriteLine(String.Join(",", b.Sort()));


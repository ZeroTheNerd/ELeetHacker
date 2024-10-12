// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> arr = [4, 5, 3, 7, 2];

static List<int> quickSort(List<int> arr)
{
    List<int> left = new List<int>();
    List<int> right = new List<int>();
    List<int> equal = new List<int>();
    List<int> partitionedArr = new List<int>();
    int pivot = arr[0];
    for (int i = 0; i < arr.Count; i++)
    {
        if (arr[i] < pivot)
        {
            left.Add(arr[i]);
        }
        else if (arr[i] > pivot)
        {
            right.Add(arr[i]);
        }
        else
        {
            equal.Add(arr[i]);
        }
    }
    for (int i = 0; i < left.Count; i++)
    {
        partitionedArr.Add(left[i]);

    }
    for (int i = 0; i < equal.Count; i++)
    {
        partitionedArr.Add(equal[i]);
    }

    for (int i = 0; i < right.Count; i++)
    {
        partitionedArr.Add(right[i]);
    }
    return partitionedArr;
}

}
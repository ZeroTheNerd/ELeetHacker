

static List<int> countingSort(List<int> arr)
{
    int min = arr.Min();
    int max = arr.Max();
    int range = (max - min) + 1;
    List<int> numCount = new List<int>();
    for (int i = 0; i < 100; i++)
    {
        numCount.Add(0);
    }
    for (int i = 0; i < arr.Count; i++)
    {
        numCount[arr[i]]++;
    }
    return numCount;

}



static List<int> countingSort(List<int> arr)
{
    int min = arr.Min();
    int max = arr.Max();
    int range = (max - min) + 1;
    List<int> numCount = new List<int>();
    List<int> orderedList = new List<int>();
    //Initialize numCount List
    for (int i = 0; i < 100; i++)
    {
        numCount.Add(0);
    }
    //Count the frequency of values
    for (int i = 0; i < arr.Count; i++)
    {
        numCount[arr[i]]++;
    }
    //Create orderedList
    for (int i = 0; i < numCount.Count; i++)
    {
        for (int j = 0; j < numCount[i]; j++)
        {
            orderedList.Add(i);
        }
    }
    return orderedList;
}



// See https://aka.ms/new-console-template for more information
int insertionShiftsCount = 0;
int quicksortShiftsCount = 0;
//This is for the HackerRank problem itself
/*int n = int.Parse(Console.ReadLine());
int[] ar = new int[n];
// Read entire line and split it into parts
string[] inputs = Console.ReadLine().Split(' ');
for (int i = 0; i < n; i++)
{
    ar[i] = int.Parse(inputs[i]); // Parse each input as an integer
}
List<int> list = new List<int>();
for (int i = 0; i < ar.Length; i++)
{
    list.Add(ar[i]);
}*/

int[] ar = [406, 157, 415, 318, 472, 46, 252, 187, 364, 481, 450, 90, 390, 35, 452, 74, 196, 312, 142, 160, 143, 220, 483, 392, 443, 488, 79, 234, 68, 150, 356, 496, 69, 88, 177, 12, 288, 120, 222, 270, 441, 422, 103, 321, 65, 316, 448, 331, 117, 183, 184, 128, 323, 141, 467, 31, 172, 48, 95, 359, 239, 209, 398, 99, 440, 171, 86, 233, 293, 162, 121, 61, 317, 52, 54, 273, 30, 226, 421, 64, 204, 444, 418, 275, 263, 108, 10, 149, 497, 20, 97, 136, 139, 200, 266, 238, 493, 22, 17, 39];
List<int> list = new List<int>();
for(int i = 0; i < ar.Length; i++)
{
    list.Add(ar[i]);
}
quicksort(ar, 0, ar.Length - 1);
insertionSort2(ar.Length, list);

void quicksort(int[] array, int lo, int hi)
{
    if (lo >= hi || lo < 0) return;

    int pivot = array[hi];
    int wall = lo;

    //Partition with a wall
    for (int i = lo; i < hi; i++)
    {
        if (array[i] < pivot)
        {
            swap(array, i, wall);
            wall++;
        }
    }

    //Place pivot
    swap(array, hi, wall);

    //Print after partition
    //printArray(array);

    //Sort left of partition
    quicksort(array, lo, wall - 1);

    //Sort right of partition
    quicksort(array, wall + 1, hi);
}


void swap(int[] array, int index1, int index2)
{
    int tmp = array[index1];
    array[index1] = array[index2];
    array[index2] = tmp;
    quicksortShiftsCount++;

}

void insertionSort2(int n, List<int> arr)
{
    for (int i = 0; i < arr.Count - 1; i++)
    {
        if (arr[i + 1] < arr[i])
        {
            for (int j = i + 1; j >= 1; j--)
            {
                if (arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    insertionShiftsCount++;

                }


            }
        }
    }
}
Console.WriteLine(insertionShiftsCount - quicksortShiftsCount);
    

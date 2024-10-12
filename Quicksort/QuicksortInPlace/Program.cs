// See https://aka.ms/new-console-template for more information
/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
int n = int.Parse(Console.ReadLine());
int[] ar = new int[n];
// Read entire line and split it into parts
string[] inputs = Console.ReadLine().Split(' ');
for (int i = 0; i < n; i++)
{
    ar[i] = int.Parse(inputs[i]); // Parse each input as an integer
}

static void quicksort(int[] array, int lo, int hi)
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
    printArray(array);

    //Sort left of partition
    quicksort(array, lo, wall - 1);

    //Sort right of partition
    quicksort(array, wall + 1, hi);
}


static void swap(int[] array, int index1, int index2)
{
    int tmp = array[index1];
    array[index1] = array[index2];
    array[index2] = tmp;
}

static void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}
    
    
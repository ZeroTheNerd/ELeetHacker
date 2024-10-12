int n = 7;
int[] ar = [5, 8, 1, 3, 7, 9, 2];
quickSort2(ar);
static void quickSort2(int[] ar)
{
    if (ar.Length <= 1)
    {
        return;
    }
    //int size = int.Parse(Console.ReadLine());
    int pivot = ar[0];
    int[] left = Array.FindAll(ar, x => x < pivot);
    int[] right = Array.FindAll(ar, x => x > pivot);
    int[] equal = Array.FindAll(ar, x => x == pivot);
    //List<int> partitionedArr = new List<int>();
   

    ///Console.WriteLine(string.Join(" ", left) + " " + string.Join(" ", equal) + " " + string.Join(" ", right));

    quickSort2(left);
    quickSort2(right);
    // Combine the sorted arrays (left + equal + right)
    int[] sortedArray = new int[ar.Length];
    left.CopyTo(sortedArray, 0);
    equal.CopyTo(sortedArray, left.Length);
    right.CopyTo(sortedArray, left.Length + equal.Length);

    Array.Copy(sortedArray, ar, ar.Length);

    Console.WriteLine(string.Join(" ", ar));

}


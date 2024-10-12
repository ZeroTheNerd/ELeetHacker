// See https://aka.ms/new-console-template for more information

int n = 7;
int[] ar= [5, 8, 1, 3, 7, 9, 2];
quickSort2(ar);
static void quickSort2(int[] ar)
{
    if (ar.Length >= 1)
    {
        return;
    }
    //int size = int.Parse(Console.ReadLine());
    int pivot = ar[0];
    int[] left = [];
    int[] right = [];
    int[] equal = [];
    List<int> partitionedArr = new List<int>();
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] < pivot)
        {
            left.Append(ar[i]);
        }
        else if (ar[i] > pivot)
        {
            right.Append(ar[i]);
        }
        else
        {
            equal.Append(ar[i]);
        }
    }

    Console.WriteLine(string.Join(" ", left) + " " + string.Join(" ", equal) + " " + string.Join(" ", right));

    quickSort2(left);
    quickSort2(right);
    // Combine the sorted arrays (left + equal + right)
    int[] sortedArray = new int[ar.Length];
    left.CopyTo(sortedArray, 0);
    equal.CopyTo(sortedArray, left.Length);
    right.CopyTo(sortedArray, left.Length + equal.Length);

    Array.Copy(sortedArray, ar, ar.Length);

    //Console.WriteLine(string.Join(" ", ar));

}


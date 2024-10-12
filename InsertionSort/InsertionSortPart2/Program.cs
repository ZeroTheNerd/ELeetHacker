// See https://aka.ms/new-console-template for more information
int n = 8;
List<int> arr = [8, 7, 6, 5, 4, 3, 2, 1];
//List<int> arr = [1, 4, 3, 5, 6, 2];

static void insertionSort2(int n, List<int> arr)
{
    for(int i = 0; i < arr.Count - 1; i++)
    {
        if (arr[i+ 1] < arr[i])
        {
            for(int j = i + 1; j >= 1; j--) {
                if (arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }

                //Console.WriteLine(string.Join(" ", arr));

            }
            //Console.WriteLine(string.Join(" ", arr));

        }
        Console.WriteLine(string.Join(" ", arr));
    }
}


insertionSort2(n, arr);

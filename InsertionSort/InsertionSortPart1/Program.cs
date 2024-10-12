// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Net;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Hello, World!");


int n = 14;
//List<int> list = [2, 4, 6, 8, 3];
List<int> list = [1, 3, 5, 9, 13, 22, 27, 35, 46, 51, 55, 83, 87, 23];
//List<int> list = [2, 3, 4, 5, 6, 7, 8, 9, 10, 1];

static void insertionSort(int n, List<int> list)
{
    int eleToInsert = list[list.Count - 1];
    for(int i = list.Count - 1; i >= 1; i--)
    {
        if (list[i - 1] < eleToInsert)
        {
            list[i] = eleToInsert;
            Console.WriteLine(string.Join(" ", list));
            break;
        }
        else
        {
            list[i] = list[i - 1];
            Console.WriteLine(string.Join(" ", list));

        }
    }

    if (list[0] == list[1])
    {
        list[0] = eleToInsert;
        Console.WriteLine(string.Join(" ", list));
    }
}

insertionSort(n, list);

/*int main()
{
    int n = 5;
    List<int> list = [2, 4, 6, 8, 3];
    insertionSort(n, list);
    return 0;
}
*/


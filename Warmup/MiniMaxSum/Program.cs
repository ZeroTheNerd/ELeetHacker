
List<int> arr = [140638725, 436257910, 953274816, 734065819, 362748590];

long max = arr.Max();
long min = arr.Min();
long sum = 0;
for (int i = 0; i < arr.Count; i++)
{
    sum += arr[i];
}
long minSum = sum - max;
long maxSum = sum - min;
Console.WriteLine(minSum + " " + maxSum);

    int n = int.Parse(Console.ReadLine());
    List<int> numCount = new List<int>(new int[100]);
    //input array
    List<int> ar = new List<int>();

    for (int i = 0; i < n; i++)
    {
        string input = Console.ReadLine();

        // Split the input into the integer and string part
        string[] parts = input.Split(' ');
        int value = int.Parse(parts[0]);

        numCount[value]++;
    }
    int sum = 0;
    for (int i = 0; i < 100; i++)
    {
        sum += numCount[i];
        Console.Write(sum + " ");
    }

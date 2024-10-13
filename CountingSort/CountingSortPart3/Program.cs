
    int n = int.Parse(Console.ReadLine());
    List<int> numCount = new List<int>(new int[100]);
    //input array
    List<int> ar = new List<int>();

    for (int i = 0; i < n; i++)
    {
        // Read the line
        string input = Console.ReadLine();

        // Split the input into the integer and string part
        string[] parts = input.Split(' ');
        int value = int.Parse(parts[0]); // The first part is the integer

        // Increment the count for this value
        numCount[value]++;
    }
    // for (int i = 0; i < 100; i++)
    // {
    //     numCount.Add(0);
    // }
    // for(int i = 0; i < ar.Count; i++) { 
    //     numCount[ar[i]]++;

    // }
    int sum = 0;
    for (int i = 0; i < 100; i++)
    {
        sum += numCount[i];
        Console.Write(sum + " ");
    }


string[] array = new string[] { "a", "bb", "ccc", "dddd", "eeeee", "fff" };
string[] digitalArray = new string[] { "1", "22", "333", "4444", "55555", "4444", "333", "22", "1" };
string[] bigArray = new string[]{"9999999","999999999999","000000000000000"};

void PrintArray(string[] array)
{
    Console.Write($"[ ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] FillResultArray(string[] array)
{
    string[] resultArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref resultArray, resultArray.Length + 1);
            resultArray[resultArray.Length - 1] = array[i];
        }
    }
    return resultArray;
}

void PrintResult(string[] array)
{
    Console.WriteLine();
    Console.Write($"[ ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.Write("] -> ");
    PrintArray(FillResultArray(array));
    
}

PrintResult(array);
PrintResult(digitalArray);
PrintResult(bigArray);

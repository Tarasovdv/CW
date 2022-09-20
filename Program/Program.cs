// Second commit 

string[] array = new string[] { "a", "bb", "ccc", "dddd", "eeeee", "fff" };
string[] digitalArray = new string[] { "1", "22", "333", "4444", "55555", "4444", "333", "22", "1" };
string[] resultArray = new string[0];


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

PrintArray(array);
PrintArray(digitalArray);
PrintArray(resultArray);
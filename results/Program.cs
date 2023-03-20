string[] ParsArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newarray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}


string[] array = { "hello", "2", "world", ":-)" };


System.Console.WriteLine("Задан массив: ");
PrintArray(array);
System.Console.WriteLine();

string[] newarray = ParsArray(array);
System.Console.WriteLine("В этом массиве символов <= 3: ");
PrintArray(newarray);

Console.Clear();

string[] InputArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

int CountLessThree(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            count++;
        }
    }

    return count;
}

string[] CreateArrayLenLessThree(string[] array)
{
    string[] tmpArray = new string[CountLessThree(array)];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            tmpArray[j] = array[i];
            j++;
        }
    }

    return tmpArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"'{array[i]}',");

        else Console.Write($"'{array[i]}'");
    }
    Console.Write("]");
}

string[] oiginalArray = InputArray();
string[] newArray = CreateArrayLenLessThree(oiginalArray);

PrintArray(oiginalArray);
Console.Write(" -> ");
PrintArray(newArray);
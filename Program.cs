Console.Write("Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[count];

void GenerateArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine();
    }
}

string[] findCountElements(string[] stringArray)
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }
    string[] result = new string[n];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            result[j] = stringArray[i];
            j++;
        }
    }
    return result;
}
void printArray(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"‘‘{stringArray[i]}’’, ");
    }

    Console.Write("]");
}
GenerateArray(stringArray);
printArray(findCountElements(stringArray));


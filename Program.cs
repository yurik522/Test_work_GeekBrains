bool FindElements(string[] collection, int stringLength)
{
    bool res = false;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i].Length <= stringLength)
        {
            res = true;
        }
    }
    return res;
}

string[] CreateSortArray(string[] matrix, int length)
{
    string[] newArray = new string[0];
    int j = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <= length)
        {
            Array.Resize(ref newArray, 1 + j);
            newArray[j] = matrix[i];
            j++;
        }
    }
    return newArray;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0,4}", $"\"{array[i]}\",");
    }
    Console.WriteLine("{0,4}", $"\"{array[array.Length - 1]}\"]");
}
string[] inputArray = new string[]{"Три", "вещи", "не", "возвращаются", "обратно", "-", "время", "слово", 
                             "возможность.", "Так", "что", "не", "теряй", "времени,", "выбирай", 
                             "слова", "и", "не", "упускай", "возможности"};
int lengthElement = 3;
if (FindElements(inputArray, lengthElement))
{
    PrintArray(CreateSortArray(inputArray, lengthElement));
}
else
    Console.WriteLine("[]");


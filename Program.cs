
bool FindElements(string[] collection, int stringLength) //определяем наличие элементов, удовлетворяющих
{                                                        //условию задачи
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

string[] CreateNewArray(string[] arrayInput, int lengthFindElements) // создаём из элементов, удовлетворя-
{                                                                    //ющих условию задачи новый массив
    string[] newArray = new string[0];
    int len = arrayInput.Length;
    int index = 0;
    int newIndex = 0;
    for (index = 0; index < len; index++)
    {
        if (arrayInput[index].Length <= lengthFindElements)
        {
            Array.Resize(ref newArray, 1 + newIndex);
            newArray[newIndex] = arrayInput[index];
            newIndex++;
        }
    }
    return newArray;
}
void PrintArray(string[] array) //метод вывода массива в консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("{0,4}", $"\"{array[i]}\",");
    }
    Console.WriteLine("{0,4}", $"\"{array[array.Length - 1]}\"]");
}
//Задаём массив строк
string[] inputArray = new string[]{"Три", "вещи", "не", "возвращаются", "обратно", "-", "время", "слово", 
                             "возможность.", "Так", "что", "не", "теряй", "времени,", "выбирай", 
                             "слова", "и", "не", "упускай", "возможности"};
//Задаём условие
int lengthElement = 3;

if (FindElements(inputArray, lengthElement))
{
    PrintArray(inputArray); //вывод заданного массива в консоль
    Console.WriteLine();
    PrintArray(CreateNewArray(inputArray, lengthElement));
}
else
{
    PrintArray(inputArray);
    Console.WriteLine();
    Console.WriteLine("[]");
}
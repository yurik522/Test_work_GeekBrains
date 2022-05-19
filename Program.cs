string[] array = new string[]{"Три", "вещи", "не", "возвращаются", "обратно", "-", "время", "слово", 
                             "возможность.", "Так", "что", "не", "теряй", "времени,", "выбирай", 
                             "слова", "и", "не", "упускай", "возможности"};
Console.WriteLine(array.Length);

int j = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i].Length <= 3) j++;        
// }
string[] newArray = new string[0];
Console.WriteLine(j);
j = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3) 
    {
        Array.Resize(ref newArray, 1 + j);
        newArray[j] = array[i];
        Console.Write($"\"{newArray[j]}\" ");
        j++;
    }
    //Console.WriteLine($" i = {i}, j = {j}");
}
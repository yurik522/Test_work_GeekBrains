string[] array = new string[]{"Три", "вещи", "не", "возвращаются", "обратно", "-", "время", "слово", 
                             "возможность.", "Так", "что", "не", "теряй", "времени,", "выбирай", 
                             "слова", "и", "не", "упускай", "возможности"};
Console.WriteLine(array.Length);
// foreach (str s in array)
// {
//    for(int i = 0; i<array.Length |; i) 
// }
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3) j++;        
}
string[] newArray = new string[j];
Console.WriteLine(j);
j = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3) 
    {
        newArray[j] = array[i];
        Console.Write($"\"{newArray[j]}\" ");
        j++;
    }
    //Console.WriteLine($" i = {i}, j = {j}");
}
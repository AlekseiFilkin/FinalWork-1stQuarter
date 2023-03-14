/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] stringArray = { "Hello", "2", "world", ":-)" };

string[] CreateArray(string[] array)
{
    string[] newArray = new string[array.Length];
    return newArray;
}

string[] FillAndCutArray(string[] array, string[] newArray)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref newArray, j);
    return newArray;
}

void PrintArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"'{newArray[i]}'");
    }
}

string[] resultArray = CreateArray(stringArray);
resultArray = FillAndCutArray(stringArray, resultArray);
Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам:");
PrintArray(resultArray);
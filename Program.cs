// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateNewArray(string[] Array)
{
    int size = Array.Length;
    int newSize = 0;
    for (int i = 0; i < size; i++)
    {
        string el = Array[i];
        int k = el.Count();
        if (k <= 3)
        {
            newSize++;
        }
    }
    String[] newArray = new string[newSize];
    int ii = 0;
    for (int i = 0; i < size; i++)
    {
        string el = Array[i];
        int k = el.Count();
        if (k <= 3)
        {
            newArray[ii] = el;
            ii++;
        }
    }
    return newArray;
}

void PrintArray(string[] A)
{
    int size = A.Length;
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        string el = '"' + A[i] + '"';
        if (i == size - 1)
            Console.Write($"{el}");
        else
            Console.Write($"{el}, ");
    }
    Console.Write("]");
}

String[] A1 = new string[] { "Hello", "2", "word", ":-)" };
String[] A2 = new string[] { "1234", "1567", "-2", "computer science" };
String[] A3 = new string[] { "Russia", "Denmark", "Kazan" };

String[] newArray1 = CreateNewArray(A1);
PrintArray(newArray1);
Console.WriteLine();

String[] newArray2 = CreateNewArray(A2);
PrintArray(newArray2);
Console.WriteLine();

String[] newArray3 = CreateNewArray(A3);
PrintArray(newArray3);
Console.WriteLine();

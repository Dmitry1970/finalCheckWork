// Итоговая проверочная работа
// Задача
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2". "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Write("Введите количество строк в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Вы ввели неправильное число. Введите число больше 0");
    Environment.Exit(0);
}

String[] stringArray = new String[number];
int stringLength = 3;
int size = 0;
Console.WriteLine("Введите строки: ");
for (int i = 0; i < stringArray.Length; i++)
{
    Console.Write($"Строка {i} : ");
    stringArray[i] = Console.ReadLine();

    if (stringArray[i].Length <= stringLength)
    {
        size++;
    }
}

if (size == 0)
{
    Console.WriteLine("[]");
}
else
{
    String[] newArray = new String[size];
    CreateNewArray(stringArray, newArray);
    PrintArray(newArray);
}


String[] CreateNewArray(String[] stringMyArray, String[] newMyArray)
{

    int j = 0;
    for (int i = 0; i < stringMyArray.Length; i++)
    {
        if (stringMyArray[i].Length <= stringLength)
        {
            newMyArray[j] = stringMyArray[i];
            j++;
        }
    }

    return newMyArray;
}

void PrintArray(String[] newMyArray)
{
    Console.Write("[");
    for (int i = 0; i < newMyArray.Length; i++)
    {
        if (i < newMyArray.Length - 1)
        {
            Console.Write($"{newMyArray[i]}, ");
        }
    }
    Console.Write($"{newMyArray[newMyArray.Length - 1]}");
    Console.WriteLine("]");
}




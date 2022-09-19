// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();


//*********************************************************************************************************************
//Вариант 1. 

// //string[] array = { "Hello", "2", "world", ":-)" };
// string[] array = { "1234", "1567", "-2", "computer science" };
// //string[] array = {"Russia", "Denmark", "Kazan"};

// string[] newArray = new string [array.Length];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i].Length <= 3)
//     {
//         newArray[i] = array[i];
//     }
// }

// Console.Write(string.Join(" ", newArray));


//*********************************************************************************************************************
//Вариант 2. 

string[] array = { "Hello", "2", "world", ":-)" };
//string[] array = { "1234", "1567", "-2", "computer science" };
//string[] array = {"Russia", "Denmark", "Kazan"};


string[] newArray = new string [0];


for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Array.Resize(ref newArray, newArray.Length + 1);
        newArray[newArray.Length - 1] = array[i];
    }
}

Console.Write(string.Join(" ", newArray));


//*****************************************************************************
// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// PrintArray(newArray);

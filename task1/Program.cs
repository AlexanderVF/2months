// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] Array = new string[] {"first", "new", "hotel", "2", ";-)", "super"};
int count = 0;


for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"{Array[i]},");
    if (Array[i].Length < 4)
    {
        count++;
    }
}
Console.WriteLine();

string[] Array2 = new string[count];
int j = 0;

for (int i = 0; i < Array.Length; i++) {
    if (Array[i].Length < 4) {
        Array2[j] = Array[i];
        Console.Write($"{Array2[j]}, ");
        j++;
    }
}



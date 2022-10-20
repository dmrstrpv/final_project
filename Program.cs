// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры: 
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]


int ReadLineNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

string ReadLineMessage(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();

}

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ReadLineMessage($"Введите {i + 1} элемент");
    }
    Console.WriteLine("Спасибо!");

}

void ArrayCheck(string[] arr, string[] arr1)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr1[j] = arr[i];
            j++;

        }

    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

}

int number = ReadLineNumber("Введите количество элементов");
string[] array = new string[number];
string[] arrayOutput = new string[number];
FillArray(array);
ArrayCheck(array, arrayOutput);
Console.WriteLine();
PrintArray(arrayOutput);
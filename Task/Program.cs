//Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше либо
//равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении
//не рекомендуется пользоваться коллекциями, лучше обойтись
//исключительно массивами.

Console.Clear();

Console.WriteLine("Введите колиство объектов в массиве");
int objects = Convert.ToInt32(Console.ReadLine());

string[] array = new string[objects];

for (int i = 0; i < objects; i++)
{
    Console.WriteLine($"Введите объект номер {i}");
    array[i] = Console.ReadLine();
}

void PrintArray(string[] inputArray)
{
    Console.Write("[ ");
    for(int i = 0; i < inputArray.GetLength(0); i++)
    {
        Console.Write(inputArray[i] + "; ");
    }
    Console.Write("]");
}

string[] CheckArray(string[] inputArray)
{
    int count = 0;

    for(int i = 0; i < inputArray.GetLength(0); i++)
    {
        if(inputArray[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];

    int j = 0;

    for(int i = 0; i < inputArray.GetLength(0); i++)
    {
        if(inputArray[i].Length <= 3)
        {
            newArray[j] = inputArray[i];
            j++;
        }
    }

    return newArray;
}

PrintArray(array);
Console.Write(" -> ");
PrintArray(CheckArray(array));
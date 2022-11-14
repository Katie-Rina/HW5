// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int N, int first, int last)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(first, last + 1);
    }
    return RandomArray;
}

void ShowAndEvenNumbered(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чётных чисел в массиве: {count}");
}

Console.Clear();
int[] arr = CreateRandomArray(50, 100, 999);
ShowAndEvenNumbered(arr);

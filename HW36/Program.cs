// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Под "нечётной позицией" я понимаю нечётный индекс элемента массива, 
// как и показано в примере.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int N, int first, int last)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(first, last + 1);
    }
    return RandomArray;
}

void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SummNumOddIndex(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        summ += arr[i];
    }
    Console.Write($"Сумма элементов на нечётных позициях = {summ}");
}

Console.Clear();
int[] arr = CreateRandomArray(10, -100, 100);
ShowArray(arr);
SummNumOddIndex(arr);



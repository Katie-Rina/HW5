// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRealArray(int N, int last)
{
    double[] RandomArray = new double[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = Math.Round(((new Random().NextDouble())*last), 2);
    }
    return RandomArray;
}

void ShowArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void DiffMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"Максимальный элемент массива на {max - min} больше минимального");
}

Console.Clear();
double[] arr = CreateRealArray(10, 100);
ShowArray(arr);
DiffMaxMin(arr);


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[]array = GetArray(8, 1, 100);
Console.WriteLine (string.Join (" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue+1);
    }
    return res;
}
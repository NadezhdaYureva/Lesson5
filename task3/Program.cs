// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void PrintArray(double[] r)
{
    for (int i = 0; i < r.Length; i++)
    {
        System.Console.Write(r[i] + " ");
    }
}
double[] array;
array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();

}
double MinMaxDiff(double[] array)
{
    double result = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; }
        if (array[i] < min) { min = array[i]; }
    }
    result = max - min;
    return result;
}

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {MinMaxDiff(array):f2}");


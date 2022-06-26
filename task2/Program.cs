// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void PrintArray(int[] r)
{
    for (int i = 0; i < r.Length; i++)
    {
        System.Console.Write(r[i] + " ");
    }
}
int[] array;
array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);

}
int SumOfOddPos(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i = i + 2)
        result = result + array[i];
    return result;
}

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {SumOfOddPos(array)}");
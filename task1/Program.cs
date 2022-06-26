// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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
    array[i] = new Random().Next(100, 1000);

}
int NumberEven (int [] array)
{
    int result=0;
    for (int i=0; i<array.Length; i++)
    if (array[i]%2==0) result++;
    return result;
}
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно {NumberEven(array)}");
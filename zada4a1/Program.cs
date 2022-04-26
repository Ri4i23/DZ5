/* Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] numbers = new int[10];
FillArray(numbers);
WriteArray(numbers);

int even = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 == 0)
    {
        even = numbers[i];
        Console.WriteLine(even);
    } 
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void WriteArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
     {
         Console.Write(array[i] + " ");
     }
     Console.WriteLine();
}

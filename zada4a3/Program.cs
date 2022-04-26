/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] numbers = new int[5];
FillArray(numbers);
WriteArray(numbers);

int max = 0;
int min = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < min) ;
    {
        min = numbers[i];
    }
    if (numbers[i] > max) ;
    {
        max = numbers[i];
    }
}
Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);
void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
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

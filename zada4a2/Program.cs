/* Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Length];
FillArray(numbers);
PrintArray(numbers);

int sum = 0;

for(int i = 0; i < numbers.Length; i++)
{
    int ostatok = i % 2;
    if(ostatok == 1)
    {
        sum = sum + numbers[i];
    } 
}
Console.WriteLine("sum = {0}", sum );

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array1)
{
     for(int i = 0; i < array1.Length; i++)
     {
         Console.Write(array1[i] + " ");
     }
     Console.WriteLine();
}

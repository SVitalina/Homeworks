// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [345, 897, 568, 234] -> 2

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] masiv)
{
    for (int count = 0; count < masiv.Length; count++)
    {
        masiv[count] = new Random().Next(0, 20);
    }
}

void PrintArray(int[] masiv)
{
    for (int count = 0; count < masiv.Length; count++)
    {
        Console.Write($"{masiv[count]}, ");
    }
}

int sum = 0;
for (int count = 1; count < array.Length; count+=2)
{
    sum = array[count] + sum;
    
}
Console.WriteLine();
Console.WriteLine("Сумма всех чисел стоящих на нечетных позициях :" + sum);





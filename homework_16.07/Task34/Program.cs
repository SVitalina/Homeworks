//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] masiv)
{
    for (int count = 0; count < masiv.Length; count++)
    {
        masiv[count] = new Random().Next(100, 999);
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

for (int count = 0; count < array.Length; count++)
{
    int lastN = array[count] % 2;

    if (lastN == 0)
    {
        sum = sum + 1;
    }
    else
    {
    }
}
Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве : "+sum);




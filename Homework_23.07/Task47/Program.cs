//Задача 47: Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами.

double[,] numbers = new double[5, 4];
FillArray(numbers);
PrintArray(numbers);

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int random = new Random().Next(0, 2);
            if (random == 1)
            {
                numbers[i, j] = new Random().NextDouble() * 100;
            }
            else
            {
                numbers[i, j] = new Random().Next(-99, 99);
            }

        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + " ");
        }
        Console.WriteLine();
    }
}


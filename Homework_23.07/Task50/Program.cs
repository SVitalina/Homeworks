//Задача 50: Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента или же 
//указание, что такого элемента нет. Во вводе первая цифра - номер строки, 
//вторая - столбца. Цифры не больше 9.

Console.Write("Введите позицию элемента в двумерном массиве");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в двумерном массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[5, 4];
FillArray(matrix);
PrintArray(matrix);
Find(matrix, rows, columns);
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {

            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();

    }
}

void Find(int[,] array, int rows, int columns)
{
    if (array.GetLength(0) >= rows && array.GetLength(1) >= columns)
    {
        Console.WriteLine("Ваше число : "+array[rows, columns]);
    }
    else 
    {
        Console.WriteLine("Такого элемента нет");
    }
}
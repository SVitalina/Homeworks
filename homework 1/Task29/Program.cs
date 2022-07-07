// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран. Вывод сделать отдельным методом.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


int [] array = new int [8];

void FillArray(int[]array)
{
   int size = array.Length;
   int count = 0;
   while (count < size)
   {
    array[count] = new Random().Next(1,10);
    count++;
   }
}

void PrintArray(int[]masivchik)
{
    int size = masivchik.Length;
    int count = 0;
    while (count < size)
    {
        Console.WriteLine(masivchik[count]);
        count++;
    }
}

FillArray(array);
PrintArray(array);


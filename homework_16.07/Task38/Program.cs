//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void PrintArray(double[] masiv)
{
    for (int count = 0; count < masiv.Length; count++)
    {
        Console.Write($"{ masiv[count] }, ");
    }
}

double [] array = {9, 4, 6, 7, 9.897, 8, 8, -0.1, -5, 2, 5.986, 6,};
    double max = 0;
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        else 
        {
        }
    }
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Максимальное число в массиве : " + max);
    Console.WriteLine("Минимальное число в массиве : " + min);
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + (max - min));


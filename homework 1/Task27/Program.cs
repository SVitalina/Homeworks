// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите числo ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (N>0)
{
  sum = N%10 + sum;
  N = N/10;

}
Console.WriteLine(sum);



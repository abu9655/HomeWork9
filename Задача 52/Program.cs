//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int sum (int n,int m)
{
    if (n==m+1)
    {
      return 0;
    }
  return n + sum(n+1,m);
}
Console.WriteLine("Введите число N: ") ;
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ") ;
int m = Convert.ToInt32(Console.ReadLine());
int Sum =  sum(n,m);
Console.WriteLine(Sum) ;
